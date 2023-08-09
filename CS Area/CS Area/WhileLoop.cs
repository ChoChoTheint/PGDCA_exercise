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
    public partial class WhileLoop : Form
    {
        public WhileLoop()
        {
            InitializeComponent();
        }

        private void clickBtn_Click(object sender, EventArgs e)
        {
            //while loop
            int i = 1;
            while(i <= 50)
            {
               txtBox.Text = txtBox.Text + "\r\n" + i.ToString();
               i++;
            }

           // DoWhile
           // int i = 1;
           // do
           // {
           //    txtBox.Text = txtBox.Text + "\r\n" + i.ToString();
           //     i++;
           // } while (i <= 50);

          //  ForLoop
          //  for(int i =1;i<= 50;i++)
           // {
           //     txtBox.Text = txtBox.Text + "\r\n" + i.ToString();
           // }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
