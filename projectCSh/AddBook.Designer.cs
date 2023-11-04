namespace projectCSh
{
    partial class AddBook
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
            this.panel1_ADDBOOK = new System.Windows.Forms.Panel();
            this.label_addBook = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BName_txt = new System.Windows.Forms.Label();
            this.BAuther_txt = new System.Windows.Forms.Label();
            this.Bedition_txt = new System.Windows.Forms.Label();
            this.Bprice = new System.Windows.Forms.Label();
            this.Bstate_txt = new System.Windows.Forms.Label();
            this.Bisbn_txt = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtBookAuther = new System.Windows.Forms.TextBox();
            this.txtBookEdition = new System.Windows.Forms.TextBox();
            this.txtBookISBN = new System.Windows.Forms.TextBox();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBookState = new System.Windows.Forms.ComboBox();
            this.panel1_ADDBOOK.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1_ADDBOOK
            // 
            this.panel1_ADDBOOK.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1_ADDBOOK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1_ADDBOOK.Controls.Add(this.label_addBook);
            this.panel1_ADDBOOK.Location = new System.Drawing.Point(12, 12);
            this.panel1_ADDBOOK.Name = "panel1_ADDBOOK";
            this.panel1_ADDBOOK.Size = new System.Drawing.Size(776, 55);
            this.panel1_ADDBOOK.TabIndex = 0;
            // 
            // label_addBook
            // 
            this.label_addBook.AutoSize = true;
            this.label_addBook.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addBook.Location = new System.Drawing.Point(39, 18);
            this.label_addBook.Name = "label_addBook";
            this.label_addBook.Size = new System.Drawing.Size(87, 23);
            this.label_addBook.TabIndex = 0;
            this.label_addBook.Text = "Add Book";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBookState);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtBookPrice);
            this.panel1.Controls.Add(this.txtBookISBN);
            this.panel1.Controls.Add(this.txtBookEdition);
            this.panel1.Controls.Add(this.txtBookAuther);
            this.panel1.Controls.Add(this.txtBookName);
            this.panel1.Controls.Add(this.Bisbn_txt);
            this.panel1.Controls.Add(this.Bstate_txt);
            this.panel1.Controls.Add(this.Bprice);
            this.panel1.Controls.Add(this.Bedition_txt);
            this.panel1.Controls.Add(this.BAuther_txt);
            this.panel1.Controls.Add(this.BName_txt);
            this.panel1.Location = new System.Drawing.Point(44, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 311);
            this.panel1.TabIndex = 1;
            // 
            // BName_txt
            // 
            this.BName_txt.AutoSize = true;
            this.BName_txt.Location = new System.Drawing.Point(106, 42);
            this.BName_txt.Name = "BName_txt";
            this.BName_txt.Size = new System.Drawing.Size(83, 17);
            this.BName_txt.TabIndex = 0;
            this.BName_txt.Text = "Book Name:";
            // 
            // BAuther_txt
            // 
            this.BAuther_txt.AutoSize = true;
            this.BAuther_txt.Location = new System.Drawing.Point(106, 106);
            this.BAuther_txt.Name = "BAuther_txt";
            this.BAuther_txt.Size = new System.Drawing.Size(54, 17);
            this.BAuther_txt.TabIndex = 1;
            this.BAuther_txt.Text = "Auther:";
            // 
            // Bedition_txt
            // 
            this.Bedition_txt.AutoSize = true;
            this.Bedition_txt.Location = new System.Drawing.Point(106, 139);
            this.Bedition_txt.Name = "Bedition_txt";
            this.Bedition_txt.Size = new System.Drawing.Size(54, 17);
            this.Bedition_txt.TabIndex = 2;
            this.Bedition_txt.Text = "Edition:";
            // 
            // Bprice
            // 
            this.Bprice.AutoSize = true;
            this.Bprice.Location = new System.Drawing.Point(106, 171);
            this.Bprice.Name = "Bprice";
            this.Bprice.Size = new System.Drawing.Size(42, 17);
            this.Bprice.TabIndex = 3;
            this.Bprice.Text = "Price:";
            // 
            // Bstate_txt
            // 
            this.Bstate_txt.AutoSize = true;
            this.Bstate_txt.Location = new System.Drawing.Point(106, 206);
            this.Bstate_txt.Name = "Bstate_txt";
            this.Bstate_txt.Size = new System.Drawing.Size(45, 17);
            this.Bstate_txt.TabIndex = 4;
            this.Bstate_txt.Text = "State:";
            // 
            // Bisbn_txt
            // 
            this.Bisbn_txt.AutoSize = true;
            this.Bisbn_txt.Location = new System.Drawing.Point(106, 76);
            this.Bisbn_txt.Name = "Bisbn_txt";
            this.Bisbn_txt.Size = new System.Drawing.Size(42, 17);
            this.Bisbn_txt.TabIndex = 5;
            this.Bisbn_txt.Text = "ISBN:";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(240, 35);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(346, 24);
            this.txtBookName.TabIndex = 6;
            // 
            // txtBookAuther
            // 
            this.txtBookAuther.Location = new System.Drawing.Point(240, 99);
            this.txtBookAuther.Name = "txtBookAuther";
            this.txtBookAuther.Size = new System.Drawing.Size(346, 24);
            this.txtBookAuther.TabIndex = 7;
            // 
            // txtBookEdition
            // 
            this.txtBookEdition.Location = new System.Drawing.Point(240, 132);
            this.txtBookEdition.Name = "txtBookEdition";
            this.txtBookEdition.Size = new System.Drawing.Size(346, 24);
            this.txtBookEdition.TabIndex = 8;
            // 
            // txtBookISBN
            // 
            this.txtBookISBN.Location = new System.Drawing.Point(240, 69);
            this.txtBookISBN.Name = "txtBookISBN";
            this.txtBookISBN.Size = new System.Drawing.Size(346, 24);
            this.txtBookISBN.TabIndex = 9;
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.AcceptsReturn = true;
            this.txtBookPrice.Location = new System.Drawing.Point(240, 164);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(346, 24);
            this.txtBookPrice.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(511, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(133, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBookState
            // 
            this.txtBookState.FormattingEnabled = true;
            this.txtBookState.Items.AddRange(new object[] {
            "available",
            "borrowed",
            "lost"});
            this.txtBookState.Location = new System.Drawing.Point(240, 199);
            this.txtBookState.Name = "txtBookState";
            this.txtBookState.Size = new System.Drawing.Size(346, 24);
            this.txtBookState.TabIndex = 14;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel1_ADDBOOK);
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.panel1_ADDBOOK.ResumeLayout(false);
            this.panel1_ADDBOOK.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1_ADDBOOK;
        private System.Windows.Forms.Label label_addBook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Bstate_txt;
        private System.Windows.Forms.Label Bprice;
        private System.Windows.Forms.Label Bedition_txt;
        private System.Windows.Forms.Label BAuther_txt;
        private System.Windows.Forms.Label BName_txt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.TextBox txtBookISBN;
        private System.Windows.Forms.TextBox txtBookEdition;
        private System.Windows.Forms.TextBox txtBookAuther;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label Bisbn_txt;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox txtBookState;
    }
}