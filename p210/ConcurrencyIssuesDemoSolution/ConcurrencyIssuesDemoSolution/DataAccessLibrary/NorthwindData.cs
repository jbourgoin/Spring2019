using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLibrary
{
    public static class NorthwindData
    {
        private const string connectString = @"Data Source=A254J-T006006;Initial Catalog = northwind;Integrated Security=SSPI";
        private const string sqlErrorMessage =
           "Database operation failed.  Please contact your System Administrator.";


        /// <summary>
        /// Retrieves data from the Shippers table
        /// </summary>
        /// <returns>a DataSet with a Shippers table</returns>
        public static DataSet GetShipperInfo()
        {

            SqlDataAdapter shipperDataAdapter;   // takes rows returned from database and puts them into dataset
            DataSet internalDataSet;     // repository to hold data from Bellpeek database

            //Instantiate the data adapter
            shipperDataAdapter = new SqlDataAdapter();

            //Instantiate the dataset
            internalDataSet = new DataSet();

            try
            {

                //Configure the DataAdapter
                shipperDataAdapter.SelectCommand = new SqlCommand();

                shipperDataAdapter.SelectCommand.CommandText = "Select * from Shippers order by ShipperID";
                shipperDataAdapter.SelectCommand.Connection = new SqlConnection();
                shipperDataAdapter.SelectCommand.Connection.ConnectionString = connectString;

                //Retrieve data from the database
                shipperDataAdapter.Fill(internalDataSet, "Shippers");

                return internalDataSet;
            }

            catch (SqlException sqlEx)
            {
                throw new ApplicationException(sqlErrorMessage);
            }

            catch (Exception ex)
            {
                //send the exception to the presentation tier 
                throw ex;
            }

         
        }


        /// <summary>
        /// Save changes to the Shipper DataSet
        /// </summary>
        /// <param name="shippersDataSet"></param>
        /// <param name="checkConncurrency"></param>
        /// <returns>number of rows affected</returns>
        public static int SaveShipperInfo(DataSet shippersDataSet, bool checkConcurrency)
        {
            int rowCount;
            SqlDataAdapter ShipperDataAdapter;

            //SqlParameter holdParm; //parameter object to use in creating parms for insert, update & delete

            //Instantiate the data adapter
            ShipperDataAdapter = new SqlDataAdapter();

            try
            {

                //Configure the DataAdapter

                //INSERT Command  <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< since its a new row, nothing extra neeeded
                ShipperDataAdapter.InsertCommand = new SqlCommand();
                ShipperDataAdapter.InsertCommand.CommandText =
                    "INSERT into Shippers" +
                    "(CompanyName,Phone) " +
                    "VALUES (@CompanyName,@Phone)";

                ShipperDataAdapter.InsertCommand.Connection = new SqlConnection();
                ShipperDataAdapter.InsertCommand.Connection.ConnectionString = connectString;

                //Set up the parameters for the insert command
                ShipperDataAdapter.InsertCommand.Parameters.Add("@CompanyName", System.Data.SqlDbType.NVarChar, 40);
                ShipperDataAdapter.InsertCommand.Parameters["@CompanyName"].SourceColumn = "CompanyName";

                ShipperDataAdapter.InsertCommand.Parameters.Add("@Phone", System.Data.SqlDbType.NVarChar, 40);
                ShipperDataAdapter.InsertCommand.Parameters["@Phone"].SourceColumn = "Phone";


                //UPDATE Command
                ShipperDataAdapter.UpdateCommand = new SqlCommand();

                if (checkConcurrency)  // <<<<<<<<<<<<<<<<<<<<<   This is the case where the button WITH concurrency was clicked
                    // so the extra WHERE terms are added
                {
                    ShipperDataAdapter.UpdateCommand.CommandText =
                    "Update Shippers " +
                    "Set CompanyName = @CompanyName, " +
                    "Phone = @Phone " +
                    "Where ShipperID = @ShipperID and " +
                    " CompanyName = @OrigCompanyName and " +
                    " Phone = @OrigPhone or (Phone is null and @OrigPhone is null)";

                    //Set up the parameters for the Update command

                    ShipperDataAdapter.UpdateCommand.Parameters.Add("@CompanyName", System.Data.SqlDbType.NVarChar, 40);
                    ShipperDataAdapter.UpdateCommand.Parameters["@CompanyName"].SourceColumn = "CompanyName";

                    ShipperDataAdapter.UpdateCommand.Parameters.Add("@Phone", System.Data.SqlDbType.NVarChar, 40);
                    ShipperDataAdapter.UpdateCommand.Parameters["@Phone"].SourceColumn = "Phone";

                    ShipperDataAdapter.UpdateCommand.Parameters.Add("@ShipperID", System.Data.SqlDbType.NVarChar, 40);
                    ShipperDataAdapter.UpdateCommand.Parameters["@ShipperID"].SourceColumn = "ShipperID";

                    ShipperDataAdapter.UpdateCommand.Parameters.Add("@OrigCompanyName", System.Data.SqlDbType.NVarChar, 40);
                    ShipperDataAdapter.UpdateCommand.Parameters["@OrigCompanyName"].SourceColumn = "CompanyName";
                    ShipperDataAdapter.UpdateCommand.Parameters["@OrigCompanyName"].SourceVersion = DataRowVersion.Original; // <<<<<<<<<<<  note the extra param property

                    ShipperDataAdapter.UpdateCommand.Parameters.Add("@OrigPhone", System.Data.SqlDbType.NVarChar, 40);
                    ShipperDataAdapter.UpdateCommand.Parameters["@OrigPhone"].SourceColumn = "Phone";
                    ShipperDataAdapter.UpdateCommand.Parameters["@OrigPhone"].SourceVersion = DataRowVersion.Original; // <<<<<<<<<<<  note the extra param property
                

                }
                else  // This is the case where the button WITHOUT concurrency was clicked
                {
                ShipperDataAdapter.UpdateCommand.CommandText =
                    "Update Shippers " +
                    "Set CompanyName = @CompanyName, " +
                    "Phone = @Phone " + 
                    "Where ShipperID = @ShipperID";

                //Set up the parameters for the Update command

                ShipperDataAdapter.UpdateCommand.Parameters.Add("@CompanyName", System.Data.SqlDbType.NVarChar, 40);
                ShipperDataAdapter.UpdateCommand.Parameters["@CompanyName"].SourceColumn = "CompanyName";

                ShipperDataAdapter.UpdateCommand.Parameters.Add("@Phone", System.Data.SqlDbType.NVarChar, 40);
                ShipperDataAdapter.UpdateCommand.Parameters["@Phone"].SourceColumn = "Phone";

                ShipperDataAdapter.UpdateCommand.Parameters.Add("@ShipperID", System.Data.SqlDbType.NVarChar, 40);
                ShipperDataAdapter.UpdateCommand.Parameters["@ShipperID"].SourceColumn = "ShipperID";
                
                }

                ShipperDataAdapter.UpdateCommand.Connection = ShipperDataAdapter.InsertCommand.Connection;

                               
                //DELETE Command  no concurrency needed here, can't have conflicting values of a deleted row!

                ShipperDataAdapter.DeleteCommand = new SqlCommand();
                ShipperDataAdapter.DeleteCommand.CommandText =
                    "DELETE FROM Shippers WHERE ShipperID = @ShipperID";

                ShipperDataAdapter.DeleteCommand.Connection = ShipperDataAdapter.InsertCommand.Connection;
                ShipperDataAdapter.DeleteCommand.Parameters.Add("@ShipperID", System.Data.SqlDbType.NVarChar, 40);
                ShipperDataAdapter.DeleteCommand.Parameters["@ShipperID"].SourceColumn = "ShipperID";

                ShipperDataAdapter.InsertCommand.Connection.Open();
                ShipperDataAdapter.ContinueUpdateOnError = true;


                rowCount = ShipperDataAdapter.Update(shippersDataSet, "Shippers");

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
                ShipperDataAdapter.InsertCommand.Connection.Close();
            }
        }

        

    }
}
