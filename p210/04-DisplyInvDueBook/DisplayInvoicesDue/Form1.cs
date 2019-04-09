using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PayablesData;

namespace DisplayInvoicesDue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Invoice> invoiceList;
            try
            {
                invoiceList = InvoiceDB.GetInvoicesDue();
                if (invoiceList.Count > 0)
                {
                    Invoice tempIinvoice;
                    for (int i = 0; i < invoiceList.Count; i++)
                    {
                        tempIinvoice = invoiceList[i];
                        listviewInvoices.Items.Add(tempIinvoice.InvoiceNumber);
                        listviewInvoices.Items[i].SubItems.Add(tempIinvoice.InvoiceDate.ToShortDateString());
                        listviewInvoices.Items[i].SubItems.Add(tempIinvoice.InvoiceTotal.ToString("c"));
                        listviewInvoices.Items[i].SubItems.Add(tempIinvoice.PaymentTotal.ToString("c"));
                        listviewInvoices.Items[i].SubItems.Add(tempIinvoice.CreditTotal.ToString("c"));
                        listviewInvoices.Items[i].SubItems.Add(tempIinvoice.BalanceDue().ToString("c"));
                        listviewInvoices.Items[i].SubItems.Add(tempIinvoice.DueDate.ToShortDateString());
                    }
                }
                else
                {
                    MessageBox.Show("All invoices are paid in full.",
                        "No Balance Due");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }
    }
}
