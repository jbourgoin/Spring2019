using ClassLibraryDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdDataAdapterHW
{
    public partial class Form1 : Form
    {
        DataSet birdsDataSet = new DataSet();
        private string XMLFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\RemoteBirdClub.xml";
        XMLdataSet birdsXMLDataSet;

        public Form1()
        {
            InitializeComponent();
            birdsXMLDataSet = new XMLdataSet();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                BirdData.SaveBirdInfo(birdsDataSet);
                labelDataSaved.Text = "Data Saved!";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refresh();  // a call to the refresh method.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();  // a call to the refresh method.
        }

        private void refresh()
        {
            try
            {
                birdsDataSet = BirdData.GetBirdInfo();
                DataGridViewBirds.DataSource = birdsDataSet;
                DataGridViewBirds.DataMember = "BirdCount";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonReadXML_Click(object sender, EventArgs e)
        {
            try
            {
                // clear data set from hw example
                birdsXMLDataSet.BirdCount.Clear();
                // use inherited class method to read xml from file path variable
                birdsXMLDataSet.ReadXml(XMLFilePath);
                dataGridViewXML.DataSource = birdsXMLDataSet.BirdCount;
                dataGridViewXML.AutoResizeColumns();
                dataGridViewXML.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkSeaGreen;
            }
            catch (Exception ex)
            {
                // words from the computer
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAddSQL_Click(object sender, EventArgs e)
        {

            // Build a foreach loop that uses each row (what datatype is the row ? Well, it’s a row in the XMLdataSet so it’s a BirdCountRow) 
            // in the myXMLDataSet.BirdCount  (the name of the table there is BirdCount, so you can use dot notation)
            // I suggest you rename your "item" iterator to be oneXMLrow

            // In this foreach loop, for each oneXMLrow  (row of data in the XML set), create a NEW data row (make up a name, like newDataRow) of type DataRow
            foreach (XMLdataSet.BirdCountRow oneXMLBirdRow in birdsXMLDataSet.BirdCount)
            {
                // Now in your foreach loop, you have a row from the XML dataset (oneXMLrow) and an EMPTY new row (newDataRow) that matches the type in the sqlBirdsDataSet
                // Now copy 5 values over from one to the other  (Do not copy the CountID field, leave it empty in the newDataRow)
                //newBirdDataRow["CountID"] = oneXMLBirdRow.CountID;
                //etc for each required field
                //Now that that new SQL row object is populated with data, add that new row to the sqlBirdsDataSet
                DataRow newBirdDataRow = birdsDataSet.Tables["BirdCount"].NewRow();
                newBirdDataRow["RegionID"] = oneXMLBirdRow.RegionID;
                newBirdDataRow["BirderID"] = oneXMLBirdRow.BirderID;
                newBirdDataRow["BirdID"] = oneXMLBirdRow.BirdID;
                newBirdDataRow["CountDate"] = oneXMLBirdRow.CountDate;
                newBirdDataRow["Counted"] = oneXMLBirdRow.Counted;
                birdsDataSet.Tables["BirdCount"].Rows.Add(newBirdDataRow);
            }
        }

        // Note this will load the sqlBirdsDataSet, which will change what the lower datagridview shows, 
        // but it is not in the SQL db until you click save and execute the save method.

        // But before you do that, you need to update the DataAdapter to enable it to do inserts.

        // Note, make sure your Region table, Bird table, and BirdID tables all have valid entries to 
        // match the values used in my XML file.  If your tables don't have those
        // values, use SSMS and add those missing values to your tables..


    }
}
