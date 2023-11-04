using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectCSh
{
    public partial class libriran : Form
    {
        public libriran()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void libriran_Load(object sender, EventArgs e)
        {

        }
        public class CenteredMessageBoxForm : Form
        {
            public CenteredMessageBoxForm(string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
            {
                Text = caption;
                FormBorderStyle = FormBorderStyle.FixedDialog;
                ControlBox = false;
                StartPosition = FormStartPosition.CenterParent;

                Label label = new Label
                {
                    Text = message,
                    AutoSize = true,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                Button[] dialogButtons = new Button[]
                {
            new Button { Text = "Yes", DialogResult = DialogResult.Yes },
            new Button { Text = "No", DialogResult = DialogResult.No }
                };

                TableLayoutPanel buttonsPanel = new TableLayoutPanel
                {
                    ColumnCount = 2,
                    Dock = DockStyle.Bottom,
                    AutoSize = true,
                    Padding = new Padding(10)
                };

                foreach (Button button in dialogButtons)
                {
                    buttonsPanel.Controls.Add(button);
                }

                Controls.Add(label);
                Controls.Add(buttonsPanel);

                AcceptButton = dialogButtons[0];
                CancelButton = dialogButtons[1];
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CenteredMessageBoxForm dialog = new CenteredMessageBoxForm("Are you sure you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog.ShowDialog() == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button_AddBook_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.Show();
        }
       

        private void button_RemoveBook_Click(object sender, EventArgs e)
        {
            RemoveBook removeBook = new RemoveBook();
            removeBook.Show();
            
        }

        private void button_ViewBook_Click(object sender, EventArgs e)
        {
            ViewAllBook view = new ViewAllBook();
            view.Show();
        }
    }
}