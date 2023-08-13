namespace Library_system
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            menuStrip1 = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            addNaToolStripMenuItem = new ToolStripMenuItem();
            veiwBooksToolStripMenuItem = new ToolStripMenuItem();
            booksToolStripMenuItem1 = new ToolStripMenuItem();
            booksToolStripMenuItem2 = new ToolStripMenuItem();
            booksToolStripMenuItem3 = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            addStudentToolStripMenuItem = new ToolStripMenuItem();
            viewStudentsDetailToolStripMenuItem = new ToolStripMenuItem();
            issueBooksToolStripMenuItem = new ToolStripMenuItem();
            returnBooksToolStripMenuItem = new ToolStripMenuItem();
            completeBookDetailsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Wheat;
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, studentToolStripMenuItem, issueBooksToolStripMenuItem, returnBooksToolStripMenuItem, completeBookDetailsToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1096, 58);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNaToolStripMenuItem, veiwBooksToolStripMenuItem, booksToolStripMenuItem1, booksToolStripMenuItem2, booksToolStripMenuItem3 });
            booksToolStripMenuItem.Image = (Image)resources.GetObject("booksToolStripMenuItem.Image");
            booksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(111, 54);
            booksToolStripMenuItem.Text = "Books";
            // 
            // addNaToolStripMenuItem
            // 
            addNaToolStripMenuItem.Image = (Image)resources.GetObject("addNaToolStripMenuItem.Image");
            addNaToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNaToolStripMenuItem.Name = "addNaToolStripMenuItem";
            addNaToolStripMenuItem.Size = new Size(212, 56);
            addNaToolStripMenuItem.Text = "Add New Book";
            addNaToolStripMenuItem.Click += addNaToolStripMenuItem_Click;
            // 
            // veiwBooksToolStripMenuItem
            // 
            veiwBooksToolStripMenuItem.Image = (Image)resources.GetObject("veiwBooksToolStripMenuItem.Image");
            veiwBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            veiwBooksToolStripMenuItem.Name = "veiwBooksToolStripMenuItem";
            veiwBooksToolStripMenuItem.Size = new Size(212, 56);
            veiwBooksToolStripMenuItem.Text = "Veiw Books";
            veiwBooksToolStripMenuItem.Click += veiwBooksToolStripMenuItem_Click;
            // 
            // booksToolStripMenuItem1
            // 
            booksToolStripMenuItem1.Name = "booksToolStripMenuItem1";
            booksToolStripMenuItem1.Size = new Size(212, 56);
            booksToolStripMenuItem1.Text = "Books";
            booksToolStripMenuItem1.Click += booksToolStripMenuItem1_Click;
            // 
            // booksToolStripMenuItem2
            // 
            booksToolStripMenuItem2.Name = "booksToolStripMenuItem2";
            booksToolStripMenuItem2.Size = new Size(212, 56);
            booksToolStripMenuItem2.Text = "Books";
            // 
            // booksToolStripMenuItem3
            // 
            booksToolStripMenuItem3.Name = "booksToolStripMenuItem3";
            booksToolStripMenuItem3.Size = new Size(212, 56);
            booksToolStripMenuItem3.Text = "Books";
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.BackColor = Color.OldLace;
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addStudentToolStripMenuItem, viewStudentsDetailToolStripMenuItem });
            studentToolStripMenuItem.Image = (Image)resources.GetObject("studentToolStripMenuItem.Image");
            studentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(132, 54);
            studentToolStripMenuItem.Text = "Borrower";
            // 
            // addStudentToolStripMenuItem
            // 
            addStudentToolStripMenuItem.Image = (Image)resources.GetObject("addStudentToolStripMenuItem.Image");
            addStudentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            addStudentToolStripMenuItem.Size = new Size(253, 56);
            addStudentToolStripMenuItem.Text = "Add Borrower";
            addStudentToolStripMenuItem.Click += addStudentToolStripMenuItem_Click;
            // 
            // viewStudentsDetailToolStripMenuItem
            // 
            viewStudentsDetailToolStripMenuItem.Image = (Image)resources.GetObject("viewStudentsDetailToolStripMenuItem.Image");
            viewStudentsDetailToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewStudentsDetailToolStripMenuItem.Name = "viewStudentsDetailToolStripMenuItem";
            viewStudentsDetailToolStripMenuItem.Size = new Size(253, 56);
            viewStudentsDetailToolStripMenuItem.Text = "View Borrower Detail";
            viewStudentsDetailToolStripMenuItem.Click += viewStudentsDetailToolStripMenuItem_Click;
            // 
            // issueBooksToolStripMenuItem
            // 
            issueBooksToolStripMenuItem.BackColor = Color.Wheat;
            issueBooksToolStripMenuItem.Image = (Image)resources.GetObject("issueBooksToolStripMenuItem.Image");
            issueBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            issueBooksToolStripMenuItem.Name = "issueBooksToolStripMenuItem";
            issueBooksToolStripMenuItem.Size = new Size(146, 54);
            issueBooksToolStripMenuItem.Text = "Transaction";
            issueBooksToolStripMenuItem.Click += issueBooksToolStripMenuItem_Click;
            // 
            // returnBooksToolStripMenuItem
            // 
            returnBooksToolStripMenuItem.BackColor = Color.OldLace;
            returnBooksToolStripMenuItem.Image = (Image)resources.GetObject("returnBooksToolStripMenuItem.Image");
            returnBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            returnBooksToolStripMenuItem.Size = new Size(158, 54);
            returnBooksToolStripMenuItem.Text = "Return Books";
            returnBooksToolStripMenuItem.Click += returnBooksToolStripMenuItem_Click;
            // 
            // completeBookDetailsToolStripMenuItem
            // 
            completeBookDetailsToolStripMenuItem.Image = (Image)resources.GetObject("completeBookDetailsToolStripMenuItem.Image");
            completeBookDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            completeBookDetailsToolStripMenuItem.Name = "completeBookDetailsToolStripMenuItem";
            completeBookDetailsToolStripMenuItem.Size = new Size(224, 54);
            completeBookDetailsToolStripMenuItem.Text = "Complete Book Details";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.OldLace;
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(95, 54);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1096, 450);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem addNaToolStripMenuItem;
        private ToolStripMenuItem veiwBooksToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem addStudentToolStripMenuItem;
        private ToolStripMenuItem viewStudentsDetailToolStripMenuItem;
        private ToolStripMenuItem issueBooksToolStripMenuItem;
        private ToolStripMenuItem returnBooksToolStripMenuItem;
        private ToolStripMenuItem completeBookDetailsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem booksToolStripMenuItem1;
        private ToolStripMenuItem booksToolStripMenuItem2;
        private ToolStripMenuItem booksToolStripMenuItem3;
    }
}