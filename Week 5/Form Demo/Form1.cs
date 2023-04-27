using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the area you type in the Book's Title");
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            //Create a new instance of a book
            Book temp = new Book();
            
            //****************************************************************
            //Fiil in book

            temp.Title = txtTitle.Text;
            temp.AuthorEmail = txtAuthorEmail.Text;
            temp.Price = Double.Parse(txtPrice.Text);
            temp.PubDate = dptPubDate.Value;

            //*****************************************************************
            //If the book has no errors, display the book in feedback label
            if (temp.Feedback.Contains("ERROR") == false)
            {
                lblFeedback.Text = temp.Title + "\n" + temp.AuthorEmail + "\n" + temp.PubDate.ToLongDateString();
            }
            //Else display error message within feedback label
            else
            {
                lblFeedback.Text = temp.Feedback;
            }
        }
    }
}
