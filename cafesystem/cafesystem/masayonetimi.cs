using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafesystem
{
    public partial class masayonetimi : Form
    {
        public masayonetimi()
        {
            InitializeComponent();
        }

        string connectionString = "Server=PROTESQ;Database=Cafe;Integrated Security=True";
        private void masayonetimi_Load(object sender, EventArgs e)
        {
            gridLoader();
        }
        private void gridLoader()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    masaGrid.DataSource = GetData(connection, "SELECT * FROM masa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
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
                }
            }
            return table;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new adminPaneli().Show();
            this.Hide();
        }

        private void EkleButton_Click(object sender, EventArgs e)
        {
            try
            {
                int yeniMasaNo = 1; // Varsayılan olarak 1'den başlat

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string getMaxQuery = "SELECT ISNULL(MAX(masano), 0) + 1 FROM masa"; // En büyük masano +1 al
                    using (SqlCommand getMaxCmd = new SqlCommand(getMaxQuery, connection))
                    {
                        yeniMasaNo = (int)getMaxCmd.ExecuteScalar(); // Yeni masa numarasını belirle
                    }

                    string insertQuery = "INSERT INTO masa (masano, masaDurumu) VALUES (@masano, @masaDurumu)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@masano", yeniMasaNo);
                        command.Parameters.AddWithValue("@masaDurumu", "BOŞ");
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Masa Eklendi: " + yeniMasaNo);
                    gridLoader();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE masa SET masaDurumu = @masaDurumu WHERE masano = @masano";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        try
                        {
                            int masaNo;
                            if (!int.TryParse(masaIdBox.Text, out masaNo))
                            {
                                MessageBox.Show("Lütfen geçerli bir masa numarası girin.");
                                return;
                            }

                            command.Parameters.AddWithValue("@masano", masaNo);
                            command.Parameters.AddWithValue("@masaDurumu", comboBox1.SelectedItem.ToString());

                            int affectedRows = command.ExecuteNonQuery();

                            if (affectedRows > 0)
                                MessageBox.Show("Masa Güncellendi");
                            else
                                MessageBox.Show("Belirtilen masa bulunamadı.");

                            gridLoader();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}