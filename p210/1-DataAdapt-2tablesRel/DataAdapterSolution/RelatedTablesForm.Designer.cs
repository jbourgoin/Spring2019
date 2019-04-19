namespace DataAdapterSolution
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orderDateTextBox = new System.Windows.Forms.TextBox();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.orderLinesdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.orderLinesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // moveLastButton
            // 
            this.moveLastButton.Location = new System.Drawing.Point(486, 154);
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
            this.movePreviousButton.Location = new System.Drawing.Point(486, 109);
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
            this.moveNextButton.Location = new System.Drawing.Point(486, 64);
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
            this.moveFirstButton.Location = new System.Drawing.Point(486, 19);
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
            this.label3.Location = new System.Drawing.Point(64, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Order Lines:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Order Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Order ID";
            // 
            // orderDateTextBox
            // 
            this.orderDateTextBox.Location = new System.Drawing.Point(160, 104);
            this.orderDateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.orderDateTextBox.Name = "orderDateTextBox";
            this.orderDateTextBox.ReadOnly = true;
            this.orderDateTextBox.Size = new System.Drawing.Size(148, 20);
            this.orderDateTextBox.TabIndex = 12;
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.Location = new System.Drawing.Point(160, 41);
            this.orderIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.ReadOnly = true;
            this.orderIDTextBox.Size = new System.Drawing.Size(148, 20);
            this.orderIDTextBox.TabIndex = 11;
            // 
            // orderLinesdataGridView
            // 
            this.orderLinesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderLinesdataGridView.Location = new System.Drawing.Point(67, 223);
            this.orderLinesdataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.orderLinesdataGridView.Name = "orderLinesdataGridView";
            this.orderLinesdataGridView.ReadOnly = true;
            this.orderLinesdataGridView.Size = new System.Drawing.Size(556, 238);
            this.orderLinesdataGridView.TabIndex = 10;
            // 
            // RelatedTablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 480);
            this.Controls.Add(this.moveLastButton);
            this.Controls.Add(this.movePreviousButton);
            this.Controls.Add(this.moveNextButton);
            this.Controls.Add(this.moveFirstButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderDateTextBox);
            this.Controls.Add(this.orderIDTextBox);
            this.Controls.Add(this.orderLinesdataGridView);
            this.Name = "RelatedTablesForm";
            this.Text = "RelatedTablesForm";
            this.Load += new System.EventHandler(this.RelatedTablesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderLinesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button moveLastButton;
        private System.Windows.Forms.Button movePreviousButton;
        private System.Windows.Forms.Button moveNextButton;
        private System.Windows.Forms.Button moveFirstButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox orderDateTextBox;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.DataGridView orderLinesdataGridView;
    }
}