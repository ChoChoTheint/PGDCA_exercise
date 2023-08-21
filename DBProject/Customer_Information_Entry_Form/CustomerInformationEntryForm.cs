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
    public partial class CustomerInformationEntryForm : Form
    {
        public CustomerInformationEntryForm()
        {
            InitializeComponent();
        }
        SqlConnection consql;
        string str;
        DataSet Dset;
        //void AutoID()
        //{
        //    string CName;
        //    int CID;
        //    SqlDataAdapter ad = new SqlDataAdapter("Select CustID From tblCustomer ORDER BY CustID", consql);
        //    DataSet ds = new DataSet();
        //    ad.Fill(ds);
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        CName = ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1][0].ToString();
        //        CID = int.Parse(CName.Substring(2, (CName.Length - 2)));
        //        txtCustID.Text = "C_" + ((CID + 1).ToString("0000000"));  
        //    }
        //    else
        //    {
        //        txtCustID.Text = "C_0000001";
        //    }
        //}
        void AutoID()
        {
            int CID = 1; // Initialize CID with 1 as a fallback

            SqlDataAdapter ad = new SqlDataAdapter("SELECT CustID FROM tblCustomer ORDER BY CustID DESC", consql);
            DataSet ds = new DataSet();
            ad.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                string lastCustID = ds.Tables[0].Rows[0]["CustID"].ToString();

                // Try to parse the numeric part of the last customer ID
                if (int.TryParse(lastCustID.Substring(2), out CID))
                {
                    CID++; // Increment the CID
                }
            }

            txtCustID.Text = "C_" + CID.ToString("0000000");
        }

        void ClearText()
        {
            txtCustID.Text = "";
            txtCName.Text = "";
            txtNRC.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
        }
        private void FillData()
        {
            string query = "Select * From tblCustomer";
            SqlDataAdapter adapter = new SqlDataAdapter(query, consql);
            Dset = new DataSet();
            adapter.Fill(Dset);
            dgCustomer.DataSource = Dset.Tables[0];

            dgCustomer.Columns[0].HeaderText = "Customer ID";
            dgCustomer.Columns[1].HeaderText = "Customer Name";
            dgCustomer.Columns[2].HeaderText = "NRC";
            dgCustomer.Columns[3].HeaderText = "Address";
            dgCustomer.Columns[4].HeaderText = "Phone";

            dgCustomer.Columns[0].Width = 120;
            dgCustomer.Columns[1].Width = 150;
            dgCustomer.Columns[2].Width = 120;
            dgCustomer.Columns[3].Width = 200;
            dgCustomer.Columns[4].Width = 120;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            str = "Data Source=DESKTOP-NM8K2IA;Initial Catalog=tbTest;User ID=sa;Password=p@ssw0rd";
            consql = new SqlConnection(str);
            consql.Open();
            FillData();
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strInsert = "Insert Into tblCustomer Values ('"+txtCustID.Text+"','"+txtCName.Text+ "','" +txtNRC.Text + "','" +txtAddress.Text + "','" +txtPhone.Text + "')";
            SqlCommand mycmd = new SqlCommand(strInsert, consql);
            mycmd.ExecuteNonQuery();
            MessageBox.Show("Finish save customer information", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillData();
         
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearText();
            AutoID();
        }

       

        private void btnDelete_Click(object sender, EventArgs e)
        {
        string str = "Delete from tblCustomer Where CustID='"+txtCustID.Text+"'";
        SqlCommand mycmd = new SqlCommand(str,consql);
        mycmd.ExecuteNonQuery();
        MessageBox.Show("Finish delete customer information ","Delete Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        FillData();
        ClearText();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgCustomer.CurrentRow.Index;
            txtCustID.Text = Dset.Tables[0].Rows[i][0].ToString();
            txtCName.Text = Dset.Tables[0].Rows[i][1].ToString();
            txtNRC.Text = Dset.Tables[0].Rows[i][2].ToString();
            txtAddress.Text = Dset.Tables[0].Rows[i][3].ToString();
            txtPhone.Text = Dset.Tables[0].Rows[i][4].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string str = "Update tblCustomer Set CustName='"+txtCName.Text+"',NRC='"+txtNRC.Text+"',Address='"+txtAddress.Text+"',Phone='"+txtPhone.Text+"' Where CustID='"+txtCustID.Text+"'";
            SqlCommand mycmd = new SqlCommand(str,consql);
            mycmd.ExecuteNonQuery();

            MessageBox.Show("Finish update customer information ","Update Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            FillData();
        }
    }
}
