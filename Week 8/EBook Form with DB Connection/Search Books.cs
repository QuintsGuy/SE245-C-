using System;
using System.Data;
using System.Windows.Forms;

namespace Form_Demo
{
    public partial class Search_Books : Form
    {
        public Search_Books()
        {
            InitializeComponent();
        }

        private void btnSearchBooks_Click_1(object sender, EventArgs e)
        {
            EBook temp = new EBook();
            DataSet ds = temp.SearchEBooks(txtTitle.Text, txtAuthorLast.Text);

            dgvResults.DataSource = ds;
            dgvResults.DataMember = ds.Tables["EBooks_Temp"].ToString();
        }

        private void dgvResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string strEBook_ID = dgvResults.Rows[e.RowIndex].Cells[0].Value.ToString();

            int intEBook_ID = Convert.ToInt32(strEBook_ID);
            Form1 Editor = new Form1(intEBook_ID);
            Editor.ShowDialog();
        }
    }
}