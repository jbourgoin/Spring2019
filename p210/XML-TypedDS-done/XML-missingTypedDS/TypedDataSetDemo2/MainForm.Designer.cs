namespace TypedDataSetDemo1
{
    partial class MainForm
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
            this.demo1Button = new System.Windows.Forms.Button();
            this.demo2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // demo1Button
            // 
            this.demo1Button.Location = new System.Drawing.Point(158, 68);
            this.demo1Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.demo1Button.Name = "demo1Button";
            this.demo1Button.Size = new System.Drawing.Size(112, 28);
            this.demo1Button.TabIndex = 0;
            this.demo1Button.Text = "Demo 1";
            this.demo1Button.UseVisualStyleBackColor = true;
            this.demo1Button.Click += new System.EventHandler(this.demo1Button_Click);
            // 
            // demo2Button
            // 
            this.demo2Button.Location = new System.Drawing.Point(158, 136);
            this.demo2Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.demo2Button.Name = "demo2Button";
            this.demo2Button.Size = new System.Drawing.Size(112, 28);
            this.demo2Button.TabIndex = 1;
            this.demo2Button.Text = "Demo 2";
            this.demo2Button.UseVisualStyleBackColor = true;
            this.demo2Button.Click += new System.EventHandler(this.demo2Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 251);
            this.Controls.Add(this.demo2Button);
            this.Controls.Add(this.demo1Button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Typed DataSet Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button demo1Button;
        private System.Windows.Forms.Button demo2Button;
    }
}