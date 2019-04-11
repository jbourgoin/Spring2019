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
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();
            try
            {
                //set the cursor to the hour glass
                this.Cursor = Cursors.WaitCursor;

                customerComboBox.DataSource = NorthwindDataAccess.GetCustomers();
                customerComboBox.DisplayMember = "CompanyName";
                customerComboBox.ValueMember = "CustomerID";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                //reset cursor
                this.Cursor = Cursors.Default;
            }
        }

        private void customerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(customerComboBox.SelectedValue.ToString());
        }

        private void DemoForm_Load(object sender, EventArgs e)
        {

        }
    }

}
