using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataAccessLibrary;

namespace TypedDataSetDemo1
{

    public partial class Demo1Form : Form
    {
        static string currentDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\NorthWindShippersDataSet.xml";
        // define these 2 variable here so we can get at them from all methods
        ShippersDataSet nwXMLShippersDataSet;  // note, not a plain DataSet, this one is "typed"
        DataSet nwShippersDataSet;  // this one, for the SQL data, is a plain DataSet
        public Demo1Form()
        {
            InitializeComponent();
            nwXMLShippersDataSet = new ShippersDataSet(); // call constructor to build our object
        }

        
        // this event method will read an XML file from local disk
        private void readButton_Click(object sender, EventArgs e)
        {
            try    //Read data from XML file
            {
                nwXMLShippersDataSet.Shippers.Clear(); // clear the table before each read

                // load the dataset from XML using a nice supplied method
                nwXMLShippersDataSet.ReadXml(currentDocPath);

                // Shippers table is now a valid collection in the dataset's table collection
                // the name for the table, Shippers, comes from the XML file

                // display it as we always do
                dataGridView1.DataSource = nwXMLShippersDataSet.Shippers;
                dataGridView1.AutoResizeColumns();
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.BlanchedAlmond;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            //change the phone number from 503 to 504 
            // now we can reference columns by names that autocomplete
            foreach (ShippersDataSet.ShippersRow thisShipper in nwXMLShippersDataSet.Shippers)
            {
                thisShipper.Phone = thisShipper.Phone.Replace("503", "504");
                
            }
        }

        private void readDBBButton_Click(object sender, EventArgs e)
        {
            // read data from SQL database
            nwShippersDataSet.Tables["Shippers"].Clear(); // clear the table before each read
            try
            {
                nwShippersDataSet = NorthwindData.GetShipperInfo();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            dataGridView2.DataSource = nwShippersDataSet.Tables["Shippers"];
            dataGridView2.AutoResizeColumns();
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.BlanchedAlmond;

        }

        // this method uses the 2 text boxes to create a new shipper entry in the in-memory dataTable
        private void addButton_Click(object sender, EventArgs e)
        {
            // Add a new row to a non-typed data set (set the index to a -1, to indicate its not yet a valid SQL index
            // this Rows.Add method has several constuctors, this one takes in, in order, a value for each column
            nwShippersDataSet.Tables["Shippers"].Rows.Add(-1,companyNameTextBox.Text, phoneTextBox.Text);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Use data access library class to save data to database
            NorthwindData.SaveShipperInfo(nwShippersDataSet);  // sending over a normal DataSet with 
            // the updated regular DataTable within
        }

        private void Demo1Form_Load(object sender, EventArgs e)
        {
            // must have clicked on the empty form, just leaving this for now.
        }

        // this method reads information from each row in the uppder data table, 
        // and copies the values into a new data table row that matches the dimensions
        // of the data table we used to read SQL into
        private void buttonMoveData_Click(object sender, EventArgs e)
        {
            foreach (ShippersDataSet.ShippersRow oneXMLrow in nwXMLShippersDataSet.Shippers)
            {
                DataRow newDataRow = nwShippersDataSet.Tables["Shippers"].NewRow(); // match datatable for SQL
                newDataRow["CompanyName"] = oneXMLrow.CompanyName;
                newDataRow["Phone"] = oneXMLrow.Phone;
                nwShippersDataSet.Tables["Shippers"].Rows.Add(newDataRow);  // insert new row
            }
        }
    }
}