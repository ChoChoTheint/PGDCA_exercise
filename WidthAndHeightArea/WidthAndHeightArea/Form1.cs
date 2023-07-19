using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WidthAndHeightArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            int length, breadth, answer;
            length = int.Parse(txtLength.Text);
            breadth = int.Parse(txtBreadth.Text);
            answer = length * breadth;
            txtAnswer.Text = answer.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLength.Clear();
            txtBreadth.Clear();
            txtAnswer.Clear();
        }
    }
}
