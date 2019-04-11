using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLib
{
    public static class NorthwindDataAccess
    {
        //Note:  you will need to change the connection string
        const string connectString = @"Server =localhost\sqlexpress;Database=Northwind;Integrated Security=SSPI";
       
        // Generic error message for database issues
        private const string sqlErrorMessage = "Database operation failed.  Please contact your System Administrator";

       
        public static DataTable GetCustomers()
        {
            //NOTE: We are using a DataTable rather than a DataSet because we need only 1 table
            try
            {
                DataTable customerDataTable = new DataTable();  // Define and instantiate DataTable for Customer list

              
                
                // Now configure the command object

                //set up the connection for the command
                SqlConnection myConn = new SqlConnection(connectString);

                SqlCommand mySelectCommand = new SqlCommand("Select CustomerID, CompanyName from Customers order by CompanyName", myConn);// instantiate the command 

                SqlDataAdapter customerDataAdapter = new SqlDataAdapter(mySelectCommand);  //define and instantiate the DataAdapter
                //use the DataAdapter to contact the database,  note that the Fill method will open & close the connection
                // for you as well as sending the SQL to the database
                customerDataAdapter.Fill(customerDataTable);

                //return the DataTable
                return customerDataTable;
            }
            catch (SqlException sqlEx)  // catch SQL issues here
            {
                //here you might write details to an error log
                // that exists on a network server or in another database

                //note that we do not throw the original SQLException object
                //because the object contains information (server, database, etc.)
                //that we do not want to reveal
                throw new ApplicationException(sqlErrorMessage);
            }
            catch (Exception ex)  // catch any other problems here
            {
                throw ex;
            }
        }


      
        /// This method retrieves data from 2 tables in the Northwind database and returns a dataset holding the 2 data tables.
        public static DataSet GetOrders()
        {
            try
            {
                SqlDataAdapter northwindAdapter = new SqlDataAdapter();    //instantiate the data adapter
                northwindAdapter.SelectCommand = new SqlCommand();  //instantiate the select command object
                northwindAdapter.SelectCommand.Connection = new SqlConnection();  //instantiate the connection object
                northwindAdapter.SelectCommand.Connection.ConnectionString = connectString;  // set the connection string in the connection object
                northwindAdapter.SelectCommand.CommandText = "Select * from Orders"; //set the command text
                //open the connection
                //northwindAdapter.SelectCommand.Connection.Open();  <<<<<<<<  don't need this, our adapater does it for us

                DataSet ordersDataSet = new DataSet("Orders DataSet");  //instantiate the data set to be filled

                //contact the database, includes the connect and the sending of the SQL
                //and fill 1 table in the dataset <<< naming the dataset table with the same name it had in DB, but not required
                northwindAdapter.Fill(ordersDataSet, "OrdersSubset");

                //now fill another table, so we change the command text, but re-use the same same adapter and the same SelectCommand object
                northwindAdapter.SelectCommand.CommandText = "Select * from [Order Details]";
                //now we contact the database again and ADD another table to the dataset
                northwindAdapter.Fill(ordersDataSet, "OrderDetailsSubset");

                return ordersDataSet;  // sending back a C# DataSet which contains 2 DataTables
            }
            catch (SqlException sqlEx)
            {
                throw new ApplicationException(sqlErrorMessage);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
