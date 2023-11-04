namespace projectCSh
{
    partial class RemoveBook
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtISBNtoRemove = new System.Windows.Forms.TextBox();
            this.button_BookRemove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 74);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remove Book";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(191, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 55);
            this.panel2.TabIndex = 1;
            // 
            // txtISBNtoRemove
            // 
            this.txtISBNtoRemove.Location = new System.Drawing.Point(310, 224);
            this.txtISBNtoRemove.Name = "txtISBNtoRemove";
            this.txtISBNtoRemove.Size = new System.Drawing.Size(156, 24);
            this.txtISBNtoRemove.TabIndex = 0;
            // 
            // button_BookRemove
            // 
            this.button_BookRemove.Location = new System.Drawing.Point(321, 282);
            this.button_BookRemove.Name = "button_BookRemove";
            this.button_BookRemove.Size = new System.Drawing.Size(133, 38);
            this.button_BookRemove.TabIndex = 2;
            this.button_BookRemove.Text = "Remove Book";
            this.button_BookRemove.UseVisualStyleBackColor = true;
            this.button_BookRemove.Click += new System.EventHandler(this.button_BookRemove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter the ISBN for the book that you want to remove";
            // 
            // RemoveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_BookRemove);
            this.Controls.Add(this.txtISBNtoRemove);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RemoveBook";
            this.Text = "RemoveBook";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtISBNtoRemove;
        private System.Windows.Forms.Button button_BookRemove;
    }
}