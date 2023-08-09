using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Area
{
    public partial class StringCompare : Form
    {
        public StringCompare()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            int check;
            check = txtFirstString.Text.CompareTo(txtSecondString.Text);
            if (check == 0)
            {
                MessageBox.Show("The Two string are the same", "String Compare",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The Two string are not the same", "String Compare", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstString.Text = "";
            txtSecondString.Text = "";
            txtFirstString.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
