using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            Customer temp = new Customer();
        
            temp.FName = txtFirstName.Text;
            temp.MName = txtMiddleInitial.Text;
            temp.LName = txtLastName.Text;
            temp.Street1 = txtStreet1.Text;
            temp.Street2 = txtStreet2.Text;
            temp.City = txtCity.Text;
            temp.State = txtState.Text;
            temp.ZipCode = txtZipcode.Text;
            temp.Phone = txtPhone.Text;
            temp.Email = txtEmail.Text;
            temp.CellPhone = txtCellPhone.Text;
            temp.InstagramURL = txtInstagram.Text;
            temp.CustomerSince = dptCustomer.Value;
            temp.TotalPurchases = double.Parse(txtPurchases.Text);
            temp.DiscountMember = chkbxDiscount.Checked;
            temp.RewardsEarned = int.Parse(txtRewards.Text);
        
            if(temp.Feedback.Contains("ERROR")==false)
            {
                lblFeedback.Text = temp.FName + " " + temp.MName + " "+ temp.LName + "\n" 
                                   + temp.Street1 + ", " + temp.Street2 + ", " + temp.City + 
                                   ", " + temp.State + " " + temp.ZipCode + "\n" + temp.Phone + 
                                   "\n" + temp.Email + "\n" + temp.CellPhone + "\n" + temp.InstagramURL
                                   + "\n" + temp.CustomerSince + "\n" + temp.TotalPurchases + "\n" + 
                                   temp.DiscountMember + "\n" + temp.RewardsEarned;
            }
            else
            {
                lblFeedback.Text = temp.Feedback;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtMiddleInitial.Clear();
            txtLastName.Clear();
            txtStreet1.Clear();
            txtStreet2.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtZipcode.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtCellPhone.Clear();
            txtInstagram.Clear();
            txtPurchases.Clear();
            txtRewards.Clear();
            lblFeedback.Text = "Feedback";
        }
    }
}