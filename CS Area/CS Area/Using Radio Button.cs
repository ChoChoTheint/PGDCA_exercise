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
    public partial class Using_Radio_Button : Form
    {
        public Using_Radio_Button()
        {
            InitializeComponent();
        }

        private void clickBtn_Click(object sender, EventArgs e)
        {
            if (pgdcaRadionBtn.Checked == true)
                MessageBox.Show("Welcome from PGDCA", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            else
                MessageBox.Show("Welcome from Yangon University", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
