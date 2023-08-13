namespace Library_system
{
    partial class ViewBorrowerInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBorrowerInformation));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtSearchBorrower = new TextBox();
            btnRefresh = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtBookBorrowed = new TextBox();
            txtBContact = new TextBox();
            txtBName = new TextBox();
            txtBID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(953, 131);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(542, 53);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 2;
            label2.Text = "Borrower";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(542, 28);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 1;
            label1.Text = "View";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(302, -22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 139);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 1;
            label3.Text = "BorrowerID";
            // 
            // txtSearchBorrower
            // 
            txtSearchBorrower.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearchBorrower.Location = new Point(354, 139);
            txtSearchBorrower.Name = "txtSearchBorrower";
            txtSearchBorrower.Size = new Size(179, 25);
            txtSearchBorrower.TabIndex = 2;
            txtSearchBorrower.TextChanged += txtSearchBorrower_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(554, 136);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(953, 208);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(txtBookBorrowed);
            panel2.Controls.Add(txtBContact);
            panel2.Controls.Add(txtBName);
            panel2.Controls.Add(txtBID);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(5, 379);
            panel2.Name = "panel2";
            panel2.Size = new Size(949, 181);
            panel2.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(816, 134);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 37);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(715, 134);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 37);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(618, 134);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 37);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtBookBorrowed
            // 
            txtBookBorrowed.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookBorrowed.Location = new Point(700, 82);
            txtBookBorrowed.Name = "txtBookBorrowed";
            txtBookBorrowed.Size = new Size(180, 25);
            txtBookBorrowed.TabIndex = 7;
            // 
            // txtBContact
            // 
            txtBContact.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBContact.Location = new Point(700, 23);
            txtBContact.Name = "txtBContact";
            txtBContact.Size = new Size(180, 25);
            txtBContact.TabIndex = 6;
            // 
            // txtBName
            // 
            txtBName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBName.Location = new Point(254, 82);
            txtBName.Name = "txtBName";
            txtBName.Size = new Size(180, 25);
            txtBName.TabIndex = 5;
            // 
            // txtBID
            // 
            txtBID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBID.Location = new Point(254, 23);
            txtBID.Name = "txtBID";
            txtBID.Size = new Size(180, 25);
            txtBID.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(549, 82);
            label7.Name = "label7";
            label7.Size = new Size(117, 21);
            label7.TabIndex = 3;
            label7.Text = "Book Borrowed";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(549, 26);
            label6.Name = "label6";
            label6.Size = new Size(132, 21);
            label6.TabIndex = 2;
            label6.Text = "Borrower Contact";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(136, 85);
            label5.Name = "label5";
            label5.Size = new Size(121, 21);
            label5.TabIndex = 1;
            label5.Text = "Borrower Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(136, 26);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 0;
            label4.Text = "Borrower ID";
            // 
            // ViewBorrowerInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(970, 572);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(btnRefresh);
            Controls.Add(txtSearchBorrower);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "ViewBorrowerInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewBorrowerInformation";
            Load += ViewBorrowerInformation_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtSearchBorrower;
        private Button btnRefresh;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtBookBorrowed;
        private TextBox txtBContact;
        private TextBox txtBName;
        private TextBox txtBID;
        private Label label7;
    }
}