using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataAccessLibrary;

namespace ConcurrencyIssuesDemo
{
    public partial class ShippersForm : Form
    {
        DataSet shipperDataSet;
       

        public ShippersForm()
        {
            InitializeComponent();
            
        }

        private void ShippersForm_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshDG();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void RefreshDG()
        {
            shipperDataSet = NorthwindData.GetShipperInfo();
            shipperDataGridView.DataSource = shipperDataSet;
            shipperDataGridView.DataMember = "Shippers";
        }

        public void SaveData(bool checkConcurrency)
        {
            try
            {
                NorthwindData.SaveShipperInfo(shipperDataSet,checkConcurrency );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveData(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void saveCCButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveData(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshDG();
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int pointer = this.BindingContext[shipperDataSet, "Shippers"].Position;
                shipperDataSet.Tables["Shippers"].Rows[pointer].Delete();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
    }
}