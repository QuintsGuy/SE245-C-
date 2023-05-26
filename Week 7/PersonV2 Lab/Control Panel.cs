using System;
using System.Windows.Forms;

namespace PersonV2_Lab
{
    public partial class Control_Panel : Form
    {
        public Control_Panel()
        {
            InitializeComponent();
        }
        
        private void btnAddPerson_Click_1(object sender, EventArgs e)
        {
            Form1 temp = new Form1();
            temp.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchMgr temp = new SearchMgr();
            temp.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SearchMgr temp = new SearchMgr();
            temp.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SearchMgr temp = new SearchMgr();
            temp.Show();
        }
    }
}