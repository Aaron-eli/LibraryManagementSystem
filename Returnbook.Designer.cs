namespace Library_system
{
    partial class Returnbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Returnbook));
            panel1 = new Panel();
            btnExit = new Button();
            btnRefresh = new Button();
            txtSearchBorrower = new Button();
            txtBorrowerName = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnCancel = new Button();
            btnReturn = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtBookIssue = new TextBox();
            txtBookName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(txtSearchBorrower);
            panel1.Controls.Add(txtBorrowerName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 511);
            panel1.TabIndex = 0;
            panel1.UseWaitCursor = true;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(150, 299);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 32);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.UseWaitCursor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(46, 299);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 32);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.UseWaitCursor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtSearchBorrower
            // 
            txtSearchBorrower.FlatStyle = FlatStyle.Popup;
            txtSearchBorrower.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearchBorrower.Location = new Point(64, 199);
            txtSearchBorrower.Name = "txtSearchBorrower";
            txtSearchBorrower.Size = new Size(144, 40);
            txtSearchBorrower.TabIndex = 3;
            txtSearchBorrower.Text = "Search Borrower";
            txtSearchBorrower.UseVisualStyleBackColor = true;
            txtSearchBorrower.UseWaitCursor = true;
            txtSearchBorrower.Click += txtSearchBorrower_Click;
            // 
            // txtBorrowerName
            // 
            txtBorrowerName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBorrowerName.Location = new Point(46, 152);
            txtBorrowerName.Name = "txtBorrowerName";
            txtBorrowerName.Size = new Size(179, 24);
            txtBorrowerName.TabIndex = 2;
            txtBorrowerName.UseWaitCursor = true;
            txtBorrowerName.TextChanged += txtBorrowerName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(64, 129);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 1;
            label1.Text = "Borrower Name";
            label1.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(64, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(288, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(778, 350);
            dataGridView1.TabIndex = 1;
            dataGridView1.UseWaitCursor = true;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnReturn);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(txtBookIssue);
            panel2.Controls.Add(txtBookName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(288, 368);
            panel2.Name = "panel2";
            panel2.Size = new Size(778, 155);
            panel2.TabIndex = 2;
            panel2.UseWaitCursor = true;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightSalmon;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(438, 87);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.UseWaitCursor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnReturn
            // 
            btnReturn.FlatStyle = FlatStyle.Popup;
            btnReturn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.Location = new Point(438, 51);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(75, 23);
            btnReturn.TabIndex = 6;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.UseWaitCursor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(185, 87);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 22);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.UseWaitCursor = true;
            // 
            // txtBookIssue
            // 
            txtBookIssue.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBookIssue.Location = new Point(185, 52);
            txtBookIssue.Name = "txtBookIssue";
            txtBookIssue.Size = new Size(200, 22);
            txtBookIssue.TabIndex = 4;
            txtBookIssue.UseWaitCursor = true;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(185, 14);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(200, 22);
            txtBookName.TabIndex = 3;
            txtBookName.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 14);
            label4.Name = "label4";
            label4.Size = new Size(88, 16);
            label4.TabIndex = 2;
            label4.Text = "Book Name";
            label4.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 91);
            label3.Name = "label3";
            label3.Size = new Size(129, 16);
            label3.TabIndex = 1;
            label3.Text = "Book Return Date";
            label3.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 58);
            label2.Name = "label2";
            label2.Size = new Size(125, 16);
            label2.TabIndex = 0;
            label2.Text = "Book Issue Date ";
            label2.UseWaitCursor = true;
            // 
            // Returnbook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1078, 535);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Returnbook";
            Text = "Returnbook";
            UseWaitCursor = true;
            Load += Returnbook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button txtSearchBorrower;
        private TextBox txtBorrowerName;
        private Button btnExit;
        private Button btnRefresh;
        private TextBox txtBookIssue;
        private TextBox txtBookName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnCancel;
        private Button btnReturn;
        private DateTimePicker dateTimePicker1;
    }
}