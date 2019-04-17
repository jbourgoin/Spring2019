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
    public partial class RelatedTablesForm : Form
    {
        private DataSet customerDataSet;
        DataView OrderDetailsDV = new DataView(); // this is a filterable view which we will
        // use for the 3rd datagridview.  It creates a logical table here, in the client,
        // reading data out of the loaded DataSet

        public RelatedTablesForm()
        {
            InitializeComponent();
        }

        private void RelatedTablesForm_Load(object sender, EventArgs e)
        {
            customerDataSet = NorthwindDataAccess.GetOrders();  // use middle tier data access routine

            // load up thy 1st, OrderID  dataGridView  with table data
            dataGridViewOrderID.DataSource = customerDataSet;
            dataGridViewOrderID.DataMember = "Customers";
            
            // load up the 2nd, Orderlines dataGridView  BUT this one is showing our UsefulRelation
            dataGridVieworderLines.DataSource = customerDataSet;
            dataGridVieworderLines.DataMember = "Customers.UsefulRelation";

            // the magic of the dataSet and the dataGridView objects will use the UsefulRelation to 
            // keep the data viewed in sync

            // now for the 3rd datagrid view - no magic here, we have to do it ourself.
            // the next line calls a common method to make the first page draw correct
            // after that, the dataGridViewOrderID_CellContentClick and orderLinesdataGridView_CellContentClick
            // methods and all 4 buttons keep the 3rd view in sync with the first, also, 
            // orderLinesdataGridView_CellContentClick handles when the user clicks thru the 2nd grid
            // may have some issue where sometimes I have to click a few times on a cell, esp the top row or 2??

            Update3rdGrid();
        }

        // if used clicks in the first col of the top datagridview, force the 3rd table to be in syn
        private void dataGridViewOrderID_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Update3rdGrid();
        }

        // if used clicks in the first col of the middle datagridview, force the 3rd table to be in syn
        private void orderLinesdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Update3rdGrid();
        }

        private void Update3rdGrid()
        {
            // now use this new filterable DataView object
            // get the value of the current clicked cell in the middle grid
            // code does not work if they click in the wrong column
            int curOrderID = (int)dataGridVieworderLines.CurrentCell.Value;
            // load our client side "view" from the dataset
            OrderDetailsDV.Table = customerDataSet.Tables["OrderDetails"];
            // filter the view using the selected cell = orderID
            OrderDetailsDV.RowFilter = "OrderID = " + curOrderID;
            //bind the updated view to the 3rd grid
            dataGridViewProductDetail.DataSource = OrderDetailsDV;
        }
      
        private void moveNextButton_Click(object sender, EventArgs e)
        {
            //make use of the form binding context 
            this.BindingContext[customerDataSet, "Customers"].Position += 1;
            Update3rdGrid();
        }

        private void moveFirstButton_Click(object sender, EventArgs e)
        {
            //make use of the form binding context 
            this.BindingContext[customerDataSet, "Customers"].Position = 0;
            Update3rdGrid();
        }
        private void movePreviousButton_Click(object sender, EventArgs e)
        {
            //make use of the form binding context 
            this.BindingContext[customerDataSet, "Customers"].Position -= 1;
            Update3rdGrid();
        }

        private void moveLastButton_Click(object sender, EventArgs e)
        {
            //make use of the form binding context 
            this.BindingContext[customerDataSet, "Customers"].Position = this.BindingContext[customerDataSet, "Customers"].Count - 1;
            Update3rdGrid();
        }

       

       
            
    }
}
