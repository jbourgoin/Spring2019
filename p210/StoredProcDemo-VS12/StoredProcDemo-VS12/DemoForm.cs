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

namespace StoredProcDemo_VS12
{
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();
        }

        // Inserts a row into the Products table for a new product
        //by calling a data access class method
        private void saveButton_Click(object sender, EventArgs e)
        {

            int productID;

            // note I have skipped data validation as this is just a demo
            // my code assumes that the values you enter are valid
            //obviously this would not be done in a real application

            try
            {
                // call the data access method
                productID = NorthwindData.AddProduct(
                    nameTextBox.Text,
                    int.Parse(supplierIDTextBox.Text),
                    int.Parse(categoryIDTextBox.Text),
                    int.Parse(quantityPerUnitTextBox.Text),
                    int.Parse(unitPriceTextBox.Text),
                    int.Parse(unitsInStockTextBox.Text),
                    int.Parse(unitsOnOrderTextBox.Text),
                    int.Parse(reorderLevelTextBox.Text),
                    bool.Parse(discontinuedTextBox.Text),
                    supplierIDTextBox.Text);

                MessageBox.Show("Product " + productID.ToString() + "  " + nameTextBox.Text + " has been added to the database.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }








    }
}