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
    public partial class Using_ComboBox_and_ListBox : Form
    {
        public Using_ComboBox_and_ListBox()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listSubject.Items.Clear();
            if (cboSubject.Text == "Semester I")
            {
                listSubject.Items.Add("Computer Concept");
                listSubject.Items.Add("Simple Program Design");
                listSubject.Items.Add("Information System");
                listSubject.Items.Add("Web Technology");
            }
            else
            {
                listSubject.Items.Add("Networking");
                listSubject.Items.Add("C++");
                listSubject.Items.Add("Database Management System");
                listSubject.Items.Add("System Analysis and Design");
            }

        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            listSubject.Items.Clear();
        }

        private void clsBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
