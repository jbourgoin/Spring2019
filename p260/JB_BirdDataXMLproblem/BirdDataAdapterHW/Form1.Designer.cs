namespace BirdDataAdapterHW
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
            this.DataGridViewBirds = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.dataGridViewXML = new System.Windows.Forms.DataGridView();
            this.buttonReadXML = new System.Windows.Forms.Button();
            this.buttonAddSQL = new System.Windows.Forms.Button();
            this.labelDataSaved = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBirds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXML)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewBirds
            // 
            this.DataGridViewBirds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewBirds.Location = new System.Drawing.Point(60, 347);
            this.DataGridViewBirds.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridViewBirds.Name = "DataGridViewBirds";
            this.DataGridViewBirds.Size = new System.Drawing.Size(945, 372);
            this.DataGridViewBirds.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(60, 727);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 38);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(168, 727);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(100, 38);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Refresh From SQL";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // dataGridViewXML
            // 
            this.dataGridViewXML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXML.Location = new System.Drawing.Point(60, 13);
            this.dataGridViewXML.Name = "dataGridViewXML";
            this.dataGridViewXML.RowTemplate.Height = 24;
            this.dataGridViewXML.Size = new System.Drawing.Size(945, 242);
            this.dataGridViewXML.TabIndex = 3;
            // 
            // buttonReadXML
            // 
            this.buttonReadXML.Location = new System.Drawing.Point(60, 274);
            this.buttonReadXML.Name = "buttonReadXML";
            this.buttonReadXML.Size = new System.Drawing.Size(130, 38);
            this.buttonReadXML.TabIndex = 4;
            this.buttonReadXML.Text = "Read XML";
            this.buttonReadXML.UseVisualStyleBackColor = true;
            this.buttonReadXML.Click += new System.EventHandler(this.buttonReadXML_Click);
            // 
            // buttonAddSQL
            // 
            this.buttonAddSQL.Location = new System.Drawing.Point(840, 274);
            this.buttonAddSQL.Name = "buttonAddSQL";
            this.buttonAddSQL.Size = new System.Drawing.Size(165, 38);
            this.buttonAddSQL.TabIndex = 5;
            this.buttonAddSQL.Text = "Add Records to SQL";
            this.buttonAddSQL.UseVisualStyleBackColor = true;
            this.buttonAddSQL.Click += new System.EventHandler(this.buttonAddSQL_Click);
            // 
            // labelDataSaved
            // 
            this.labelDataSaved.AutoSize = true;
            this.labelDataSaved.Location = new System.Drawing.Point(296, 738);
            this.labelDataSaved.Name = "labelDataSaved";
            this.labelDataSaved.Size = new System.Drawing.Size(0, 17);
            this.labelDataSaved.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 789);
            this.Controls.Add(this.labelDataSaved);
            this.Controls.Add(this.buttonAddSQL);
            this.Controls.Add(this.buttonReadXML);
            this.Controls.Add(this.dataGridViewXML);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.DataGridViewBirds);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBirds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXML)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewBirds;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridView dataGridViewXML;
        private System.Windows.Forms.Button buttonReadXML;
        private System.Windows.Forms.Button buttonAddSQL;
        private System.Windows.Forms.Label labelDataSaved;
    }
}

