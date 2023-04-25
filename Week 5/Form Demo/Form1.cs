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
            if (txtTitle.Text.ToLower().Contains("homework") == false)
            {
                lblFeedback.Text = "The book you added is " + txtTitle.Text;
            }
            else
            {
                lblFeedback.Text = "Error: You cannot use bad words in your book title";
            }
        }
    }
}
