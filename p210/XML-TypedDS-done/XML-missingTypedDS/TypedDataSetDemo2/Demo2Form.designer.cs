namespace TypedDataSetDemo1
{
    partial class Demo2Form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveXMLButton = new System.Windows.Forms.Button();
            this.loadDBButton = new System.Windows.Forms.Button();
            this.loadXMLButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 361);
            this.dataGridView1.TabIndex = 1;
            // 
            // saveXMLButton
            // 
            this.saveXMLButton.Location = new System.Drawing.Point(573, 80);
            this.saveXMLButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveXMLButton.Name = "saveXMLButton";
            this.saveXMLButton.Size = new System.Drawing.Size(207, 28);
            this.saveXMLButton.TabIndex = 3;
            this.saveXMLButton.Text = "Save to XML";
            this.saveXMLButton.UseVisualStyleBackColor = true;
            this.saveXMLButton.Click += new System.EventHandler(this.saveXMLButton_Click);
            // 
            // loadDBButton
            // 
            this.loadDBButton.Location = new System.Drawing.Point(573, 28);
            this.loadDBButton.Margin = new System.Windows.Forms.Padding(4);
            this.loadDBButton.Name = "loadDBButton";
            this.loadDBButton.Size = new System.Drawing.Size(207, 28);
            this.loadDBButton.TabIndex = 4;
            this.loadDBButton.Text = "Load from Data Base";
            this.loadDBButton.UseVisualStyleBackColor = true;
            this.loadDBButton.Click += new System.EventHandler(this.loadDBButton_Click);
            // 
            // loadXMLButton
            // 
            this.loadXMLButton.Location = new System.Drawing.Point(573, 198);
            this.loadXMLButton.Margin = new System.Windows.Forms.Padding(4);
            this.loadXMLButton.Name = "loadXMLButton";
            this.loadXMLButton.Size = new System.Drawing.Size(207, 28);
            this.loadXMLButton.TabIndex = 5;
            this.loadXMLButton.Text = "Load from XML";
            this.loadXMLButton.UseVisualStyleBackColor = true;
            this.loadXMLButton.Click += new System.EventHandler(this.loadXMLButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(573, 150);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(207, 28);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear Data";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Inventory Value";
            // 
            // valueLabel
            // 
            this.valueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valueLabel.Location = new System.Drawing.Point(177, 9);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(149, 15);
            this.valueLabel.TabIndex = 8;
            // 
            // Demo2Form
            // 
            this.AcceptButton = this.clearButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 462);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.loadXMLButton);
            this.Controls.Add(this.loadDBButton);
            this.Controls.Add(this.saveXMLButton);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Demo2Form";
            this.Text = "Demo";
            this.Load += new System.EventHandler(this.Demo2Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button saveXMLButton;
        private System.Windows.Forms.Button loadDBButton;
        private System.Windows.Forms.Button loadXMLButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label valueLabel;
    }
}

