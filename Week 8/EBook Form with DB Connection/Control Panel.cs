using System;
using System.Windows.Forms;

namespace Form_Demo
{
    public partial class Control_Panel : Form
    {
        public Control_Panel()
        {
            InitializeComponent();
        }

        private void Control_Panel_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSearchBooks_Click(object sender, EventArgs e)
        {
            Search_Books temp = new Search_Books();
            temp.ShowDialog();
        }

        private void btnAddBook_Click_1(object sender, EventArgs e)
        {
            Form1 temp = new Form1();
            temp.Show();
        }
    }
}