namespace ToDoLL
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
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelRatingOutput = new System.Windows.Forms.Label();
            this.buttonGetNext = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.labelWhat = new System.Windows.Forms.Label();
            this.labelWhy = new System.Windows.Forms.Label();
            this.labelTitleOutput = new System.Windows.Forms.Label();
            this.labelAuthorOutput = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Give the book a Rating";
            // 
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(205, 80);
            this.textBoxRating.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(132, 22);
            this.textBoxRating.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(208, 218);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add To List";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelRatingOutput
            // 
            this.labelRatingOutput.AutoSize = true;
            this.labelRatingOutput.Location = new System.Drawing.Point(221, 400);
            this.labelRatingOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRatingOutput.Name = "labelRatingOutput";
            this.labelRatingOutput.Size = new System.Drawing.Size(46, 17);
            this.labelRatingOutput.TabIndex = 3;
            this.labelRatingOutput.Text = "label2";
            // 
            // buttonGetNext
            // 
            this.buttonGetNext.Location = new System.Drawing.Point(205, 304);
            this.buttonGetNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGetNext.Name = "buttonGetNext";
            this.buttonGetNext.Size = new System.Drawing.Size(128, 28);
            this.buttonGetNext.TabIndex = 4;
            this.buttonGetNext.Text = "Get Next To Do";
            this.buttonGetNext.UseVisualStyleBackColor = true;
            this.buttonGetNext.Click += new System.EventHandler(this.buttonGetNext_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(205, 127);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(132, 22);
            this.textBoxTitle.TabIndex = 5;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(205, 177);
            this.textBoxAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(132, 22);
            this.textBoxAuthor.TabIndex = 6;
            // 
            // labelWhat
            // 
            this.labelWhat.AutoSize = true;
            this.labelWhat.Location = new System.Drawing.Point(36, 130);
            this.labelWhat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWhat.Name = "labelWhat";
            this.labelWhat.Size = new System.Drawing.Size(133, 17);
            this.labelWhat.TabIndex = 7;
            this.labelWhat.Text = "Enter the Book Title";
            // 
            // labelWhy
            // 
            this.labelWhy.AutoSize = true;
            this.labelWhy.Location = new System.Drawing.Point(36, 181);
            this.labelWhy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWhy.Name = "labelWhy";
            this.labelWhy.Size = new System.Drawing.Size(163, 17);
            this.labelWhy.TabIndex = 8;
            this.labelWhy.Text = "Enter the Author\'s Name";
            // 
            // labelTitleOutput
            // 
            this.labelTitleOutput.AutoSize = true;
            this.labelTitleOutput.Location = new System.Drawing.Point(221, 455);
            this.labelTitleOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitleOutput.Name = "labelTitleOutput";
            this.labelTitleOutput.Size = new System.Drawing.Size(46, 17);
            this.labelTitleOutput.TabIndex = 9;
            this.labelTitleOutput.Text = "label2";
            // 
            // labelAuthorOutput
            // 
            this.labelAuthorOutput.AutoSize = true;
            this.labelAuthorOutput.Location = new System.Drawing.Point(221, 505);
            this.labelAuthorOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAuthorOutput.Name = "labelAuthorOutput";
            this.labelAuthorOutput.Size = new System.Drawing.Size(46, 17);
            this.labelAuthorOutput.TabIndex = 10;
            this.labelAuthorOutput.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 400);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Rating";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 455);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 505);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Author";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 636);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelAuthorOutput);
            this.Controls.Add(this.labelTitleOutput);
            this.Controls.Add(this.labelWhy);
            this.Controls.Add(this.labelWhat);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.buttonGetNext);
            this.Controls.Add(this.labelRatingOutput);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxRating);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelRatingOutput;
        private System.Windows.Forms.Button buttonGetNext;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label labelWhat;
        private System.Windows.Forms.Label labelWhy;
        private System.Windows.Forms.Label labelTitleOutput;
        private System.Windows.Forms.Label labelAuthorOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

