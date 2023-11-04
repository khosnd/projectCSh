namespace projectCSh
{
    partial class libriran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(libriran));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button_RemoveBook = new System.Windows.Forms.Button();
            this.button_ViewBook = new System.Windows.Forms.Button();
            this.button_AddBook = new System.Windows.Forms.Button();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBookStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllBorrowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Image = global::projectCSh.Properties.Resources.HD_wallpaper_plain_brown_background_brown_aesthetic;
            this.label1.Location = new System.Drawing.Point(232, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose what you want";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projectCSh.Properties.Resources._876207_200;
            this.pictureBox1.Location = new System.Drawing.Point(93, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::projectCSh.Properties.Resources._876204_200;
            this.pictureBox2.Location = new System.Drawing.Point(550, 154);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::projectCSh.Properties.Resources._677296_books_512x512;
            this.pictureBox3.Location = new System.Drawing.Point(302, 274);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(182, 123);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // button_RemoveBook
            // 
            this.button_RemoveBook.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button_RemoveBook.Location = new System.Drawing.Point(550, 287);
            this.button_RemoveBook.Name = "button_RemoveBook";
            this.button_RemoveBook.Size = new System.Drawing.Size(140, 23);
            this.button_RemoveBook.TabIndex = 4;
            this.button_RemoveBook.Text = "Remove Book";
            this.button_RemoveBook.UseVisualStyleBackColor = true;
            this.button_RemoveBook.Click += new System.EventHandler(this.button_RemoveBook_Click);
            // 
            // button_ViewBook
            // 
            this.button_ViewBook.Location = new System.Drawing.Point(302, 403);
            this.button_ViewBook.Name = "button_ViewBook";
            this.button_ViewBook.Size = new System.Drawing.Size(182, 23);
            this.button_ViewBook.TabIndex = 5;
            this.button_ViewBook.Text = "View All Books";
            this.button_ViewBook.UseVisualStyleBackColor = true;
            this.button_ViewBook.Click += new System.EventHandler(this.button_ViewBook_Click);
            // 
            // button_AddBook
            // 
            this.button_AddBook.Location = new System.Drawing.Point(93, 285);
            this.button_AddBook.Name = "button_AddBook";
            this.button_AddBook.Size = new System.Drawing.Size(150, 23);
            this.button_AddBook.TabIndex = 6;
            this.button_AddBook.Text = "Add Book";
            this.button_AddBook.UseVisualStyleBackColor = true;
            this.button_AddBook.Click += new System.EventHandler(this.button_AddBook_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllBookToolStripMenuItem,
            this.changeBookStateToolStripMenuItem});
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.bookToolStripMenuItem.Text = "Book";
            // 
            // viewAllBookToolStripMenuItem
            // 
            this.viewAllBookToolStripMenuItem.Name = "viewAllBookToolStripMenuItem";
            this.viewAllBookToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.viewAllBookToolStripMenuItem.Text = "View All Book";
            // 
            // changeBookStateToolStripMenuItem
            // 
            this.changeBookStateToolStripMenuItem.Name = "changeBookStateToolStripMenuItem";
            this.changeBookStateToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.changeBookStateToolStripMenuItem.Text = "Change Book state";
            // 
            // borrowerToolStripMenuItem
            // 
            this.borrowerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllBorrowerToolStripMenuItem});
            this.borrowerToolStripMenuItem.Name = "borrowerToolStripMenuItem";
            this.borrowerToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.borrowerToolStripMenuItem.Text = "Borrower";
            // 
            // viewAllBorrowerToolStripMenuItem
            // 
            this.viewAllBorrowerToolStripMenuItem.Name = "viewAllBorrowerToolStripMenuItem";
            this.viewAllBorrowerToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.viewAllBorrowerToolStripMenuItem.Text = "View All borrower";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.borrowerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // libriran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_AddBook);
            this.Controls.Add(this.button_ViewBook);
            this.Controls.Add(this.button_RemoveBook);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "libriran";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.libriran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_RemoveBook;
        private System.Windows.Forms.Button button_ViewBook;
        private System.Windows.Forms.Button button_AddBook;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeBookStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllBorrowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

