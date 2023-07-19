using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace squareArea
{
    public partial class numberTxt : Form
    {
        public numberTxt()
        {
            InitializeComponent();
        }

        private void square_Click(object sender, EventArgs e)
        {
            int number, answer;
            number = int.Parse(numTxt.Text);
            answer = number / 4;
            answerTxt.Text = answer.ToString();
        }

        private void cube_Click(object sender, EventArgs e)
        {
            int number, answer;
            number = int.Parse(numTxt.Text);
            answer = number * number * number;
            answerTxt.Text = answer.ToString();
        }

        private void numTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            numTxt.Clear();
            answerTxt.Clear();
        }
    }
}
