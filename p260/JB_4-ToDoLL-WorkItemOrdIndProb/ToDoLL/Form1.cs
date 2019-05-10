using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoLL
{
    public partial class Form1 : Form
    {
        WorkItenLinkedList ToDoLL;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToDoLL = new WorkItenLinkedList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Book newBook = new Book();
            newBook.Rating = Convert.ToInt32(textBoxRating.Text);
            newBook.Title = textBoxTitle.Text;
            newBook.Author = textBoxAuthor.Text;

            if (newBook.Rating > 5)
            {
                newBook.Rating = 5;
            }

            ToDoLL.InsertInOrder(newBook);  // check the object going in to make sure it has correct values
            //replace that call with a call to the new  InsertAt(WorkItem pWorkItem, uint index), get the index value
            // from the new textBoxPrioity


            textBoxRating.Text = "";
            textBoxTitle.Text= "";
            textBoxAuthor.Text = "";
        }

        private void buttonGetNext_Click(object sender, EventArgs e)
        {
            try
            {
                Book newBook = new Book();
                newBook = ToDoLL.RemoveFromFront();
                labelRatingOutput.Text = newBook.Rating.ToString();
                labelTitleOutput.Text = newBook.Title;
                labelAuthorOutput.Text = newBook.Author;
            }
            catch (Exception)
            {
                labelRatingOutput.Text = "Nothing more to do.";
                labelTitleOutput.Text = "";
                labelAuthorOutput.Text = "";
            }
          
        }

       
    }
}

