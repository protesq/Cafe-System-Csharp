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
    public partial class GirişYap : Form
    {
        public GirişYap()
        {
            InitializeComponent();
        }
          
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=PROTESQ;Database=Cafe;Integrated Security=True";
            string username = kullaniciAdi.Text.Trim();
            string password = sifre.Text.Trim();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    string query = "SELECT yetki FROM kullanici WHERE kullaniciAdi = @username AND sifre = @password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        object result = command.ExecuteScalar();

                        if (result != null) 
                        {
                            string yetki = result.ToString();

                            if (yetki == "Garson")
                            {
                                new garsonpage().Show();
                                this.Hide();
                            }
                            else if (yetki == "Admin")
                            {
                                new adminPaneli().Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Yetkiniz yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kayitOl_Click(object sender, EventArgs e)
        {
            adminlogin adminLogin = new adminlogin();
            adminLogin.Show();
            if (adminLogin == adminLogin)
            {
                this.Hide();
            }

        }
    }
}
