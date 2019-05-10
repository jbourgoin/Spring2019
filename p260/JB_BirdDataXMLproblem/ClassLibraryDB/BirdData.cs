using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDB
{
    public class BirdData
    {
        private const string connectString = @"Data Source=localhost\sqlexpress;Initial Catalog = Birds;Integrated Security=SSPI";
        private const string sqlErrorMessage = "Database operation failed.  Please contact your System Administrator.";

        public static DataSet GetBirdInfo()
        {
            try
            {
                SqlDataAdapter birdDataAdapter = new SqlDataAdapter();
                DataSet birdsDataSet = new DataSet();
                birdDataAdapter.SelectCommand = new SqlCommand();
                birdDataAdapter.SelectCommand.CommandText = "Select * from BirdCount order by CountID";
                birdDataAdapter.SelectCommand.Connection = new SqlConnection();
                birdDataAdapter.SelectCommand.Connection.ConnectionString = connectString;
                birdDataAdapter.Fill(birdsDataSet, "BirdCount");

               
                return birdsDataSet;
            }
            catch (SqlException sqlEx)
            {
                throw new ApplicationException(sqlErrorMessage);
            }
        }


        // This code enables updates but does not support inserts, you need to add that code
        public static int SaveBirdInfo(DataSet birdDataSet)
        {
            SqlDataAdapter birdDataAdapter = new SqlDataAdapter();
            birdDataAdapter.UpdateCommand = new SqlCommand();

            birdDataAdapter.UpdateCommand.Connection = new SqlConnection();
            birdDataAdapter.UpdateCommand.Connection.ConnectionString = connectString;
            birdDataAdapter.UpdateCommand.CommandText =
                " UPDATE BirdCount SET RegionID = @RegionID, BirderID =@BirderID, BirdID= @BirdID, " +
                " CountDate=@CountDate, Counted=@Counted WHERE CountID = @CountID";

            //Set up the parameters for the update command  

            birdDataAdapter.UpdateCommand.Parameters.Add("@CountID", System.Data.SqlDbType.Int);
            birdDataAdapter.UpdateCommand.Parameters["@CountID"].SourceColumn = "CountID";

            birdDataAdapter.UpdateCommand.Parameters.Add("@RegionID", System.Data.SqlDbType.NVarChar, 10);
            birdDataAdapter.UpdateCommand.Parameters["@RegionID"].SourceColumn = "RegionID";

            birdDataAdapter.UpdateCommand.Parameters.Add("@BirderID", System.Data.SqlDbType.Int);
            birdDataAdapter.UpdateCommand.Parameters["@BirderID"].SourceColumn = "BirderID";

            birdDataAdapter.UpdateCommand.Parameters.Add("@BirdID", System.Data.SqlDbType.NVarChar, 10);
            birdDataAdapter.UpdateCommand.Parameters["@BirdID"].SourceColumn = "BirdID";

            birdDataAdapter.UpdateCommand.Parameters.Add("@CountDate", System.Data.SqlDbType.Date);
            birdDataAdapter.UpdateCommand.Parameters["@CountDate"].SourceColumn = "CountDate";

            birdDataAdapter.UpdateCommand.Parameters.Add("@Counted", System.Data.SqlDbType.Int);
            birdDataAdapter.UpdateCommand.Parameters["@Counted"].SourceColumn = "Counted";

            // need to define the insert command objects and then
            // set up the parameters for the insert command  
            birdDataAdapter.InsertCommand = new SqlCommand();
            birdDataAdapter.InsertCommand.Connection = new SqlConnection();
            birdDataAdapter.InsertCommand.Connection.ConnectionString = birdDataAdapter.UpdateCommand.Connection.ConnectionString;
            birdDataAdapter.InsertCommand.CommandText = "INSERT INTO BirdCount" +
                " (RegionID,BirderID,BirdID,CountDate,Counted) " +
                " VALUES (@RegionID,@BirderID,@BirdID,@CountDate,@Counted)";

            birdDataAdapter.InsertCommand.Parameters.Add("@CountID", System.Data.SqlDbType.Int);
            birdDataAdapter.InsertCommand.Parameters["@CountID"].SourceColumn = "CountID";

            birdDataAdapter.InsertCommand.Parameters.Add("@RegionID", System.Data.SqlDbType.NVarChar, 10);
            birdDataAdapter.InsertCommand.Parameters["@RegionID"].SourceColumn = "RegionID";

            birdDataAdapter.InsertCommand.Parameters.Add("@BirderID", System.Data.SqlDbType.Int);
            birdDataAdapter.InsertCommand.Parameters["@BirderID"].SourceColumn = "BirderID";

            birdDataAdapter.InsertCommand.Parameters.Add("@BirdID", System.Data.SqlDbType.NVarChar, 10);
            birdDataAdapter.InsertCommand.Parameters["@BirdID"].SourceColumn = "BirdID";

            birdDataAdapter.InsertCommand.Parameters.Add("@CountDate", System.Data.SqlDbType.Date);
            birdDataAdapter.InsertCommand.Parameters["@CountDate"].SourceColumn = "CountDate";

            birdDataAdapter.InsertCommand.Parameters.Add("@Counted", System.Data.SqlDbType.Int);
            birdDataAdapter.InsertCommand.Parameters["@Counted"].SourceColumn = "Counted";

            birdDataAdapter.UpdateCommand.Connection.Open();

            //Use the DataAdapter to update the database
            int rowCount = birdDataAdapter.Update(birdDataSet, "BirdCount");

            return rowCount;
        }
    }
}
