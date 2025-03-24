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

namespace cafesystem
{
    public partial class kategori : Form
    {
        public kategori()
        {
            InitializeComponent();
        }
        string connectionString = "Server=PROTESQ;Database=Cafe;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO kategori(kategoriAdi) VALUES (@kategori)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@kategori", kategoriBox.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Kategori Eklendi");
                        gridLoad(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void kategori_Load(object sender, EventArgs e)
        {
            gridLoad(sender, e);
        }

        private void gridLoad(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                kategoriGrid.DataSource = GetData(connection, "SELECT * FROM kategori");
            }
        }
        private DataTable GetData(SqlConnection connection, string query)
        {
            DataTable table = new DataTable();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new adminPaneli().Show();
            this.Hide();
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection  con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "DELETE FROM kategori WHERE kategoriID = @kategori";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@kategori", silBox.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Kategori Silindi");
                        gridLoad(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }
    }
}
