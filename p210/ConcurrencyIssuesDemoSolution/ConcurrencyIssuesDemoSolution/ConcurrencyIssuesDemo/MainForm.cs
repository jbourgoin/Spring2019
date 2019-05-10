using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConcurrencyIssuesDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShippersForm displayForm;

            displayForm = new ShippersForm();
            displayForm.MdiParent = this;
            displayForm.Show();
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string help = "use the File menu to open two instances of the shipper form, and then Window menu to set the tiles so that you can see both at the same time.";
            MessageBox.Show(help);
        }

        
    }
}