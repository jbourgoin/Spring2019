using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Results = new string[5];
            for (int i = 0; i < ViewBag.Results.GetLength(0); i++)
            {
                ViewBag.Results[i] = "";
            }

            // our 3 ADO objects for reading data from Prog117:  SqlCommand  SqlDataReader  SqlConnection
           
            SqlDataReader sqlReader;   //datareader

            SqlCommand selectCommand = new SqlCommand();

            const string connectString = @"Server=localhost; Database=northwind; Integrated Security=true";
            SqlConnection conn;
            conn = new SqlConnection(connectString);
            selectCommand = new SqlCommand("Select CompanyName, Phone from Shippers", conn);
                                   
            //open the database connection
            selectCommand.Connection.Open();

            //execute sql against the database
            sqlReader = selectCommand.ExecuteReader();
            int counter = 0;

            while (sqlReader.Read())
            {
                ViewBag.Results[counter] = sqlReader.GetString(0) + ":   " + sqlReader.GetString(1);
                counter++;
            }
           

            sqlReader.Close();
            selectCommand.Connection.Close();
           
            return View();
        }

       
    }
}