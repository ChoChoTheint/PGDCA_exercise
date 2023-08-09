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
    public partial class LastDayOfMonth : Form
    {
        public LastDayOfMonth()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            int months, year;
            months = int.Parse(comboBoxMonth.Text);
            year = int.Parse(txtYear.Text);

            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                switch (months)
                {
                    case 1: MessageBox.Show("The last day of Jan"+"="+31, "Leap Year", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 2: MessageBox.Show("The last day of Fec" + "=" + 29, "Leap Year", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 3: MessageBox.Show("The last day of Mar" + "=" + 31, "Leap Year", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 4: MessageBox.Show("The last day of Apr" + "=" + 30, "Leap Year", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 5: MessageBox.Show("The last day of May" + "=" + 31, "Leap Year", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 6: MessageBox.Show("The last day of June" + "=" + 30, "Leap Year", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 7: MessageBox.Show("The last day of July" + "=" + 31, "Leap Year", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 8: MessageBox.Show("The last day of Aug" + "=" + 31, "Leap Year", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 9: MessageBox.Show("The last day of Sept" + "=" + 30, "Leap Year", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 10: MessageBox.Show("The last day of Oct" + "=" + 31, "Leap Year", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 11: MessageBox.Show("The last day of Nov" + "=" + 30, "Leap Year", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 12: MessageBox.Show("The last day of Dec" + "=" + 31, "Leap Year", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                }
            }
            else
            {
                switch (months)
                {
                    case 1: MessageBox.Show("The last day of Jan" + "=" + 31, "Leap Year", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 2: MessageBox.Show("The last day of Fec" + "=" + 28, "Leap Year", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 3: MessageBox.Show("The last day of Mar" + "=" + 31, "Leap Year", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 4: MessageBox.Show("The last day of Apr" + "=" + 30, "Leap Year", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 5: MessageBox.Show("The last day of May" + "=" + 31, "Leap Year", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 6: MessageBox.Show("The last day of June" + "=" + 30, "Leap Year", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 7: MessageBox.Show("The last day of July" + "=" + 31, "Leap Year", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 8: MessageBox.Show("The last day of Aug" + "=" + 31, "Leap Year", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 9: MessageBox.Show("The last day of Sept" + "=" + 30, "Leap Year", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 10: MessageBox.Show("The last day of Oct" + "=" + 31, "Leap Year", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 11: MessageBox.Show("The last day of Nov" + "=" + 30, "Leap Year", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 12: MessageBox.Show("The last day of Dec" + "=" + 31, "Leap Year", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                }
            }

        }
           
    }
}
