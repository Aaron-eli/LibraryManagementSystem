namespace Library_system
{
    partial class ViewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtBname = new TextBox();
            btnRefresh = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btncancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtISBN = new TextBox();
            txtBId = new TextBox();
            txtBavailability = new TextBox();
            txtBgenre = new TextBox();
            txtAname = new TextBox();
            txtBtitle = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(969, 106);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(562, 43);
            label1.Name = "label1";
            label1.Size = new Size(119, 29);
            label1.TabIndex = 1;
            label1.Text = "View Book";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(406, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(294, 130);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 1;
            label2.Text = "Book Name";
            // 
            // txtBname
            // 
            txtBname.Location = new Point(416, 128);
            txtBname.Name = "txtBname";
            txtBname.Size = new Size(183, 27);
            txtBname.TabIndex = 2;
            txtBname.TextChanged += txtBname_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(605, 124);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 34);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(946, 292);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(btncancel);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(txtISBN);
            panel2.Controls.Add(txtBId);
            panel2.Controls.Add(txtBavailability);
            panel2.Controls.Add(txtBgenre);
            panel2.Controls.Add(txtAname);
            panel2.Controls.Add(txtBtitle);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 467);
            panel2.Name = "panel2";
            panel2.Size = new Size(946, 270);
            panel2.TabIndex = 5;
            // 
            // btncancel
            // 
            btncancel.FlatStyle = FlatStyle.Popup;
            btncancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btncancel.Location = new Point(803, 223);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(75, 33);
            btncancel.TabIndex = 14;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += button4_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(694, 223);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 33);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(581, 223);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 33);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(615, 147);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(237, 27);
            txtISBN.TabIndex = 11;
            // 
            // txtBId
            // 
            txtBId.Location = new Point(615, 78);
            txtBId.Name = "txtBId";
            txtBId.Size = new Size(237, 27);
            txtBId.TabIndex = 10;
            // 
            // txtBavailability
            // 
            txtBavailability.Location = new Point(615, 27);
            txtBavailability.Name = "txtBavailability";
            txtBavailability.Size = new Size(237, 27);
            txtBavailability.TabIndex = 9;
            txtBavailability.TextChanged += textBox5_TextChanged;
            // 
            // txtBgenre
            // 
            txtBgenre.Location = new Point(179, 149);
            txtBgenre.Name = "txtBgenre";
            txtBgenre.Size = new Size(219, 27);
            txtBgenre.TabIndex = 8;
            // 
            // txtAname
            // 
            txtAname.Location = new Point(179, 78);
            txtAname.Name = "txtAname";
            txtAname.Size = new Size(219, 27);
            txtAname.TabIndex = 7;
            // 
            // txtBtitle
            // 
            txtBtitle.Location = new Point(179, 33);
            txtBtitle.Name = "txtBtitle";
            txtBtitle.Size = new Size(219, 27);
            txtBtitle.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(484, 149);
            label8.Name = "label8";
            label8.Size = new Size(44, 21);
            label8.TabIndex = 5;
            label8.Text = "ISBN";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(484, 81);
            label7.Name = "label7";
            label7.Size = new Size(58, 21);
            label7.TabIndex = 4;
            label7.Text = "BookId";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(484, 33);
            label6.Name = "label6";
            label6.Size = new Size(125, 21);
            label6.TabIndex = 3;
            label6.Text = "Book Availability";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(37, 149);
            label5.Name = "label5";
            label5.Size = new Size(91, 21);
            label5.TabIndex = 2;
            label5.Text = "Book Genre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(37, 85);
            label4.Name = "label4";
            label4.Size = new Size(143, 21);
            label4.TabIndex = 1;
            label4.Text = "Book Author Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(37, 40);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 0;
            label3.Text = "Book Title";
            // 
            // ViewBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 198, 128);
            ClientSize = new Size(970, 749);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(btnRefresh);
            Controls.Add(txtBname);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "ViewBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewBook";
            Load += ViewBook_Load;
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
        private Label label1;
        private Label label2;
        private TextBox txtBname;
        private Button btnRefresh;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button btncancel;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtISBN;
        private TextBox txtBprice;
        private TextBox txtBavailability;
        private TextBox txtBgenre;
        private TextBox txtAname;
        private TextBox txtBtitle;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtBId;
    }
}