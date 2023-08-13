namespace Library_system
{
    partial class AddBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooks));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            txtIsbn = new TextBox();
            txtBookId = new TextBox();
            txtBookAvailability = new TextBox();
            txtBookGenre = new TextBox();
            txtBookAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 348);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(681, 77);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(357, 26);
            label1.Name = "label1";
            label1.Size = new Size(110, 29);
            label1.TabIndex = 3;
            label1.Text = "Add Book";
            // 
            // panel2
            // 
            panel2.Location = new Point(229, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(446, 339);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 128);
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(txtIsbn);
            panel3.Controls.Add(txtBookId);
            panel3.Controls.Add(txtBookAvailability);
            panel3.Controls.Add(txtBookGenre);
            panel3.Controls.Add(txtBookAuthorName);
            panel3.Controls.Add(txtBookTitle);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(264, 78);
            panel3.Name = "panel3";
            panel3.Size = new Size(419, 348);
            panel3.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(301, 310);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(84, 25);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(187, 310);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(84, 25);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(187, 266);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(198, 27);
            txtIsbn.TabIndex = 11;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(191, 217);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(198, 27);
            txtBookId.TabIndex = 10;
            // 
            // txtBookAvailability
            // 
            txtBookAvailability.Location = new Point(191, 166);
            txtBookAvailability.Name = "txtBookAvailability";
            txtBookAvailability.Size = new Size(198, 27);
            txtBookAvailability.TabIndex = 9;
            // 
            // txtBookGenre
            // 
            txtBookGenre.Location = new Point(191, 117);
            txtBookGenre.Name = "txtBookGenre";
            txtBookGenre.Size = new Size(198, 27);
            txtBookGenre.TabIndex = 8;
            // 
            // txtBookAuthorName
            // 
            txtBookAuthorName.Location = new Point(191, 69);
            txtBookAuthorName.Name = "txtBookAuthorName";
            txtBookAuthorName.Size = new Size(198, 27);
            txtBookAuthorName.TabIndex = 7;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(191, 15);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(198, 27);
            txtBookTitle.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(24, 267);
            label7.Name = "label7";
            label7.Size = new Size(48, 23);
            label7.TabIndex = 5;
            label7.Text = "ISBN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(24, 218);
            label6.Name = "label6";
            label6.Size = new Size(67, 23);
            label6.TabIndex = 4;
            label6.Text = "BookID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(24, 170);
            label5.Name = "label5";
            label5.Size = new Size(144, 23);
            label5.TabIndex = 3;
            label5.Text = "Book Availability";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(24, 121);
            label4.Name = "label4";
            label4.Size = new Size(103, 23);
            label4.TabIndex = 2;
            label4.Text = "Book Genre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(24, 69);
            label3.Name = "label3";
            label3.Size = new Size(161, 23);
            label3.TabIndex = 1;
            label3.Text = "Book Author Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 15);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 0;
            label2.Text = "Book Title";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(264, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(89, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 428);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "AddBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBooks";
            Load += AddBooks_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtIsbn;
        private TextBox txtBookId;
        private TextBox txtBookAvailability;
        private TextBox txtBookGenre;
        private TextBox txtBookAuthorName;
        private TextBox txtBookTitle;
    }
}