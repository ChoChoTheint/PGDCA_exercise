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
    public partial class MaxAndMinNumber : Form
    {
        public MaxAndMinNumber()
        {
            InitializeComponent();
        }

        private void clickBtn_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = int.Parse(txtNumOne.Text);
            num2 = int.Parse(txtNumTwo.Text);
            if(num1 > num2)
            {
                MessageBox.Show("Number One is Maximum and number two is minimum.","MaxAndMinNumber", MessageBoxButtons.OK);
            }
            else if(num2 > num1)
            {
                MessageBox.Show("Number Two is Maximum and number one is minimum.", "MaxAndMinNumber", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Number One = Number Two", "MaxAndMinNumber", MessageBoxButtons.OK);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
