using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library_system
{
    public partial class ViewBorrowerInformation : Form
    {
        public ViewBorrowerInformation()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchBorrower_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchBorrower.Text != "")
            {
                label1.Visible = false;
                Image image = Image.FromFile("C:\\Users\\HP\\Downloads\\Liberay Management System Icon and Images\\Liberay Management System\\search1.gif");
                pictureBox1.Image = image;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = BOIMAH-G1187\\SQLEXPRESS02; database=librarySystem;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Borrower where BorrowerID LIKE '" + txtSearchBorrower + "%' ";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
            else
            {
                label1.Visible = true;
                Image image = Image.FromFile("C:\\Users\\HP\\Downloads\\Liberay Management System Icon and Images\\Liberay Management System\\search.gif");
                pictureBox1.Image = image;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = BOIMAH-G1187\\SQLEXPRESS02; database=librarySystem;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Borrower";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
        }

        private void ViewBorrowerInformation_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = BOIMAH-G1187\\SQLEXPRESS02; database=librarySystem;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Borrower";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];
        }
        int BookID;
        //Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
#pragma warning disable CS8604 // Possible null reference argument.
                BookID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
#pragma warning restore CS8604 // Possible null reference argument.
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = BOIMAH-G1187\\SQLEXPRESS02; database=librarySystem;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Borrower where BorrowerID=" + BookID + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            //rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            //txtBId.Text = ds.Tables[0].Rows[0][0].ToString();
            txtBID.Text = ds.Tables[0].Rows[0][0].ToString();
            txtBName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtBContact.Text = ds.Tables[0].Rows[0][2].ToString();
            txtBookBorrowed.Text = ds.Tables[0].Rows[0][3].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Int64 BorrowerId = Int64.Parse(txtBID.Text);
            String Bname = txtBName.Text;
            Int64 Bcontact = Int64.Parse(txtBContact.Text);
            Int64 BookBorrowed = Int64.Parse(txtBookBorrowed.Text);

            if (MessageBox.Show("Data will Be Updated. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {



                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = BOIMAH-G1187\\SQLEXPRESS02; database=librarySystem;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Update Borrower set BorrowerID =" + BorrowerId + ", Name='" + Bname + "', ContactInfo=" + Bcontact + ", TotalBooksBorrowed=" + BookBorrowed + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                ViewBorrowerInformation_Load(this, null);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ViewBorrowerInformation_Load(this, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will Be Deleted. Confirm?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {



                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = BOIMAH-G1187\\SQLEXPRESS02; database=librarySystem;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from Borrower where BorrowerID=" + BookID + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                ViewBorrowerInformation_Load(this, null);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Unsaved Data will be Lost.","Are You Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
