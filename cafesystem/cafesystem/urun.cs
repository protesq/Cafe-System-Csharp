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
    public partial class urun : Form
    {
        public urun()
        {
            InitializeComponent();
        }

        string connectionString = "Server=PROTESQ;Database=Cafe;Integrated Security=True";

        private void LoadCategories()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT kategoriID, kategoriAdi FROM kategori";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        kategoriBox1.Items.Clear();
                        while (reader.Read())
                        {
                            kategoriBox1.Items.Add(new KeyValuePair<int, string>(
                                Convert.ToInt32(reader["kategoriID"]),
                                reader["kategoriAdi"].ToString()
                            ));
                        }
                    }
                }
            }

            // ComboBox'ın Key-Value eşleşmesini sağlamak için ayarları yap
            kategoriBox1.DisplayMember = "Value";
            kategoriBox1.ValueMember = "Key";
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (kategoriBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir kategori seçiniz.");
                return;
            }

            // Kategori ID'yi al
            int kategoriIdValue = ((KeyValuePair<int, string>)kategoriBox1.SelectedItem).Key;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO urun (urunAdi, fiyat, kdv, stok, kategoriId) VALUES (@urunAdi, @fiyat, @kdv, @stok, @kategoriId)";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    try
                    {
                        int fiyattext = Convert.ToInt32(fiyat.Text);
                        double kdvtext = 1.8;
                        int sonfiyat = Convert.ToInt32(fiyattext * kdvtext);

                        command.Parameters.AddWithValue("@urunAdi", urunAdi.Text);
                        command.Parameters.AddWithValue("@fiyat", sonfiyat);
                        command.Parameters.AddWithValue("@kdv", kdvtext);
                        command.Parameters.AddWithValue("@stok", Stok.Text);
                        command.Parameters.AddWithValue("@kategoriId", kategoriIdValue);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Ürün eklendi.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void urun_Load(object sender, EventArgs e)
        {
            LoadCategories();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    urunDataGrid.DataSource = GetData(connection, "SELECT * FROM urun");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Stok_TextChanged(object sender, EventArgs e)
        {

        }

        private void silButton_Click(object sender, EventArgs e)
        {
            using(SqlConnection  connection = new SqlConnection(connectionString)) {
                connection.Open();
                string query = "DELETE FROM urun WHERE urunID = @urunID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@urunID", Convert.ToInt32(urunId.Text));
                        command.ExecuteNonQuery();
                        MessageBox.Show("Ürün silindi.");
                        urun_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new adminPaneli().Show();
        }
    }
}
