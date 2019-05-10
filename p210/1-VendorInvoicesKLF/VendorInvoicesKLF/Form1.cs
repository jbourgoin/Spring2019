using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendorInvoicesKLF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PayablesDataContext payables = new PayablesDataContext();
        
        // added since didn't do in forms
        BindingSource invoiceBindingSource = new BindingSource();
            

        private void Form1_Load(object sender, EventArgs e)
        {
            var vendors = from vendor in payables.Vendors
                          orderby vendor.Name
                          select new { vendor.VendorID, vendor.Name };

           
            // compared to book example, had to add 2 lines, they did with property box
            nameComboBox.DisplayMember = "Name";
            nameComboBox.ValueMember = "VendorID";
            // this order; DisplayMember, ValueMember, DataSource is REQUIRED
            nameComboBox.DataSource = vendors;
        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.GetVendorInvoices();
        }

        private void GetVendorInvoices()
        {
             var result = nameComboBox.SelectedValue;
             int vendorID = Convert.ToInt32(result.ToString());
              

            var selectedVendor =
                (from vendor in payables.Vendors
                 where vendor.VendorID == vendorID 
                 select vendor).Single();  // gets the entire row, now can use for text boxes

            address1TextBox.Text = selectedVendor.Address1;
            address2TextBox.Text = selectedVendor.Address2;
            cityTextBox.Text = selectedVendor.City;
            stateTextBox.Text = selectedVendor.State;
            zipCodeTextBox.Text = selectedVendor.ZipCode;

          // the 3 way relationship  query reults <==> binding object <==> display object
            invoiceBindingSource.DataSource = selectedVendor.Invoices; // Association gets joined rows
            // they did this next line in form views
            dataGridView1.DataSource = invoiceBindingSource;
        }
    }
}
