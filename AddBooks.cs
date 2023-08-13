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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookAuthorName.Text != "" && txtBookTitle.Text != "" && txtBookAvailability.Text != "" && txtBookGenre.Text != "" && txtBookId.Text != "" && txtIsbn.Text != "")
            {



                String BookId = txtBookId.Text;
                String BookTitle = txtBookTitle.Text;
                String BookGenre = txtBookGenre.Text;
                String BookAvailability = txtBookAvailability.Text;
                String BookAuthor = txtBookAuthorName.Text;
                String ISBN = txtIsbn.Text;


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = BOIMAH-G1187\\SQLEXPRESS02 ; database=librarySystem;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into Book (BookId,BookTitle,BookAuthor,BookGenre,BookAvailability,ISBN) values ('" + BookId + "', '" + BookTitle + "', '" + BookAuthor + "', '" + BookGenre + "', '" + BookAvailability + "', '" + ISBN + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Save.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookTitle.Clear();
                txtBookAuthorName.Clear();
                txtBookAvailability.Clear();
                txtBookGenre.Clear();
                txtBookId.Clear();
                txtIsbn.Clear();
            }
            else
            {
                MessageBox.Show("Empty Field NOT Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Sure? This will DELETE your Unsaved DATA.", "Are you Sure?",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            this.Close();
        }
    }
}
