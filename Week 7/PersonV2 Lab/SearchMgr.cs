using System;
using System.Windows.Forms;
using System.Data;

namespace PersonV2_Lab
{
    public partial class SearchMgr : Form
    {
        public SearchMgr()
        {
            InitializeComponent();
        }
        
        private void dgvResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string strPerson_ID = dgvResults.Rows[e.RowIndex].Cells[0].Value.ToString();
            
            int intPerson_ID = Convert.ToInt32(strPerson_ID);

            Form1 Editor = new Form1(intPerson_ID);
            Editor.ShowDialog();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            PersonV2 temp = new PersonV2();
            DataSet ds = temp.SearchPerson(txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, txtEmail.Text,
                txtCity.Text, txtState.Text, txtZipcode.Text, txtPhone.Text);

            dgvResults.DataSource = ds;
            dgvResults.DataMember = ds.Tables["Person_Temp"].ToString();
        }
    }
}