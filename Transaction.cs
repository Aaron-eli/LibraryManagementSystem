using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_system
{
    public partial class Transaction : Form
    {
        private ComboBox ComboBoxBook;


        public Transaction()
        {
            InitializeComponent();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = BOIMAH-G1187\\SQLEXPRESS02; database=librarySystem;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select BookID from Transaction", con);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    ComboBoxBook.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
            con.Close();
        }
        int count;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtTransaction.Text != "")
            {
                String eid = txtTransaction.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = BOIMAH-G1187\\SQLEXPRESS02; database=librarySystem;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = Select * from Transaction where BookId = '" + eid + "'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet Ds = new DataSet();
                DA.Fill(Ds);

                //==============================================

                cmd.CommandText = Select count(BorrowerID) from Borrower where BorrowerID = '" + eid + "'and Returndate is null";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                DataSet Ds1 = new DataSet();
                DA.Fill(Ds1);


                count = int.Parse(Ds1.Tables[0].Rows[0][0].ToString());
                //--------------------------------------------------------

                if (Ds.Tables[0].Rows.Count != 0)
                {
                    txtBookid.Text = Ds.Tables[0].Rows[0][1].ToString();
                    txtBorrowDate.Text = Ds.Tables[0].Rows[0][2].ToString();
                    txtBorrowId.Text = Ds.Tables[0].Rows[0][3].ToString();
                    txtReturnDate.Text = Ds.Tables[0].Rows[0][4].ToString();
                    txtTransaction.Text = Ds.Tables[0].Rows[0][5].ToString();
                    txttransId.Text = Ds.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    txtBookid.Clear();
                    txtBorrowDate.Clear();
                    txtBorrowId.Clear();
                    txtReturnDate.Clear();
                    txtTransaction.Clear();
                    txttransId.Clear();
                    MessageBox.Show("Invalid TransactionID", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (txtBookid.Text != "") ;
            {
                if (ComboBoxBook.SelectedIndex != -1 && count <= 2)
                {
                    String Bookid = txtTransaction.Text;
                    String ISBN = txttransId.Text;
                    String BorrowId = txtBorrowId.Text;
                    String ReturnDate = txtReturnDate.Text;
                    String TransactionId = txtTransaction.Text;
                    String Borrowdate = txtBorrowDate.Text;

                    String eid = txtTransaction.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = BOIMAH-G1187\\SQLEXPRESS02; database=librarySystem;integrated security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    con.Open();
                    cmd.CommandText = cmd.CommandText INSERT INTO Book(BookID, Title, Author, ISBN, Genre, Availability);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Book Issued", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Select Book. OR Maximum number of Book has Been Issued", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Enter valid Transaction ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTransaction_TextChanged(object sender, EventArgs e)
        {
            if (txtTransaction.Text == "")
            {

                txtBookid.Clear();
                txtBorrowDate.Clear();
                txtBorrowId.Clear();
                txtReturnDate.Clear();
                txttransId.Clear();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtTransaction.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
