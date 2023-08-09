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
    public partial class EvenInteger : Form
    {
        public EvenInteger()
        {
            InitializeComponent();
        }

        private void clickBtn_Click(object sender, EventArgs e)
        {
            int i = 2;
            while (i <= 100)
            {
                txtNumber.Text = txtNumber.Text + "\r\n" + i.ToString();
                i += 2;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
