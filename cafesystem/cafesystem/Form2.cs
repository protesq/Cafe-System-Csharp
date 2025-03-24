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
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace cafesystem
{

    public partial class adminPaneli : Form
    {
        public adminPaneli()
        {
            InitializeComponent();
        }
        string connectionString = "Server=PROTESQ;Database=Cafe;Integrated Security=True";

        private void kayitOl_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {  
                connection.Open();
                string query = "INSERT INTO kullanici (kullaniciAdi, sifre,yetki) VALUES (@kullaniciAdi, @sifre,@yetki)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@kullaniciAdi", kAdi.Text);
                        command.Parameters.AddWithValue("@sifre", pass.Text);
                        command.Parameters.AddWithValue("@yetki", yetkiBox.Text);
                        command.ExecuteNonQuery();
                  
                        MessageBox.Show("Kayıt Başarılı");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void adminPaneli_Load(object sender, EventArgs e)
        {
           
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    kullaniciGrid.DataSource = GetData(connection, "SELECT * FROM kullanici");
                    urunGrid.DataSource = GetData(connection, "SELECT * FROM urun");
                    tedarikciGrid.DataSource = GetData(connection, "SELECT * FROM tedarikci");
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
        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO tedarikci(unvan,adres,telefon) VALUES (@tedarikciAdi,@tedarikciAdres,@tedarikciTelefon)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@tedarikciAdi", tedarikciAd.Text);
                        command.Parameters.AddWithValue("@tedarikciAdres", tedarikciAdres.Text);
                        command.Parameters.AddWithValue("@tedarikciTelefon", tedarikciTel.Text);
                        command.ExecuteNonQuery();
                        tedarikciGrid.DataSource = GetData(connection, "SELECT * FROM tedarikci");
                        MessageBox.Show("Tedarikçi Eklendi");
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
            urun urun = new urun();
            urun.Show();
            if (urun == urun)
            {
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kategori kategori = new kategori();
            kategori.Show();
            if (kategori == kategori)
            {
                this.Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new masayonetimi().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Günlük ve aylık rapor için tarihler
                    DateTime bugun = DateTime.Today;
                    DateTime ayBasi = new DateTime(bugun.Year, bugun.Month, 1);

                    // Günlük satış raporu
                    string gunlukRaporQuery = @"
                        SELECT 
                            u.urunAdi,
                            COUNT(*) as SatilanAdet,
                            SUM(s.toplamTutar) as ToplamTutar,
                            SUM(s.KDV) as ToplamKDV,
                            k.kullaniciAdi as GarsonAdi
                        FROM siparis s
                        INNER JOIN urun u ON s.siparisID = u.urunID
                        INNER JOIN kullanici k ON s.garsonID = k.kullaniciID
                        WHERE s.tarih = @bugun AND s.durum = 'Ödendi'
                        GROUP BY u.urunAdi, k.kullaniciAdi";

                    // Aylık satış raporu
                    string aylikRaporQuery = @"
                        SELECT 
                            u.urunAdi,
                            COUNT(*) as SatilanAdet,
                            SUM(s.toplamTutar) as ToplamTutar,
                            SUM(s.KDV) as ToplamKDV,
                            k.kullaniciAdi as GarsonAdi
                        FROM siparis s
                        INNER JOIN urun u ON s.siparisID = u.urunID
                        INNER JOIN kullanici k ON s.garsonID = k.kullaniciID
                        WHERE s.tarih >= @ayBasi AND s.durum = 'Ödendi'
                        GROUP BY u.urunAdi, k.kullaniciAdi";

                    DataTable gunlukRapor = new DataTable();
                    DataTable aylikRapor = new DataTable();

                    using (SqlCommand gunlukCmd = new SqlCommand(gunlukRaporQuery, connection))
                    {
                        gunlukCmd.Parameters.AddWithValue("@bugun", bugun);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(gunlukCmd))
                        {
                            adapter.Fill(gunlukRapor);
                        }
                    }

                    using (SqlCommand aylikCmd = new SqlCommand(aylikRaporQuery, connection))
                    {
                        aylikCmd.Parameters.AddWithValue("@ayBasi", ayBasi);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(aylikCmd))
                        {
                            adapter.Fill(aylikRapor);
                        }
                    }

                    // Word dosyası oluştur
                    using (SaveFileDialog saveDialog = new SaveFileDialog())
                    {
                        saveDialog.Filter = "Word Dosyası|*.docx";
                        saveDialog.Title = "Raporu Kaydet";
                        saveDialog.FileName = $"Rapor_{DateTime.Now:yyyy-MM-dd}.docx";

                        if (saveDialog.ShowDialog() == DialogResult.OK)
                        {
                            using (var document = WordprocessingDocument.Create(saveDialog.FileName, WordprocessingDocumentType.Document))
                            {
                                var mainPart = document.AddMainDocumentPart();
                                mainPart.Document = new Document();
                                var body = mainPart.Document.AppendChild(new Body());

                                // Başlık ekle
                                body.AppendChild(new Paragraph(new Run(new Text($"Satış Raporu - {DateTime.Now:dd.MM.yyyy}"))));
                                body.AppendChild(new Paragraph(new Run(new Text("")))); // Boş satır

                                // Günlük rapor
                                body.AppendChild(new Paragraph(new Run(new Text("GÜNLÜK RAPOR"))));
                                decimal gunlukToplamKar = 0;

                                foreach (DataRow row in gunlukRapor.Rows)
                                {
                                    decimal toplamTutar = Convert.ToDecimal(row["ToplamTutar"]);
                                    gunlukToplamKar += toplamTutar;

                                    string satir = $"Ürün: {row["urunAdi"]}\n" +
                                                 $"Satılan Adet: {row["SatilanAdet"]}\n" +
                                                 $"Toplam Tutar: {toplamTutar:C}\n" +
                                                 $"KDV: {Convert.ToDecimal(row["ToplamKDV"]):C}\n" +
                                                 $"Garson: {row["GarsonAdi"]}\n";

                                    body.AppendChild(new Paragraph(new Run(new Text(satir))));
                                }

                                body.AppendChild(new Paragraph(new Run(new Text($"Günlük Toplam Kar: {gunlukToplamKar:C}"))));
                                body.AppendChild(new Paragraph(new Run(new Text("")))); // Boş satır

                                // Aylık rapor
                                body.AppendChild(new Paragraph(new Run(new Text("AYLIK RAPOR"))));
                                decimal aylikToplamKar = 0;

                                foreach (DataRow row in aylikRapor.Rows)
                                {
                                    decimal toplamTutar = Convert.ToDecimal(row["ToplamTutar"]);
                                    aylikToplamKar += toplamTutar;

                                    string satir = $"Ürün: {row["urunAdi"]}\n" +
                                                 $"Satılan Adet: {row["SatilanAdet"]}\n" +
                                                 $"Toplam Tutar: {toplamTutar:C}\n" +
                                                 $"KDV: {Convert.ToDecimal(row["ToplamKDV"]):C}\n" +
                                                 $"Garson: {row["GarsonAdi"]}\n";

                                    body.AppendChild(new Paragraph(new Run(new Text(satir))));
                                }

                                body.AppendChild(new Paragraph(new Run(new Text($"Aylık Toplam Kar: {aylikToplamKar:C}"))));
                            }

                            MessageBox.Show("Rapor başarıyla oluşturuldu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rapor oluşturulurken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
