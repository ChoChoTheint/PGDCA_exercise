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
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void clickBtn_Click(object sender, EventArgs e)
        {
            int f = 1, s = 1, t = 0;
            txtNumber.Text = txtNumber.Text + "\r\n" + f.ToString();
            txtNumber.Text = txtNumber.Text + "\r\n" + s.ToString();
            t = f + s;
            txtNumber.Text = txtNumber.Text + "\r\n" + t.ToString();
            for(int i = 3;i <= 5 ; i+=2)
            {
                txtNumber.Text = txtNumber.Text + "\r\n" + i.ToString();
            }
        }
    }
}
