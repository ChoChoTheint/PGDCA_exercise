using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace perimeterSquare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            int perimeter, answer;
            perimeter = int.Parse(txtPerimeter.Text);
            answer = perimeter / 4;
            txtAnswer.Text = answer.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPerimeter.Clear();
            txtAnswer.Clear();
        }
    }
}
