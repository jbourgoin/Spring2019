namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBirdCount = new System.Windows.Forms.TextBox();
            this.dbErrorLabel = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.dataGridViewRegions = new System.Windows.Forms.DataGridView();
            this.dataGridViewBirder = new System.Windows.Forms.DataGridView();
            this.dataGridViewBird = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBirder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBird)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Region";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Birder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bird";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 161);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "How Many?";
            // 
            // textBoxBirdCount
            // 
            this.textBoxBirdCount.Location = new System.Drawing.Point(200, 431);
            this.textBoxBirdCount.Name = "textBoxBirdCount";
            this.textBoxBirdCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxBirdCount.TabIndex = 8;
            // 
            // dbErrorLabel
            // 
            this.dbErrorLabel.AutoSize = true;
            this.dbErrorLabel.Location = new System.Drawing.Point(200, 500);
            this.dbErrorLabel.Name = "dbErrorLabel";
            this.dbErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.dbErrorLabel.TabIndex = 9;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(213, 457);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 10;
            this.buttonSubmit.Text = "SUBMIT";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // dataGridViewRegions
            // 
            this.dataGridViewRegions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegions.Location = new System.Drawing.Point(175, 46);
            this.dataGridViewRegions.Name = "dataGridViewRegions";
            this.dataGridViewRegions.Size = new System.Drawing.Size(331, 99);
            this.dataGridViewRegions.TabIndex = 11;
            // 
            // dataGridViewBirder
            // 
            this.dataGridViewBirder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBirder.Location = new System.Drawing.Point(175, 197);
            this.dataGridViewBirder.Name = "dataGridViewBirder";
            this.dataGridViewBirder.Size = new System.Drawing.Size(331, 99);
            this.dataGridViewBirder.TabIndex = 12;
            // 
            // dataGridViewBird
            // 
            this.dataGridViewBird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBird.Location = new System.Drawing.Point(175, 313);
            this.dataGridViewBird.Name = "dataGridViewBird";
            this.dataGridViewBird.Size = new System.Drawing.Size(331, 99);
            this.dataGridViewBird.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 579);
            this.Controls.Add(this.dataGridViewBird);
            this.Controls.Add(this.dataGridViewBirder);
            this.Controls.Add(this.dataGridViewRegions);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.dbErrorLabel);
            this.Controls.Add(this.textBoxBirdCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBirder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBirdCount;
        private System.Windows.Forms.Label dbErrorLabel;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.DataGridView dataGridViewRegions;
        private System.Windows.Forms.DataGridView dataGridViewBirder;
        private System.Windows.Forms.DataGridView dataGridViewBird;
    }
}

