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
        private const string connectString = @"Server = localhost\SQLEXPRESS;Database=Northwind;Integrated Security=SSPI";

        // Generic error message for database issues
        private const string sqlErrorMessage = "Database operation failed.  Please contact your System Administrator";
        public static DataSet GetOrders()
        {
            SqlDataAdapter northwindAdapter = new SqlDataAdapter();
            
            northwindAdapter.SelectCommand = new SqlCommand();
            northwindAdapter.SelectCommand.Connection = new SqlConnection();
            try
            {
                northwindAdapter.SelectCommand.Connection.ConnectionString = connectString;
                northwindAdapter.SelectCommand.CommandText = "Select * from Customers order by CustomerID";

                // now fill the DataSet with the data from 3 SQL tables
                DataSet customerDataSet = new DataSet("CustomerDataSet");
                northwindAdapter.Fill(customerDataSet, "Customers");      //fill 1 datatable in the dataset
                
                //change the command text
                northwindAdapter.SelectCommand.CommandText =  "Select * from [Orders] order by OrderDate";
                northwindAdapter.Fill(customerDataSet, "Orders"); // and fill another datatable in the dataset
                
                //change the command text again
                northwindAdapter.SelectCommand.CommandText = "Select * from [Order Details] order by OrderID";
                northwindAdapter.Fill(customerDataSet, "OrderDetails"); // and fill a 3rd datatable in the dataset

                //set up the relationship between the 2 tables
                DataRelation customerDataRelation = new DataRelation("UsefulRelation",
                    customerDataSet.Tables["Customers"].Columns["CustomerID"],
                    customerDataSet.Tables["Orders"].Columns["CustomerID"]);
                // add it to the property which is a List<DataRelation>
                customerDataSet.Relations.Add(customerDataRelation);



                //set up a 2nd relationship, this time between the 2nd and 3rd tables
                DataRelation productDataRelation = new DataRelation("productDataRelation",
                    customerDataSet.Tables["Orders"].Columns["OrderID"],
                    customerDataSet.Tables["OrderDetails"].Columns["OrderID"]);
                customerDataSet.Relations.Add(productDataRelation); // add it to the property which is a List<DataRelation>
                // sadly, the DataGridView is not coded to allow one view of data, a 2nd view of a relationship, 
                // and a 3rd view which is a relationship on a relationship.
                // if we got rid of the first view, and mapped the full data in the 2nd view, 
                // then we could use3 this productDataRelation.

                return customerDataSet;
            }
            catch (SqlException sqlEx)
            {
                //here you might write details to an error log
                //note that we do not throw the original SQLException object
                //because the object contains information (server, database, etc.) that we do not want to reveal
                throw new ApplicationException(sqlErrorMessage);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        
    }
}
