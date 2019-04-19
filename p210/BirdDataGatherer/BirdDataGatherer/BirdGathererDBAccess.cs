using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdDataGatherer
{
    public static class BirdGathererDBAccess
    {
        //db con string
        private const string connString = @"Server = localhost\sqlexpress;Database=Birds;Integrated Security=true";

        // Generic error message for database issues
        private const string sqlErrorMessage = "Database operation failed.  Please contact your System Administrator";

        public static DataSet GatherBirdDataSet()
        {
            // sql adapter
            SqlDataAdapter birdAdapter = new SqlDataAdapter();

            // initiating sql command in the sqlAdapter obj
            birdAdapter.SelectCommand = new SqlCommand();
            
            // initiating sql connection string
            birdAdapter.SelectCommand.Connection = new SqlConnection();

            // Birds DataSet
            DataSet birdDataSet;

            // Birds DataRelation
            DataRelation birdsDataRelation;

            try
            {
                // set bird adapter connection string
                birdAdapter.SelectCommand.Connection.ConnectionString = connString;

                // set bird query string
                birdAdapter.SelectCommand.CommandText = " select * from Bird order by BirdID ";

                // name the dataSet to be included in the sqlAdapter
                birdDataSet = new DataSet("Birds DataSet");

                // gather the birds
                // sending the data set and desired table as parameters
                birdAdapter.Fill(birdDataSet, "Bird");

                // BirdCount Command Text
                birdAdapter.SelectCommand.CommandText = " Select * from BirdCount order by BirdID ";

                // new birdcount query results name
                birdAdapter.Fill(birdDataSet, "BirdCount");

                // relational birda-base two tables Bird,BirdCount Pkey = BirdID
                birdsDataRelation = new DataRelation("Bird-BirdCount-DataRelation",
                    birdDataSet.Tables["Bird"].Columns["BirdID"],
                    birdDataSet.Tables["BirdCount"].Columns["BirdID"], true);

                // CODE ABOVE IS RETURNING NULL   ^^^^^  Solved: birdAdapter.Fill(DataSet, tableName to run the cmdText against)


                // add the Data Relation to the DataSet
                birdDataSet.Relations.Add(birdsDataRelation);

                // return the data set after retrieving above data
                return birdDataSet;

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
            //catch (Exception ex)
            //{

            //    throw ex;
            //}


        }
    }
}
