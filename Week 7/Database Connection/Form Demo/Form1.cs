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
            EBook temp = new EBook();
            
            //*****************************************************************************************************************************************************
            //Fiil in book

            temp.Title = txtTitle.Text;
            temp.AuthorFirstName = txtAuthorFirstName.Text;
            temp.AuthorLastName = txtAuthorLastName.Text;
            temp.AuthorEmail = txtAuthorEmail.Text;
            temp.Price = Double.Parse(txtPrice.Text);
            temp.PubDate = dptPubDate.Value;
            temp.DateRentalExpires = dtpRentalExpiration.Value;
            temp.Pages = Int32.Parse(txtPages.Text);
            temp.BookmarkPage = Int32.Parse(txtBookmark.Text);
            temp.Member = chkMembership.Checked;

            //*****************************************************************************************************************************************************
            //If the book has no errors, display the book in feedback label
            if (temp.Feedback.Contains("ERROR") == false)
            {
                lblFeedback.Text = "Title: " + temp.Title + "\n" + "Author Name: " + temp.AuthorFirstName + " " + temp.AuthorLastName + 
                                   "\n" + "Author Email: " + temp.AuthorEmail + "\n" + "Pages: " + temp.Pages +"\n" + "Book Price: " + temp.Price + "\n" + 
                                   "Publication Date: " + temp.PubDate.ToLongDateString() + "\n" + "Bookmarked Page: " + temp.BookmarkPage + "\n" + 
                                   "Rental Expiration: " + temp.DateRentalExpires.ToLongDateString();
            }
            //Else display error message within feedback label
            else
            {
                lblFeedback.Text = temp.Feedback;
            }

            //*****************************************************************************************************************************************************
            bool Member = chkMembership.Checked;
            MessageBox.Show(Member.ToString());
            
            
            if (!temp.Feedback.Contains("ERROR: "))
            {
                lblFeedback.Text = temp.AddARecord();
            }
            else
            {
                lblFeedback.Text = temp.Feedback;
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtAuthorFirstName.Clear();
            txtAuthorLastName.Clear();
            txtAuthorEmail.Clear();
            txtPrice.Clear();
            txtPages.Clear();
            txtBookmark.Clear();
            lblFeedback.Text = "Feedback";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            
            dtpRentalExpiration.Value = DateTime.Now.AddDays(14);
        }
        
        
    }
}
