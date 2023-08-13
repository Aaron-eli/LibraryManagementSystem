namespace Library_system
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnExit = new Button();
            btnSave = new Button();
            btnRefresh = new Button();
            txtBookBorrowed = new TextBox();
            txtBorrowerContact = new TextBox();
            txtBorrowName = new TextBox();
            txtBorrowerID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 77);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(370, 25);
            label1.Name = "label1";
            label1.Size = new Size(139, 25);
            label1.TabIndex = 1;
            label1.Text = "Add Borrower";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(304, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1, 74);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(264, 354);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(txtBookBorrowed);
            panel2.Controls.Add(txtBorrowerContact);
            panel2.Controls.Add(txtBorrowName);
            panel2.Controls.Add(txtBorrowerID);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(262, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(423, 354);
            panel2.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(321, 294);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 37);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(221, 294);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(85, 37);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save Info";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(125, 294);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 37);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtBookBorrowed
            // 
            txtBookBorrowed.Location = new Point(198, 225);
            txtBookBorrowed.Name = "txtBookBorrowed";
            txtBookBorrowed.Size = new Size(168, 27);
            txtBookBorrowed.TabIndex = 7;
            // 
            // txtBorrowerContact
            // 
            txtBorrowerContact.Location = new Point(198, 165);
            txtBorrowerContact.Name = "txtBorrowerContact";
            txtBorrowerContact.Size = new Size(168, 27);
            txtBorrowerContact.TabIndex = 6;
            // 
            // txtBorrowName
            // 
            txtBorrowName.Location = new Point(198, 92);
            txtBorrowName.Name = "txtBorrowName";
            txtBorrowName.Size = new Size(168, 27);
            txtBorrowName.TabIndex = 5;
            // 
            // txtBorrowerID
            // 
            txtBorrowerID.Location = new Point(198, 40);
            txtBorrowerID.Name = "txtBorrowerID";
            txtBorrowerID.Size = new Size(168, 27);
            txtBorrowerID.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(19, 225);
            label5.Name = "label5";
            label5.Size = new Size(160, 21);
            label5.TabIndex = 3;
            label5.Text = "Total Books Borrowed";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(19, 167);
            label4.Name = "label4";
            label4.Size = new Size(132, 21);
            label4.TabIndex = 2;
            label4.Text = "Borrower Contact";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 98);
            label3.Name = "label3";
            label3.Size = new Size(121, 21);
            label3.TabIndex = 1;
            label3.Text = "Borrower Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 40);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 0;
            label2.Text = "BorrowerID";
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 428);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudent";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnExit;
        private Button btnSave;
        private Button btnRefresh;
        private TextBox txtBookBorrowed;
        private TextBox txtBorrowerContact;
        private TextBox txtBorrowName;
        private TextBox txtBorrowerID;
    }
}