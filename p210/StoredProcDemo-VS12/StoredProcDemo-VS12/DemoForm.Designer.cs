namespace StoredProcDemo_VS12
{
    partial class DemoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.supplierIDTextBox = new System.Windows.Forms.TextBox();
            this.categoryIDTextBox = new System.Windows.Forms.TextBox();
            this.quantityPerUnitTextBox = new System.Windows.Forms.TextBox();
            this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.unitsOnOrderTextBox = new System.Windows.Forms.TextBox();
            this.unitsInStockTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.supplierProductIDTextBox = new System.Windows.Forms.TextBox();
            this.discontinuedTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SupplierID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CategoryID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity Per Unit";
            // 
            // nameTextBox
            // 
            this.nameTextBox.AcceptsReturn = true;
            this.nameTextBox.Location = new System.Drawing.Point(128, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // supplierIDTextBox
            // 
            this.supplierIDTextBox.AcceptsReturn = true;
            this.supplierIDTextBox.Location = new System.Drawing.Point(128, 49);
            this.supplierIDTextBox.Name = "supplierIDTextBox";
            this.supplierIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.supplierIDTextBox.TabIndex = 6;
            this.supplierIDTextBox.Text = "5";
            // 
            // categoryIDTextBox
            // 
            this.categoryIDTextBox.AcceptsReturn = true;
            this.categoryIDTextBox.Location = new System.Drawing.Point(128, 79);
            this.categoryIDTextBox.Name = "categoryIDTextBox";
            this.categoryIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoryIDTextBox.TabIndex = 7;
            this.categoryIDTextBox.Text = "5";
            // 
            // quantityPerUnitTextBox
            // 
            this.quantityPerUnitTextBox.AcceptsReturn = true;
            this.quantityPerUnitTextBox.Location = new System.Drawing.Point(128, 109);
            this.quantityPerUnitTextBox.Name = "quantityPerUnitTextBox";
            this.quantityPerUnitTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityPerUnitTextBox.TabIndex = 8;
            this.quantityPerUnitTextBox.Text = "5";
            // 
            // reorderLevelTextBox
            // 
            this.reorderLevelTextBox.AcceptsReturn = true;
            this.reorderLevelTextBox.Location = new System.Drawing.Point(128, 234);
            this.reorderLevelTextBox.Name = "reorderLevelTextBox";
            this.reorderLevelTextBox.Size = new System.Drawing.Size(100, 20);
            this.reorderLevelTextBox.TabIndex = 16;
            this.reorderLevelTextBox.Text = "5";
            // 
            // unitsOnOrderTextBox
            // 
            this.unitsOnOrderTextBox.AcceptsReturn = true;
            this.unitsOnOrderTextBox.Location = new System.Drawing.Point(128, 204);
            this.unitsOnOrderTextBox.Name = "unitsOnOrderTextBox";
            this.unitsOnOrderTextBox.Size = new System.Drawing.Size(100, 20);
            this.unitsOnOrderTextBox.TabIndex = 15;
            this.unitsOnOrderTextBox.Text = "5";
            // 
            // unitsInStockTextBox
            // 
            this.unitsInStockTextBox.AcceptsReturn = true;
            this.unitsInStockTextBox.Location = new System.Drawing.Point(128, 174);
            this.unitsInStockTextBox.Name = "unitsInStockTextBox";
            this.unitsInStockTextBox.Size = new System.Drawing.Size(100, 20);
            this.unitsInStockTextBox.TabIndex = 14;
            this.unitsInStockTextBox.Text = "5";
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.AcceptsReturn = true;
            this.unitPriceTextBox.Location = new System.Drawing.Point(128, 144);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.unitPriceTextBox.TabIndex = 13;
            this.unitPriceTextBox.Text = "5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Reorder Level";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Units on Order";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Units in Stock";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Unit Price";
            // 
            // supplierProductIDTextBox
            // 
            this.supplierProductIDTextBox.AcceptsReturn = true;
            this.supplierProductIDTextBox.Location = new System.Drawing.Point(128, 299);
            this.supplierProductIDTextBox.Name = "supplierProductIDTextBox";
            this.supplierProductIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.supplierProductIDTextBox.TabIndex = 20;
            this.supplierProductIDTextBox.Text = "10005";
            // 
            // discontinuedTextBox
            // 
            this.discontinuedTextBox.AcceptsReturn = true;
            this.discontinuedTextBox.Location = new System.Drawing.Point(128, 269);
            this.discontinuedTextBox.Name = "discontinuedTextBox";
            this.discontinuedTextBox.Size = new System.Drawing.Size(100, 20);
            this.discontinuedTextBox.TabIndex = 19;
            this.discontinuedTextBox.Text = "False";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "SupplierProductID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Discontinued";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(65, 346);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(148, 23);
            this.saveButton.TabIndex = 21;
            this.saveButton.Text = "Write To Database";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 386);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.supplierProductIDTextBox);
            this.Controls.Add(this.discontinuedTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.reorderLevelTextBox);
            this.Controls.Add(this.unitsOnOrderTextBox);
            this.Controls.Add(this.unitsInStockTextBox);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.quantityPerUnitTextBox);
            this.Controls.Add(this.categoryIDTextBox);
            this.Controls.Add(this.supplierIDTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DemoForm";
            this.Text = "Stored Procedure Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox supplierIDTextBox;
        private System.Windows.Forms.TextBox categoryIDTextBox;
        private System.Windows.Forms.TextBox quantityPerUnitTextBox;
        private System.Windows.Forms.TextBox reorderLevelTextBox;
        private System.Windows.Forms.TextBox unitsOnOrderTextBox;
        private System.Windows.Forms.TextBox unitsInStockTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox supplierProductIDTextBox;
        private System.Windows.Forms.TextBox discontinuedTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button saveButton;
    }
}

