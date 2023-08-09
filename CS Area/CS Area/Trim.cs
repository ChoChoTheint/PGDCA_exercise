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
    public partial class Trim : Form
    {
        public Trim()
        {
            InitializeComponent();
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            txtSecondString.Text = txtFirstString.Text.Trim();
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
