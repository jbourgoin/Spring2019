using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TypedDataSetDemo1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void demo1Button_Click(object sender, EventArgs e)
        {
            new Demo1Form().Show();
        }

        private void demo2Button_Click(object sender, EventArgs e)
        {
            new Demo2Form().Show();
        }
    }
}
