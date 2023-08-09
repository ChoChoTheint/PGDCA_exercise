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
    public partial class TotalPayment : Form
    {
        public TotalPayment()
        {
            InitializeComponent();
        }

        private void clickBtn_Click(object sender, EventArgs e)
        {
            int reg_hrs = int.Parse(txtRegHr.Text);
            int ovt_hrs = int.Parse(txtOvtHr.Text);
            int pay_rate = int.Parse(txtPayRate.Text);
            double reg_pay, over_pay, tot_pay;
            reg_pay = reg_hrs * pay_rate;
            over_pay = ovt_hrs * pay_rate * 1.5;
            tot_pay = reg_pay + over_pay;
            MessageBox.Show("Your total Payment is " + tot_pay.ToString(), "Calculate Total Payment", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
