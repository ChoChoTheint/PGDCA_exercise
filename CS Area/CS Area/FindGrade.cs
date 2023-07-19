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
    public partial class FindGrade : Form
    {
        public FindGrade()
        {
            InitializeComponent();
        }

        private void findGradeBtn_Click(object sender, EventArgs e)
        {
            if(int.Parse(enterTxt.Text)<300)
            {
                MessageBox.Show("Grade I", "Grade Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(int.Parse(enterTxt.Text)<=400)
            {
                MessageBox.Show("Grade II", "Grade Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Grade III", "Grade Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
