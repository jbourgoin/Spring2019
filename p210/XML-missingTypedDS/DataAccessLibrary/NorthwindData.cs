using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLibrary
{
    public class NorthwindData
    {
        private const string connectString =
            @"Server=localhost; Database = Prog210northwind;Integrated Security=SSPI";
        private const string sqlErrorMessage =
          "Database operation failed.  Please contact your System Administrator.";
       
        /// <summary>
        /// Retrieves data from the Shippers table in the 
        /// Northwind database
        /// </summary>
        /// <returns>Typed DataSet </returns>
        public static ShippersDataSet GetShipperInfo()
        {
            SqlDataAdapter shipperDataAdapter;   // takes rows returned from database and puts them into dataset
            ShippersDataSet internalShippersDataSet;

            shipperDataAdapter = new SqlDataAdapter();  //Instantiate the data adapter
            internalShippersDataSet = new ShippersDataSet(); //Instantiate the dataset

            try
            {
                //Configure the DataAdapter
                shipperDataAdapter.SelectCommand = new SqlCommand();

                shipperDataAdapter.SelectCommand.CommandText = "Select * from Shippers order by ShipperID";
                shipperDataAdapter.SelectCommand.Connection = new SqlConnection();
                shipperDataAdapter.SelectCommand.Connection.ConnectionString = connectString;

                //Retrieve data from the database
                shipperDataAdapter.Fill(internalShippersDataSet, "Shippers");

                return internalShippersDataSet;
            }
            //catch (SqlException sqlEx)
            //{
            //    throw new ApplicationException(sqlErrorMessage);
            //}
            catch (Exception ex)
            {
                //send the exception to the presentation tier 
                throw ex;
            }
                      
        }

        /// <summary>
        /// Retrieves data from the Products table in the
        /// Northwind database
        /// </summary>
        /// <returns>typed DataSet</returns>
        public static ProductsDataSet GetProducts()
        {

            SqlDataAdapter productDataAdapter;   // takes rows returned from database and puts them into dataset
            ProductsDataSet internalProductsDataSet;     // repository to hold data from database

            //Instantiate the data adapter
            productDataAdapter = new SqlDataAdapter();

            //Instantiate the dataset
            internalProductsDataSet = new ProductsDataSet();

            try
            {

                //Configure the DataAdapter
                productDataAdapter.SelectCommand = new SqlCommand();

               productDataAdapter.SelectCommand.CommandText = "Select * from Products order by ProductID";
               productDataAdapter.SelectCommand.Connection = new SqlConnection();
               productDataAdapter.SelectCommand.Connection.ConnectionString = connectString;

                //Retrieve data from the database
               productDataAdapter.Fill(internalProductsDataSet, "Products");

                return internalProductsDataSet;
            }
            catch (SqlException sqlEx)
            {
                throw new ApplicationException(sqlErrorMessage);
            }

        }

        /// <summary>
        /// Save changes to Shipper table in Northwind database
        /// </summary>
        /// <param name="internalDataSet"></param>
        /// <returns>how many rows were changed in the database</returns>
        public static int SaveShipperInfo(ShippersDataSet internalDataSet)
        {
            int rowCount;
            SqlDataAdapter shipperDataAdapter;

            //Instantiate the data adapter
            shipperDataAdapter = new SqlDataAdapter();

            try
            {

                //Configure the DataAdapter

                //INSERT Command
                shipperDataAdapter.InsertCommand = new SqlCommand();
                shipperDataAdapter.InsertCommand.CommandText =
                    "INSERT into Shippers" +
                    "(CompanyName,Phone) " +
                    "VALUES (@CompanyName,@Phone)";

                shipperDataAdapter.InsertCommand.Connection = new SqlConnection();
                shipperDataAdapter.InsertCommand.Connection.ConnectionString = connectString;

                //Set up the parameters for the insert command

                shipperDataAdapter.InsertCommand.Parameters.Add("@CompanyName", System.Data.SqlDbType.NVarChar, 40);
                shipperDataAdapter.InsertCommand.Parameters["@CompanyName"].SourceColumn = "CompanyName";

                shipperDataAdapter.InsertCommand.Parameters.Add("@Phone", System.Data.SqlDbType.NVarChar, 24);
                shipperDataAdapter.InsertCommand.Parameters["@Phone"].SourceColumn = "Phone";

                //UPDATE Command
               shipperDataAdapter.UpdateCommand = new SqlCommand();
               shipperDataAdapter.UpdateCommand.CommandText =
                        "Update Shippers " +
                        "Set CompanyName = @CompanyName, " +
                        "Phone = @Phone " +
                        "Where ShipperID = @ShipperID";

                    //Set up the parameters for the Update command
               shipperDataAdapter.UpdateCommand.Parameters.Add("@ShipperID", System.Data.SqlDbType.Int);
               shipperDataAdapter.UpdateCommand.Parameters["@ShipperID"].SourceColumn = "ShipperID";

               shipperDataAdapter.UpdateCommand.Parameters.Add("@CompanyName", System.Data.SqlDbType.NVarChar, 40);
               shipperDataAdapter.UpdateCommand.Parameters["@CompanyName"].SourceColumn = "CompanyName";

               shipperDataAdapter.UpdateCommand.Parameters.Add("@Phone", System.Data.SqlDbType.NVarChar, 24);
               shipperDataAdapter.UpdateCommand.Parameters["@Phone"].SourceColumn = "Phone";

                //set up the connection
                shipperDataAdapter.UpdateCommand.Connection = shipperDataAdapter.InsertCommand.Connection;


                //DELETE Command

               shipperDataAdapter.DeleteCommand = new SqlCommand();
                shipperDataAdapter.DeleteCommand.CommandText =
                    "Delete from Shippers " +
                     "Where ShipperID = @ShipperID";

                shipperDataAdapter.DeleteCommand.Parameters.Add("@ShipperID", System.Data.SqlDbType.Int);
                shipperDataAdapter.DeleteCommand.Parameters["@ShipperID"].SourceColumn = "ShipperID";

                //set up the connection
                shipperDataAdapter.DeleteCommand.Connection = shipperDataAdapter.InsertCommand.Connection;


                //GO

                shipperDataAdapter.InsertCommand.Connection.Open();
                rowCount = shipperDataAdapter.Update(internalDataSet, "Shippers");
                return rowCount;


            }
            catch (SqlException sqlEx)
            {
                throw new ApplicationException(sqlErrorMessage);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                shipperDataAdapter.InsertCommand.Connection.Close();
            }
        }
    }
}
