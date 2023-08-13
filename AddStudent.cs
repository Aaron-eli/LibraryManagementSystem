using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_system
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBorrowerID.Clear();
            txtBorrowName.Clear();
            txtBorrowerContact.Clear();
            txtBookBorrowed.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBorrowerID.Text != "" && txtBorrowName.Text != "" && txtBorrowerContact.Text != "" && txtBookBorrowed.Text != "")
            {



                Int64 borrowerId = Int64.Parse(txtBorrowerID.Text);
                String borrwerName = txtBorrowName.Text;
                Int64 borrowerContact = Int64.Parse(txtBorrowerContact.Text);
                Int64 bookBorrowed = Int64.Parse(txtBookBorrowed.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = BOIMAH-G1187\\SQLEXPRESS02; database=librarySystem;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into Borrower(BorrowerID,Name,ContactInfo,TotalBooksBorrowed) values (" + borrowerId + ",'" + borrwerName + "'," + borrowerContact + "," + bookBorrowed + ")";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Save!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Fill Empty Fields","Suggest",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
