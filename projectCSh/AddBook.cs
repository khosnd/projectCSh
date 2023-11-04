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
using static projectCSh.libriran;

namespace projectCSh
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            libriran lib = new libriran();
            CenteredMessageBoxForm dialog = new CenteredMessageBoxForm("Are you sure you want to cancel ?", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Close();
                lib.Focus();

              


            }
        }
        public string conString = "Data Source=DESKTOP-9OCPL5N\\SQLEXPRESS;Initial Catalog=boo;Integrated Security=True;Encrypt=False";
        private void btnSave_Click(object sender, EventArgs e)
        { 
            String Bname = txtBookName.Text;
            String B_ISBN = txtBookISBN.Text;
            String Bauther = txtBookAuther.Text;
            String Bedition = txtBookEdition.Text;
            Int64 BPrice = Int64.Parse(txtBookPrice.Text);
            String BState = txtBookState.Text;

            //Connect to the Book SQL Server
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into bookinfo (Name,ISBN,auther,edition,price,state) values ('" + Bname + "', '" + B_ISBN + "', '" + Bauther + "', '" + Bedition + "'," + BPrice + ",'" + BState + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Book added successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtBookName.Clear();
                txtBookISBN.Clear();
                txtBookAuther.Clear();
                txtBookEdition.Clear();
                txtBookPrice.Clear();
                

            }








        }
    }
}
