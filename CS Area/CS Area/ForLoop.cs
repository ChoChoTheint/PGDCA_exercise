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
    public partial class ForLoop : Form
    {
        public ForLoop()
        {
            InitializeComponent();
        }

        private void click_Click(object sender, EventArgs e)
        {
            for(int i= 0;i<10;i++)
            {
                txrNumber.Text = txrNumber.Text + "\r\n" + i.ToString();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
