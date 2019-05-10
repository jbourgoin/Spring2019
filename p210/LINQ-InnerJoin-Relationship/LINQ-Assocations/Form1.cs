using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_Assocations
{
    public partial class Form1 : Form
    {

        //Get dataContext
        DataClassesBirdsDataContext myBirdData = new DataClassesBirdsDataContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Style dataGridView
            dataGridViewBirds.AlternatingRowsDefaultCellStyle.BackColor = Color.PeachPuff;
            dataGridViewBirds.RowsDefaultCellStyle.BackColor = Color.PowderBlue;
            dataGridViewBirds.AutoResizeColumns();

            //Style form
            this.BackColor = Color.AntiqueWhite;
        }

        private void refreshDataGridView()
        {

            //Define query 3  simple query to one table, but using select new { just the subet of properties (rows) that I want }
            var birds = from myBirds in myBirdData.BirdCounts
                        where myBirds.Counted > 10
                        orderby myBirds.Counted ascending
                        select
                        new
                        {
                            myBirds.CountID,
                            myBirds.Counted,
                            myBirds.BirdID,
                        };


            //================================================================
            // now to a classic SQL Inner Join to get data from the Bird table that matches each object (row) in BirdCounts
            //var birds = from countItem in myBirdData.BirdCounts
            //            join birdItem in myBirdData.Birds
            //            on countItem.BirdID
            //            equals birdItem.BirdID
            //            orderby countItem.CountID ascending
            //            select new
            //            {
            //                countItem.CountID,
            //                countItem.Counted,
            //                countItem.BirdID,
            //                birdItem.Name,
            //                birdItem.Description
            //            };

            //================================================================
            // now do effectively that same Inner Join, but instead, make use of the Association link in BirdCounts
            //var birds = from countItem in myBirdData.BirdCounts
            //            orderby countItem.CountID ascending
            //            select new
            //            {
            //                countItem.CountID,
            //                countItem.Counted,
            //                countItem.BirdID,
            //                countItem.Bird.Name,
            //                countItem.Bird.Description
            //            };


            //************************************************************************************************
            //***********************************************************************************************


            //Bind to gridView
            dataGridViewBirds.DataSource = birds;
        }


        private void buttonGetBirds_Click(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void buttonUpdateCount_Click(object sender, EventArgs e)
        {
            //Variable to hold textBox input
            int counted;

            //
            if (Int32.TryParse(textBoxNewCount.Text, out counted))
            {
                //Get selected row
                var selected = dataGridViewBirds.CurrentRow;
                int countID = (int)selected.Cells["CountID"].Value;

                //Get row from dataContext
                var selectedBirdCount =
                    (from bird in myBirdData.BirdCounts
                     where bird.CountID == countID
                     select bird).Single();

                //Edit dataContext
                selectedBirdCount.Counted = counted;

                //Submit Changes
                myBirdData.SubmitChanges();

                //Refresh
                refreshDataGridView();

            }
            else
            {
                MessageBox.Show("Please enter an integer number.");
            }
            //Clear textBox in either case
            textBoxNewCount.Text = "";

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Retrieve selected row and id
            var selectedRow = dataGridViewBirds.CurrentRow;
            int selectedID = (int)selectedRow.Cells["CountID"].Value;

            //Retrieve row to delete from dataContext
            var rowToDelete =
                (from bird in myBirdData.BirdCounts
                 where bird.CountID == selectedID
                 select bird).Single();

            //Mark for deletion
            myBirdData.BirdCounts.DeleteOnSubmit(rowToDelete);

            //Try to submit changes
            try
            {
                myBirdData.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting item: " + ex.Message);
            }

            //refresh gridView
            refreshDataGridView();
        }
    }
}
