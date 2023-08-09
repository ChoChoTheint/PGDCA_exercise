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
    public partial class StartWith : Form
    {
        public StartWith()
        {
            InitializeComponent();
        }

        private void btnStarts_Click(object sender, EventArgs e)
        {
            Boolean str;
            str = txtFirstString.Text.StartsWith(txtSecondString.Text);
            MessageBox.Show(str.ToString(), "Start With", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstString.Text = "";
            txtSecondString.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
