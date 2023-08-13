namespace Library_system
{
    partial class Transaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnExit = new Button();
            btnRefresh = new Button();
            btnSearch = new Button();
            txtTransaction = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            txtBorrowId = new ComboBox();
            txttransId = new ComboBox();
            txtBookid = new ComboBox();
            btnIssueBook = new Button();
            txtReturnDate = new DateTimePicker();
            txtBorrowDate = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 129);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(415, 51);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 1;
            label1.Text = "Transaction";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(144, -33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(386, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txtTransaction);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(12, 141);
            panel2.Name = "panel2";
            panel2.Size = new Size(263, 359);
            panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(144, 294);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(80, 37);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(41, 294);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(85, 37);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(41, 215);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(183, 47);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search Borrower";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtTransaction
            // 
            txtTransaction.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTransaction.Location = new Point(28, 173);
            txtTransaction.Name = "txtTransaction";
            txtTransaction.Size = new Size(220, 25);
            txtTransaction.TabIndex = 2;
            txtTransaction.TextChanged += txtTransaction_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(56, 140);
            label2.Name = "label2";
            label2.Size = new Size(161, 30);
            label2.TabIndex = 1;
            label2.Text = "Transaction No";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(73, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 92);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(192, 255, 255);
            panel3.Controls.Add(txtBorrowId);
            panel3.Controls.Add(txttransId);
            panel3.Controls.Add(txtBookid);
            panel3.Controls.Add(btnIssueBook);
            panel3.Controls.Add(txtReturnDate);
            panel3.Controls.Add(txtBorrowDate);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(281, 141);
            panel3.Name = "panel3";
            panel3.Size = new Size(414, 359);
            panel3.TabIndex = 2;
            // 
            // txtBorrowId
            // 
            txtBorrowId.FormattingEnabled = true;
            txtBorrowId.Location = new Point(32, 118);
            txtBorrowId.Name = "txtBorrowId";
            txtBorrowId.Size = new Size(249, 28);
            txtBorrowId.TabIndex = 8;
            // 
            // txttransId
            // 
            txttransId.FormattingEnabled = true;
            txttransId.Location = new Point(32, 33);
            txttransId.Name = "txttransId";
            txttransId.Size = new Size(249, 28);
            txttransId.TabIndex = 6;
            // 
            // txtBookid
            // 
            txtBookid.FormattingEnabled = true;
            txtBookid.Location = new Point(32, 76);
            txtBookid.Name = "txtBookid";
            txtBookid.Size = new Size(249, 28);
            txtBookid.TabIndex = 12;
            // 
            // btnIssueBook
            // 
            btnIssueBook.FlatStyle = FlatStyle.Popup;
            btnIssueBook.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnIssueBook.Location = new Point(90, 247);
            btnIssueBook.Name = "btnIssueBook";
            btnIssueBook.Size = new Size(123, 49);
            btnIssueBook.TabIndex = 11;
            btnIssueBook.Text = "Issue Book";
            btnIssueBook.UseVisualStyleBackColor = true;
            btnIssueBook.Click += btnIssueBook_Click;
            // 
            // txtReturnDate
            // 
            txtReturnDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtReturnDate.Location = new Point(32, 203);
            txtReturnDate.Name = "txtReturnDate";
            txtReturnDate.Size = new Size(249, 27);
            txtReturnDate.TabIndex = 10;
            // 
            // txtBorrowDate
            // 
            txtBorrowDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtBorrowDate.Location = new Point(32, 161);
            txtBorrowDate.Name = "txtBorrowDate";
            txtBorrowDate.Size = new Size(249, 27);
            txtBorrowDate.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(32, 327);
            label8.Name = "label8";
            label8.Size = new Size(335, 20);
            label8.TabIndex = 5;
            label8.Text = "Maximum 3 Books can be ISSUED to 1 Student";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(299, 163);
            label7.Name = "label7";
            label7.Size = new Size(98, 20);
            label7.TabIndex = 4;
            label7.Text = "Borrow Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(303, 206);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 3;
            label6.Text = "Return Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(314, 121);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 2;
            label5.Text = "Borrow ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(330, 77);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 1;
            label4.Text = "Book ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(287, 36);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 0;
            label3.Text = "Transaction ID";
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(707, 512);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Transaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transaction";
            Load += Transaction_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox2;
        private Button btnSearch;
        private TextBox txtTransaction;
        private Button btnExit;
        private Button btnRefresh;
        private Panel panel3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label8;
        private Label label7;
        private DateTimePicker txtReturnDate;
        private DateTimePicker txtBorrowDate;
        private Button btnIssueBook;
        private ComboBox txtBookid;
        private ComboBox txttransId;
        private ComboBox txtBorrowId;
    }
}