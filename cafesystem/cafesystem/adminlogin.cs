using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace cafesystem
{
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            InitializeComponent();
        }

        private void girisYap_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=PROTESQ;Database=Cafe;Integrated Security=True";
            string username = kAdi.Text.Trim();
            string password = pass.Text.Trim();

            try 
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM kullanici WHERE kullaniciAdi = @username AND sifre = @password AND yetki = 'admin'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            adminPaneli adminpanel = new adminPaneli();
                            adminpanel.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı, şifre hatalı veya yetkiniz yok !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
