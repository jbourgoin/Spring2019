using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BirdDataGatherer;

namespace BirdDataGatherer
{
    public partial class Form1 : Form
    {
        private DataSet birdDataSet;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birdDataSet = BirdGathererDBAccess.GatherBirdDataSet();

            dataGridView1.DataSource = birdDataSet;
            dataGridView1.DataMember = "Bird";

            dataGridView2.DataSource = birdDataSet;
            dataGridView2.DataMember = "Bird.Bird-BirdCount-DataRelation";

        }
    }
}
