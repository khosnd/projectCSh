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
    public partial class ViewAllBook : Form
    {
        public ViewAllBook()
        {
            InitializeComponent();
        }
        String conString = "data source=DESKTOP-9OCPL5N\\SQLEXPRESS; database=boo; integrated security=True";
        private void ViewAllBooks()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();

                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string selectQuery = "SELECT * FROM bookinfo";

                        using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                        {
                            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            {
                                using (DataSet ds = new DataSet())
                                {
                                    da.Fill(ds, "Books");

                                    
                                    dataGridViewBooks.DataSource = ds.Tables["Books"];
                                }
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
        private void ViewAllBook_Load(object sender, EventArgs e)
        {
            ViewAllBooks();
        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            EditInfo edit = new EditInfo();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            libriran lib = new libriran();
            lib.Show();
            this.Close();

        }
    }
}
