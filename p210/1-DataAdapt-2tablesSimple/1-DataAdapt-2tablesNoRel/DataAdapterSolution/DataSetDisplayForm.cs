using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLib;

namespace DataAdapterSolution
{
    public partial class DataSetDisplayForm : Form
    {
        public DataSetDisplayForm()
        {
            InitializeComponent();
        }

        private void DataSetDisplayForm_Load(object sender, EventArgs e)
        {
            DataSet ordersDataSet;

            ordersDataSet = NorthwindDataAccess.GetOrders();

            dataGridView1.DataSource = ordersDataSet.Tables["OrdersSubset"];  // indexer, could have used [0]

            dataGridView2.DataSource = ordersDataSet.Tables["OrderDetailsSubset"];  // [1]

            //click on dataGridView little arrow, to disable editing, etc. and point out NOT to use the datasource
        }

       
    }
}
