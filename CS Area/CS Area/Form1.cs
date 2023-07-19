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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            double dRadius;
            double dArea;

            dRadius = double.Parse(txtRadius.Text.ToString());
            dArea = 3.14 * dRadius * dRadius;
            txtArea.Text = dArea.ToString();
        }

        private void clsBtn_Click(object sender, EventArgs e)
        {
            txtRadius.Clear();
            txtArea.Clear();
        }
    }
}
