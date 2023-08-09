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
    public partial class BonusAndPayment : Form
    {
        public BonusAndPayment()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            int bonus;
            int Salary = int.Parse(txtSalary.Text);
            if(Salary < 5000)
            {
                bonus = 500;
                MessageBox.Show("Your Bonus " + bonus.ToString()+"\n Salary is "+Salary.ToString(), "Bonus and Payment", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if (Salary <= 8000)
            {
                bonus = 800;
                MessageBox.Show("Your Bonus " + bonus.ToString() + "\n Salary is " + Salary.ToString(), "Bonus and Payment", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                bonus = 1000;
                MessageBox.Show("Your Bonus " + bonus.ToString() + "\n Salary is " + Salary.ToString(), "Bonus and Payment", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
