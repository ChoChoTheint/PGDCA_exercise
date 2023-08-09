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
    public partial class CarRentalChargesInformation : Form
    {
        public CarRentalChargesInformation()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int charges;
        int check;
        int discount;
        private void calBtn_Click(object sender, EventArgs e)
        {
            switch (check)
            {
                case 1:
                    charges = int.Parse(txtDays.Text) * 100000;
                    break;
                case 2:
                    charges = int.Parse(txtDays.Text) * 7000;
                    break;
                 case 3:
                    charges = int.Parse(txtDays.Text) * 5000;
                    break;
            }
            if(charges >= 100000)
            {
                discount = (charges*10)/100;
            }
            else{
                discount=0;
            }
            MessageBox.Show("Rent charges=" + charges.ToString() + "\n Discount Rate=" + discount.ToString(), "Rental Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void opt1_CheckedChanged(object sender, EventArgs e)
        {
            check = opt1.TabIndex;
        }

        private void opt2_CheckedChanged(object sender, EventArgs e)
        {
            check = opt2.TabIndex;
        }

        private void opt3_CheckedChanged(object sender, EventArgs e)
        {
            check = opt3.TabIndex;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
