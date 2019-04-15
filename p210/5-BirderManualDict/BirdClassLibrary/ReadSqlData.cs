using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdClassLibrary
{
    public class ReadSqlData
    {
        string connectionString = @"Server=localhost\SQLEXPRESS; Database= Birds; Integrated Security=True";
        public Dictionary<string, string> ReadNow(string sqlString, string tableName)
        {
            Dictionary<string, string> ourdata = new Dictionary<string,string>();
            ourdata.Clear();  // not really needed, since just defined it
         try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand mySqlCommand = new SqlCommand("SELECT " + sqlString + " FROM " + tableName, connection);
               
                connection.Open();
                SqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {


                    // note, reverse order next; loading the dictionary using the db primary key as the
                    // dictionary's data field, and the db data column as the dictionary key
                    // This is so we can display the db data column, which is what humans want to read,
                    // and then when they select it, we can use it as the dictionary key to look up the db primary key
                    // for example, when uses selects WA, we will use that to look up in the dictionary
                    // the RegionID which is the value we need for inserting into the DB.

                    //ourdata.Add((string)reader["RegionName"], (string)reader["RegionID"]);
                    // can't use names here, since we call 3 times with different column names
                    ourdata.Add( (string)reader[1], (string)( reader[0] ) ); 
                    // dictionary key = db data , dictionary value = db primary key
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                
            }
         return ourdata;
        }

        public Dictionary<string, int> ReadNowInt(string sqlString, string tableName)
        {
            Dictionary<string, int> ourdata = new Dictionary<string, int>();
            ourdata.Clear();  // not really needed, since just defined it
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand mySqlCommand = new SqlCommand("SELECT " + sqlString + " FROM " + tableName, connection);

                connection.Open();
                SqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {


                    // note, reverse order next; loading the dictionary using the db primary key as the
                    // dictionary's data field, and the db data column as the dictionary key
                    // This is so we can display the db data column, which is what humans want to read,
                    // and then when they select it, we can use it as the dictionary key to look up the db primary key
                    // for example, when uses selects WA, we will use that to look up in the dictionary
                    // the RegionID which is the value we need for inserting into the DB.

                    //ourdata.Add((string)reader["RegionName"], (string)reader["RegionID"]);
                    // can't use names here, since we call 3 times with different column names
                    ourdata.Add((string)reader[1], (int)(reader[0]));
                    // dictionary key = db data , dictionary value = db primary key
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {

            }
            return ourdata;
        }

        public string AddRow(string varRegionID, int varBirderID, string varBirdID, DateTime countDate, int counted)
        {
            string returnMssage = "Inserted data successfully.";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand updateBirds = new SqlCommand("INSERT INTO BirdCount VALUES ('" + varRegionID + "', '" + varBirderID + "', '" + varBirdID + "', '" + countDate + "', '" + counted + "') ", connection);
            try
            {
                connection.Open();
                updateBirds.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                returnMssage = "Error updating Birds DB: " + ex.Message.ToString();
            }
            finally
            {
                connection.Close();
            }
            return returnMssage;
        }


    }

}
