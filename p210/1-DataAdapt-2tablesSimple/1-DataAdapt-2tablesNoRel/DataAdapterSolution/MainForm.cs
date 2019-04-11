using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAdapterSolution
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            new DemoForm().Show();
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            new DataSetDisplayForm().Show();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
