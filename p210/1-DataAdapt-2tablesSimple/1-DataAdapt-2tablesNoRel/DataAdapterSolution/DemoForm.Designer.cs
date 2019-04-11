namespace DataAdapterSolution
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
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.customerCombogroupBox1 = new System.Windows.Forms.GroupBox();
            this.customerCombogroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerComboBox
            // 
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(102, 43);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(213, 21);
            this.customerComboBox.TabIndex = 0;
            this.customerComboBox.SelectedIndexChanged += new System.EventHandler(this.customerComboBox_SelectedIndexChanged);
            // 
            // customerCombogroupBox1
            // 
            this.customerCombogroupBox1.Controls.Add(this.customerComboBox);
            this.customerCombogroupBox1.Location = new System.Drawing.Point(23, 39);
            this.customerCombogroupBox1.Name = "customerCombogroupBox1";
            this.customerCombogroupBox1.Size = new System.Drawing.Size(447, 103);
            this.customerCombogroupBox1.TabIndex = 1;
            this.customerCombogroupBox1.TabStop = false;
            this.customerCombogroupBox1.Text = "Demo1";
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 262);
            this.Controls.Add(this.customerCombogroupBox1);
            this.Name = "DemoForm";
            this.Text = "DemoForm";
            this.Load += new System.EventHandler(this.DemoForm_Load);
            this.customerCombogroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.GroupBox customerCombogroupBox1;
    }
}