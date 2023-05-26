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

namespace PersonV2_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            btnUpdate.Visible = false;
            btnUpdate.Enabled = false;
            btnDelete.Visible = false;
            btnDelete.Enabled = false;
        }

        public Form1(int intPerson_ID)
        {
            InitializeComponent();
            
            btnSubmit.Visible = false;
            btnSubmit.Enabled = false;
            
            PersonV2 temp = new PersonV2();
            SqlDataReader dr = temp.findPerson(intPerson_ID);

            while (dr.Read())
            {
                txtFirstName.Text = dr["FName"].ToString();
                txtMiddleName.Text = dr["MName"].ToString();
                txtLastName.Text = dr["LName"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                txtCity.Text = dr["City"].ToString();
                txtState.Text = dr["State"].ToString();
                txtZipcode.Text = dr["Zipcode"].ToString();
                txtPhone.Text = dr["Phone"].ToString();
                lblPersonID.Text = dr["Person_ID"].ToString();
            }
        }
        
        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            PersonV2 temp = new PersonV2();
            
            temp.FName = txtFirstName.Text;
            temp.MName = txtMiddleName.Text;
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
            
            if(temp.Feedback.Contains("ERROR")==false)
            {
                lblFeedback.Text = temp.FName + " " + temp.MName + " "+ temp.LName + "\n" 
                                   + temp.Street1 + ", " + temp.Street2 + ", " + temp.City + 
                                   ", " + temp.State + " " + temp.ZipCode + "\n" + temp.Phone + 
                                   "\n" + temp.Email + "\n" + temp.CellPhone + "\n" + temp.InstagramURL;
            }
            else
            {
                lblFeedback.Text = temp.Feedback;
            }

            if (!temp.Feedback.Contains("ERROR: "))
            {
                lblFeedback.Text = temp.addRecord();
            }
            else
            {
                lblFeedback.Text = temp.Feedback;
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtMiddleName.Clear();
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
            lblFeedback.Text = "Feedback";
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Int32 intPerson_ID = Convert.ToInt32(lblPersonID.Text);

            PersonV2 temp = new PersonV2();

            lblFeedback.Text = temp.deleteRecord(intPerson_ID);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PersonV2 temp = new PersonV2();

            temp.Person_ID = Convert.ToInt32(lblPersonID.Text);
            temp.FName = txtFirstName.Text;
            temp.MName = txtMiddleName.Text;
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
            
            if (!temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.updateRecord();
            }
            else
            {
                lblFeedback.Text = temp.Feedback;
            }
        }
    }
}