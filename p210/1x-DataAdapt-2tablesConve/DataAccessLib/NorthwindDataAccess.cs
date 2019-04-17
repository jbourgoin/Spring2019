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
        //Note:  If your server is not named localhost, you will need to change the connection string
        // private const string connectString = @"Server = localhost;Database=Northwind;Integrated Security=SSPI";
        private const string connectString = @"Server = A254J-T006006;Database=Northwind;Integrated Security=SSPI";

        // Generic error message for database issues
        private const string sqlErrorMessage = "Database operation failed.  Please contact your System Administrator";

        /// <summary>
        /// Retrieves list of customers from the Northwind database
        /// </summary>
        /// <param name="countryName">
        /// only customers from the specified country are retrieved if the string is not ""
        /// if the string is "" (zero length string) then all customers are retrieved
        /// </param>
        /// <returns>
        /// a DataTable containing  customer names
        /// </returns>
       

        /// <summary>
        /// This method retrieves data from 2 tables in the Northwind
        /// database and returns a dataset holding the 2 tables with a DataRelation.
        /// </summary>
        /// <returns>The DataSet containing 2 tables that are related by a DataRelation
        /// </returns>
        public static DataSet GetOrders2()
        {
            // data adapter
            SqlDataAdapter northwindAdapter;
            //data set
            DataSet ordersDataSet;
            //relation
            DataRelation ordersDataRelation;

            //instantiate the data adapter
            northwindAdapter = new SqlDataAdapter();
            //instantiate the select command object
            northwindAdapter.SelectCommand = new SqlCommand();
            //instantiate the connection object
            northwindAdapter.SelectCommand.Connection = new SqlConnection();
            try
            {
                // set the connection string in the connection object
                northwindAdapter.SelectCommand.Connection.ConnectionString = connectString;
                //set the command text
                northwindAdapter.SelectCommand.CommandText =
                    "Select * from Orders order by OrderID";
                //instantiate the data set to be filled
                ordersDataSet = new DataSet("Orders DataSet");
                //contact the database
                //includes the connect and the sending of the SQL
                //and fill 1 table in the dataset
                northwindAdapter.Fill(ordersDataSet, "Orders");

                //now we wish to fill another table 
                //so we change the command text
                northwindAdapter.SelectCommand.CommandText =
                   "Select * from [Order Details] order by OrderID";
                //now we contact the database again
                // and add another table to the dataset
                northwindAdapter.Fill(ordersDataSet, "OrderDetails");

                //set up the relationship between the 2 tables
                ordersDataRelation = new DataRelation("UsefulRelation",
                    ordersDataSet.Tables["Orders"].Columns["OrderID"],
                    ordersDataSet.Tables["OrderDetails"].Columns["OrderID"]);
                ordersDataSet.Relations.Add(ordersDataRelation); // add it to the property which is a List<DataRelation>

                return ordersDataSet;
            }
            catch (SqlException sqlEx)
            {
                //here you might write details to an error log
                // that exists on a network server or in another database

                //note that we do not throw the original SQLException object
                //because the object contains information (server, database, etc.)
                //that we do not want to reveal
                throw new ApplicationException(sqlErrorMessage);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        

    }
}
