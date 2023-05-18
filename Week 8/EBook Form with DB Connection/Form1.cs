using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        /// <summary>
        /// NEW - Constructor that Receives an EBook ID....this means we need to look up the data and populate fields (View/Edit/Del)
        /// </summary>
        /// <param name="intEBook_ID"></param>
        public Form1(int intEBook_ID)
        {
            InitializeComponent();
            EBook temp = new EBook();
            SqlDataReader dr = temp.FindOneEBook(intEBook_ID);
            
            while (dr.Read())
            {
                txtTitle.Text = dr["Title"].ToString();
                txtAuthorFirstName.Text = dr["AuthorFirst"].ToString();
                txtAuthorLastName.Text = dr["AuthorLast"].ToString();
                txtAuthorEmail.Text = dr["Email"].ToString();
                txtPages.Text = dr["Pages"].ToString();
                txtBookmark.Text = dr["BookmarkPage"].ToString();
                lblEBook_ID.Text = dr["EBook_ID"].ToString();

                dptPubDate.Value = DateTime.Parse(dr["DatePublished"].ToString());
                dtpRentalExpiration.Value = DateTime.Parse(dr["DateRentalExpires"].ToString());

                lblEBook_ID.Text = dr["EBook_ID"].ToString();
            }
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
