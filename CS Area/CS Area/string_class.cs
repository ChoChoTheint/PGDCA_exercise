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
    public partial class string_class : Form
    {
        public string_class()
        {
            InitializeComponent();
        }
        private void btnLength_Click(object sender, EventArgs e)
        {
            string str = txtString.Text;
            txtLength.Text = str.Length.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLength.Text = "";
            txtString.Text = "";
            txtString.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
