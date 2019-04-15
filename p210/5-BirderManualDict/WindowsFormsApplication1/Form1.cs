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
using BirdClassLibrary;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        // define 3 dictionaries to get data back from 1 generic SQL method
        Dictionary<string, string> regionsDic;// = new Dictionary<string, int>(); // key , value
        Dictionary<string, int> birderDic; //= new Dictionary<string, int>(); // key , value
        Dictionary<string, string> birdDic; //= new Dictionary<string, int>(); // key , value

        public Form1()
        {
            InitializeComponent();
            buttonSubmit.Enabled = false;  // don't let use submit until data is entered
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ReadSqlData myReader = new ReadSqlData();  // instantiate my db reader object
                // then use it 3 times to load up my 3 dictionaries
                // The ReadNow method takes in 1 string for the Field names, and a 2nd sting for the table to be read
                regionsDic = myReader.ReadNow("RegionID, RegionName", "Region");
                birdDic = myReader.ReadNow("BirdID, Name", "Bird");
                // different dict format
                birderDic = myReader.ReadNowInt("BirderID, (FirstName + ' ' + Lastname) AS FullName", "Birder");

                // now dump the "dict key" = human name, into the 3 listBoxes
                foreach (KeyValuePair<string, string> item in regionsDic)
                {
                    listBoxRegion.Items.Add(item.Key); // The dict key is the human readable form
                    // item.Value is the coded value, such as the primary key in the DB
                }

                foreach (KeyValuePair<string, int> item in birderDic)
                {
                    listBoxBirder.Items.Add(item.Key);
                }

                foreach (KeyValuePair<string, string> item in birdDic)
                {
                    listBoxBird.Items.Add(item.Key); 
                }
                buttonSubmit.Enabled = true;  // if we made it this far, we can enable the button

            }
            catch (Exception ex)
            {
                // write out my own error message, plus the message passed back from our ReadSqlData class
                dbErrorLabel.Text = "Error reading Birds DB: " + (ex.Message.ToString());
            }
            finally
            {
               
            }
         
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            ReadSqlData myReader = new ReadSqlData();  // instantiate my db reader object

            // make sure user has selected in each list box and supplied a count
            if (listBoxRegion.SelectedIndex >= 0 && listBoxBirder.SelectedIndex >= 0 && listBoxBird.SelectedIndex >= 0 && textBoxBirdCount.Text != "")
            {
                 // grab the 5 values from the form, and form a SQL insert command
                // the human form is used as the key to look up the db primary key value in our dictionary
                string varRegionID = regionsDic[listBoxRegion.Text];  
                Int32 varBirderID = Convert.ToInt32(birderDic[listBoxBirder.Text]);
                string varBirdID = birdDic[listBoxBird.Text];
                DateTime CountDate = dateTimePicker1.Value;
                Int32 Counted = Convert.ToInt32(textBoxBirdCount.Text);

                dbErrorLabel.Text = myReader.AddRow(varRegionID, varBirderID, varBirdID, CountDate, Counted);
            }
            else
            {
                dbErrorLabel.Text = "Please make a selection for each item."; // re-using same label for this error
            }

            // clear all the selections on the form
            listBoxRegion.ClearSelected();
            listBoxBirder.ClearSelected();
            listBoxBird.ClearSelected();
            textBoxBirdCount.Text = "";

        }
    }
}
