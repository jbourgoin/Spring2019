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

        ShippersDataSet nwShippersDataSet;  // note, not a plain DataSet, this one is "typed"
        
        public Demo1Form()
        {
            InitializeComponent();
            nwShippersDataSet = new ShippersDataSet();
        }

        

        private void readButton_Click(object sender, EventArgs e)
        {
            try    //Read data from XML file
            {
                nwShippersDataSet.Shippers.Clear(); // because we are reading from 2 sources, clear the table before each read

                // load the dataset from XML using a nice supplied method
                nwShippersDataSet.ReadXml(currentDocPath);
                // Shippers table is now a valid collection in the dataset's table collection
                dataGridView1.DataSource = nwShippersDataSet.Shippers;
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
            foreach (ShippersDataSet.ShippersRow thisShipper in nwShippersDataSet.Shippers)
            {
                thisShipper.Phone = thisShipper.Phone.Replace("503", "504");
                
            }
        }

        private void readDBBButton_Click(object sender, EventArgs e)
        {
            // read data from database
            //nwShippersDataSet.Shippers.Clear(); // because we are reading from 2 sources, clear the table before each read
                try
                {
                    nwShippersDataSet = NorthwindData.GetShipperInfo();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }    
                dataGridView2.DataSource = nwShippersDataSet.Shippers;
                dataGridView2.AutoResizeColumns();
                dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.BlanchedAlmond;    

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Add a new row to a typed data set (it sets the index to a -1, I guess to indicate its not yet a valid number
           nwShippersDataSet.Shippers.AddShippersRow(companyNameTextBox.Text, phoneTextBox.Text);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Use data access library class to save data to database
            NorthwindData.SaveShipperInfo(nwShippersDataSet);
        }

        private void Demo1Form_Load(object sender, EventArgs e)
        {

        }
    }
}