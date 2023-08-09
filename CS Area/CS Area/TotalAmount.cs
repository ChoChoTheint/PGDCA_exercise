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
    public partial class TotalAmount : Form
    {
        public TotalAmount()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            int PurchaseAmount = int.Parse(txtPurchaseAmount.Text);
            int TaxCode = int.Parse(comboBox1.Text);
            double Amount;
            switch (TaxCode)
            {
                case 0: MessageBox.Show("Your Tax Amount is 0 ","Tax Payable",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);break;
                case 1: Amount = PurchaseAmount * 0.03; MessageBox.Show("Your Tax Amount is "+Amount.ToString(), "Tax Payable", MessageBoxButtons.OKCancel, MessageBoxIcon.Information); break;
                case 2: Amount = PurchaseAmount * 0.05; MessageBox.Show("Your Tax Amount is " + Amount.ToString(), "Tax Payable", MessageBoxButtons.OKCancel, MessageBoxIcon.Information); break;
                case 3: Amount = PurchaseAmount * 0.07; MessageBox.Show("Your Tax Amount is " + Amount.ToString(), "Tax Payable", MessageBoxButtons.OKCancel, MessageBoxIcon.Information); break;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
