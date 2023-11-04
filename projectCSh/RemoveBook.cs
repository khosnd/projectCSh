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
    public partial class RemoveBook : Form
    {
        public RemoveBook()
        {
            InitializeComponent();
        }
        string conString = "data source=DESKTOP-9OCPL5N\\SQLEXPRESS; database=boo; integrated security=True";

        // Define a method to remove a book
        private void Remove(string ISBN)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();

                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string deleteQuery = "DELETE FROM bookinfo WHERE ISBN = @ISBN";

                        using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@ISBN", ISBN);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Book removed successfully", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Book with ISBN not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

     
        private void button_BookRemove_Click(object sender, EventArgs e)
        {
            string ISBNToRemove = txtISBNtoRemove.Text;
            Remove(ISBNToRemove);
            txtISBNtoRemove.Clear();
        }
    }
}
