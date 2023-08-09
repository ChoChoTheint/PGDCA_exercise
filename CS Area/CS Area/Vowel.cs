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
    public partial class Vowel : Form
    {
        public Vowel()
        {
            InitializeComponent();
        }

        private void btnVowel_Click(object sender, EventArgs e)
        {
            txtSecondString.Text = txtFirstString.Text.ToLower();
            string str = txtSecondString.Text;
            if (str == "a" || str == "e" || str == "i" || str == "o" || str == "u")
            {
                MessageBox.Show("Input string is vowel", "Check Vowel", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Input string is not vowel", "Check Vowel", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
            this.Close();
        }
    }
}
