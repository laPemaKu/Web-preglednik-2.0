using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Preglednik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            webPreglednik.Navigate(txtSearchBar.Text);
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webPreglednik.GoForward();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webPreglednik.GoBack();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webPreglednik.Navigate("Google.com");
        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {

        }
        private void Button_color(object sender, PaintEventArgs e)
        {
            menuStrip1.BackColor = Color.White;
        }
    }
}
