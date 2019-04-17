using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonSubmit.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //This  method uses datatables and dataAdapter
            try
            {
                // set up the 3 SQL strings we will need, plus the connection string
                string strRegion = "SELECT RegionID, RegionName FROM Region";
                string strBirder = "SELECT BirderID, (FirstName + ' ' + Lastname) AS FullName FROM Birder";
                string strBird = "SELECT BirdID, Name FROM Bird";
                              
                SqlDataAdapter dataAdapter = new SqlDataAdapter(); // instantiate, but prop's not set
                dataAdapter.SelectCommand = new SqlCommand(); // create the command prop, but value not set

                string connectionString = @"Server=localhost\sqlexpress; Database= Birds; Integrated Security=True";
                dataAdapter.SelectCommand.Connection = new SqlConnection(connectionString);
                DataSet birdsDataSet;
               
                dataAdapter.SelectCommand.CommandText = strRegion; // set the cmd string

                birdsDataSet = new DataSet("BirdsDataSet");
                dataAdapter.Fill(birdsDataSet, "Region");


                //now we wish to fill another table, so we change the command text
                dataAdapter.SelectCommand.CommandText = strBirder;
                //now we contact the database again, and add another table to the dataset
                dataAdapter.Fill(birdsDataSet, "Birder");

                //now we wish to fill another table, so we change the command text
                dataAdapter.SelectCommand.CommandText = strBird;
                //now we contact the database again, and add a 3rd table to the dataset
                dataAdapter.Fill(birdsDataSet, "Bird");
               
                // finally bind the data to the grids, all 3 tables are in the birdsDataSet
                dataGridViewRegions.DataSource = birdsDataSet.Tables["Region"];
                dataGridViewBirder.DataSource = birdsDataSet.Tables["Birder"];
                dataGridViewBird.DataSource = birdsDataSet.Tables["Bird"];
                //dataGridViewRegions.DataSource = reader;  <<<<<<<  this is how we did this with a reader object
                dbErrorLabel.Text = "Data retrieved successfully";

            }
            catch (Exception ex)
            {
                dbErrorLabel.Text = "Error loading the from Birds DB";
            }
            finally
            {
               
            }
            buttonSubmit.Enabled = true;
            
            
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // this code uses the simpler SqlCommand to do an insert since we haven't
            // covered doing inserts with dataAdapter yet.

            string varRegionID = (string)dataGridViewRegions.CurrentCell.Value;
            Int32 varBirderID = (int)dataGridViewBirder.CurrentCell.Value;
            string varBirdID = (string)dataGridViewBird.CurrentCell.Value;
            DateTime CountDate = dateTimePicker1.Value;
            Int32 Counted = Convert.ToInt32(textBoxBirdCount.Text);

            SqlCommand updateBirds;

            string connectionString = @"Server=localhost\SQLEXPRESS; Database= Birds; Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            updateBirds = new SqlCommand("INSERT INTO BirdCount VALUES ('" + varRegionID + "', '" + varBirderID + "', '" + varBirdID + "', '" + CountDate + "', '" + Counted + "') ", connection);

            try
            {
                connection.Open();
                updateBirds.ExecuteNonQuery();
                dbErrorLabel.Text = "One Event added";
            }
            catch
            {
                dbErrorLabel.Text = "Error updating Birds DB";
            }
            finally
            {
                connection.Close();
                dataGridViewRegions.ClearSelection();
                dataGridViewBirder.ClearSelection();
                dataGridViewBird.ClearSelection();
                textBoxBirdCount.Text = "";

            }

        }
    }
}
