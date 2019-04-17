﻿namespace DataAdapterSolution
{
    partial class RelatedTablesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.moveLastButton = new System.Windows.Forms.Button();
            this.movePreviousButton = new System.Windows.Forms.Button();
            this.moveNextButton = new System.Windows.Forms.Button();
            this.moveFirstButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridVieworderLines = new System.Windows.Forms.DataGridView();
            this.dataGridViewOrderID = new System.Windows.Forms.DataGridView();
            this.dataGridViewProductDetail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieworderLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // moveLastButton
            // 
            this.moveLastButton.Location = new System.Drawing.Point(560, 154);
            this.moveLastButton.Margin = new System.Windows.Forms.Padding(4);
            this.moveLastButton.Name = "moveLastButton";
            this.moveLastButton.Size = new System.Drawing.Size(132, 28);
            this.moveLastButton.TabIndex = 19;
            this.moveLastButton.Text = "Move Last";
            this.moveLastButton.UseVisualStyleBackColor = true;
            this.moveLastButton.Click += new System.EventHandler(this.moveLastButton_Click);
            // 
            // movePreviousButton
            // 
            this.movePreviousButton.Location = new System.Drawing.Point(560, 109);
            this.movePreviousButton.Margin = new System.Windows.Forms.Padding(4);
            this.movePreviousButton.Name = "movePreviousButton";
            this.movePreviousButton.Size = new System.Drawing.Size(132, 28);
            this.movePreviousButton.TabIndex = 18;
            this.movePreviousButton.Text = "Move Previous";
            this.movePreviousButton.UseVisualStyleBackColor = true;
            this.movePreviousButton.Click += new System.EventHandler(this.movePreviousButton_Click);
            // 
            // moveNextButton
            // 
            this.moveNextButton.Location = new System.Drawing.Point(560, 64);
            this.moveNextButton.Margin = new System.Windows.Forms.Padding(4);
            this.moveNextButton.Name = "moveNextButton";
            this.moveNextButton.Size = new System.Drawing.Size(132, 28);
            this.moveNextButton.TabIndex = 17;
            this.moveNextButton.Text = "Move Next";
            this.moveNextButton.UseVisualStyleBackColor = true;
            this.moveNextButton.Click += new System.EventHandler(this.moveNextButton_Click);
            // 
            // moveFirstButton
            // 
            this.moveFirstButton.Location = new System.Drawing.Point(560, 19);
            this.moveFirstButton.Margin = new System.Windows.Forms.Padding(4);
            this.moveFirstButton.Name = "moveFirstButton";
            this.moveFirstButton.Size = new System.Drawing.Size(132, 28);
            this.moveFirstButton.TabIndex = 16;
            this.moveFirstButton.Text = "Move First";
            this.moveFirstButton.UseVisualStyleBackColor = true;
            this.moveFirstButton.Click += new System.EventHandler(this.moveFirstButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Orders:";
            // 
            // dataGridVieworderLines
            // 
            this.dataGridVieworderLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVieworderLines.Location = new System.Drawing.Point(67, 190);
            this.dataGridVieworderLines.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridVieworderLines.Name = "dataGridVieworderLines";
            this.dataGridVieworderLines.ReadOnly = true;
            this.dataGridVieworderLines.Size = new System.Drawing.Size(556, 238);
            this.dataGridVieworderLines.TabIndex = 10;
            this.dataGridVieworderLines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderLinesdataGridView_CellContentClick);
            // 
            // dataGridViewOrderID
            // 
            this.dataGridViewOrderID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderID.Location = new System.Drawing.Point(67, 30);
            this.dataGridViewOrderID.Name = "dataGridViewOrderID";
            this.dataGridViewOrderID.Size = new System.Drawing.Size(470, 90);
            this.dataGridViewOrderID.TabIndex = 20;
            this.dataGridViewOrderID.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrderID_CellContentClick);
            // 
            // dataGridViewProductDetail
            // 
            this.dataGridViewProductDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductDetail.Location = new System.Drawing.Point(67, 479);
            this.dataGridViewProductDetail.Name = "dataGridViewProductDetail";
            this.dataGridViewProductDetail.Size = new System.Drawing.Size(556, 192);
            this.dataGridViewProductDetail.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Customers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 453);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Order Lines:";
            // 
            // RelatedTablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 700);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewProductDetail);
            this.Controls.Add(this.dataGridViewOrderID);
            this.Controls.Add(this.moveLastButton);
            this.Controls.Add(this.movePreviousButton);
            this.Controls.Add(this.moveNextButton);
            this.Controls.Add(this.moveFirstButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridVieworderLines);
            this.Name = "RelatedTablesForm";
            this.Text = "RelatedTablesForm";
            this.Load += new System.EventHandler(this.RelatedTablesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieworderLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button moveLastButton;
        private System.Windows.Forms.Button movePreviousButton;
        private System.Windows.Forms.Button moveNextButton;
        private System.Windows.Forms.Button moveFirstButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridVieworderLines;
        private System.Windows.Forms.DataGridView dataGridViewOrderID;
        private System.Windows.Forms.DataGridView dataGridViewProductDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}