using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Customer_Information_Entry_Form
{
    public partial class FillDatatoComboBoxFromTable : Form
    {
        public FillDatatoComboBoxFromTable()
        {
            InitializeComponent();
        }
        SqlConnection consql;
        string constr;
        private void FillDatatoComboBoxFromTable_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-NM8K2IA;Initial Catalog=tbTest;User ID=sa;Password=p@ssw0rd";
            consql = new SqlConnection(constr);
            consql.Open();
            FillCustomer();
        }
        void FillCustomer()
        {
            SqlDataAdapter daCustomer = new SqlDataAdapter("Select * From tblCustomer", consql);
            DataSet dsCustomer = new DataSet();
            DataTable dt;
            daCustomer.Fill(dsCustomer, "Customer");
            dt = dsCustomer.Tables["Customer"];
            cboCustID.DataSource = dt;
            cboCustID.DisplayMember = dt.Columns["CustID"].ToString();
        }

        private void cboCustID_Leave(object sender, EventArgs e)
        {
            string str = "Select CustName From tblCustomer Where CustID='" + cboCustID.Text + "'";
            SqlDataAdapter adcustomer = new SqlDataAdapter(str, consql);
            DataSet dscustomer = new DataSet();
            adcustomer.Fill(dscustomer, "CName");
            txtCustName.Text = dscustomer.Tables["CName"].Rows[0][0].ToString();
            cboCustID.Focus();
        }
    }
}
