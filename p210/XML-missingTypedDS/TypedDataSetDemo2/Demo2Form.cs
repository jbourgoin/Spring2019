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
    public partial class Demo2Form : Form
    {
        private ProductsDataSet nwProductsDataSet;
        // this will write a new file in your Documents folder
        private string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\NorthwindProducts.xml";


        public Demo2Form()
        {
            InitializeComponent();
        }

        private void loadDBButton_Click(object sender, EventArgs e)
        {
            decimal grandTotal;

            nwProductsDataSet = NorthwindData.GetProducts();
            dataGridView1.DataSource = nwProductsDataSet.Products;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.BlanchedAlmond;

            grandTotal = 0;
            foreach (ProductsDataSet.ProductsRow thisRow in nwProductsDataSet.Products)
            {
                grandTotal = grandTotal + thisRow.UnitPrice * thisRow.UnitsInStock;
            }
            valueLabel.Text = grandTotal.ToString("c");
        }



        private void saveXMLButton_Click(object sender, EventArgs e)
        {
            nwProductsDataSet.WriteXml(path);

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nwProductsDataSet.Products.Clear();
            valueLabel.Text = "";

        }

        private void loadXMLButton_Click(object sender, EventArgs e)
        {
            decimal grandTotal;

            nwProductsDataSet.ReadXml(path);
          
            grandTotal = 0;
            foreach (ProductsDataSet.ProductsRow thisRow in nwProductsDataSet.Products)
            {
                grandTotal = grandTotal + thisRow.UnitPrice * thisRow.UnitsInStock;
            }

            valueLabel.Text = grandTotal.ToString("c");
        }

        private void Demo2Form_Load(object sender, EventArgs e)
        {

        }
    }
}