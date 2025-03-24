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
    public partial class garsonpage : Form
    {
        public garsonpage()
        {
            InitializeComponent();
        }
        string connectionString = "Server=PROTESQ;Database=Cafe;Integrated Security=True";

        private void garsonpage_Load(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    siparisDataGrid.DataSource = GetData(connection, "SELECT * FROM siparis");
                    masaDataGrid.DataSource = GetData(connection, "SELECT * FROM masa");
                    urunDataGrid.DataSource = GetData(connection, "SELECT * FROM urun");
                    urunBox.Items.Clear(); // Önce eski verileri temizleyelim
                    using (SqlCommand cmd = new SqlCommand("SELECT urunAdi FROM urun", connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                urunBox.Items.Add(reader["urunAdi"].ToString());
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

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

        private void cikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siparisKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(masaNoText.Text) || !int.TryParse(masaNoText.Text, out int masaNo))
            {
                MessageBox.Show("Lütfen geçerli bir masa numarası girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (urunBox.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir ürün seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(miktarBox.Text) || !int.TryParse(miktarBox.Text, out int miktar) || miktar <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir miktar girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ürün ID'sini ve fiyatını almak için
            int urunId = 0;
            decimal birimFiyat = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                // Seçilen ürünün ID ve fiyatını al
                string urunQuery = "SELECT urunId, fiyat FROM urun WHERE urunAdi = @urunAdi";
                using (SqlCommand urunCommand = new SqlCommand(urunQuery, connection))
                {
                    urunCommand.Parameters.AddWithValue("@urunAdi", urunBox.SelectedItem.ToString());
                    using (SqlDataReader reader = urunCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            urunId = Convert.ToInt32(reader["urunId"]);
                            birimFiyat = Convert.ToDecimal(reader["fiyat"]);
                        }
                        else
                        {
                            MessageBox.Show("Seçilen ürün bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                // Garson ID'sini al (örnek olarak 1 kullanıyorum, gerçek uygulamada giriş yapan garsonun ID'si kullanılmalı)
                int garsonId = 1;
                
                // Toplam tutarı hesapla
                decimal toplamTutar = birimFiyat * miktar;
                
                // KDV hesapla (%8 varsayılan)
                decimal kdv = toplamTutar * 0.08m;

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Sipariş tablosuna ekleme yap - durum sütununu kaldırdım
                    string insertQuery = @"INSERT INTO siparis (tarih, saat, masano, garsonID, toplamTutar, KDV) 
                                        VALUES (@tarih, @saat, @masano, @garsonID, @toplamTutar, @KDV)";
                    
                    using (SqlCommand command = new SqlCommand(insertQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@tarih", DateTime.Today);
                        command.Parameters.AddWithValue("@saat", DateTime.Now.TimeOfDay);
                        command.Parameters.AddWithValue("@masano", masaNo);
                        command.Parameters.AddWithValue("@garsonID", garsonId);
                        command.Parameters.AddWithValue("@toplamTutar", toplamTutar);
                        command.Parameters.AddWithValue("@KDV", kdv);
                        
                        command.ExecuteNonQuery();
                    }

                    // Masa durumunu güncelle - durum sütunu yerine doğru sütun adını kullan
                    string updateMasaQuery = "UPDATE masa SET masaDurumu = 'Dolu' WHERE masaNo = @masaNo";
                    using (SqlCommand updateCommand = new SqlCommand(updateMasaQuery, connection, transaction))
                    {
                        updateCommand.Parameters.AddWithValue("@masaNo", masaNo);
                        updateCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Sipariş başarıyla kaydedildi ve masa durumu güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Formun verilerini yenile
                    garsonpage_Load(sender, e);
                    
                    // Giriş alanlarını temizle
                    masaNoText.Clear();
                    urunBox.SelectedIndex = -1;
                    miktarBox.Clear();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Sipariş kaydedilirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE masa SET masaDurumu = @masaDurumu WHERE masaNo = @masaNo", connection))
                    {
                        cmd.Parameters.AddWithValue("@masaDurumu", durumBox.Text);
                        cmd.Parameters.AddWithValue("@masaNo", siparisId.Text);
                        MessageBox.Show("Masa Durumu Güncellendi.");
                        cmd.ExecuteNonQuery();
                        garsonpage_Load(sender, e);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(sipId.Text) || !int.TryParse(sipId.Text, out int sipIdValue))
                {
                    MessageBox.Show("Lütfen geçerli bir sipariş ID girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    // Sipariş bilgilerini al
                    string siparisQuery = "SELECT toplamTutar, KDV FROM siparis WHERE siparisID = @siparisId";
                    using (SqlCommand cmd = new SqlCommand(siparisQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@siparisId", sipIdValue);
                        SqlDataReader reader = cmd.ExecuteReader();
                        
                        if (reader.Read())
                        {
                            decimal toplamTutar = reader["toplamTutar"] != DBNull.Value ? Convert.ToDecimal(reader["toplamTutar"]) : 0;
                            decimal kdv = reader["KDV"] != DBNull.Value ? Convert.ToDecimal(reader["KDV"]) : 0;
                            decimal toplamFiyatKDV = toplamTutar + kdv;
                            
                            reader.Close();
                            
                            // Siparişi ödenmiş olarak işaretle
                            SqlTransaction transaction = connection.BeginTransaction();
                            
                            try
                            {
                                // Sipariş durumunu güncelle
                                string updateSiparisQuery = "UPDATE siparis SET durum = 'Ödendi' WHERE siparisID = @siparisId";
                                using (SqlCommand updateCmd = new SqlCommand(updateSiparisQuery, connection, transaction))
                                {
                                    updateCmd.Parameters.AddWithValue("@siparisId", sipIdValue);
                                    updateCmd.ExecuteNonQuery();
                                }
                                
                                // Masa durumunu güncelle - masano bilgisini al
                                string getMasaQuery = "SELECT masano FROM siparis WHERE siparisID = @siparisId";
                                int masaNo = 0;
                                
                                using (SqlCommand getMasaCmd = new SqlCommand(getMasaQuery, connection, transaction))
                                {
                                    getMasaCmd.Parameters.AddWithValue("@siparisId", sipIdValue);
                                    masaNo = Convert.ToInt32(getMasaCmd.ExecuteScalar());
                                }
                                
                                // Masa durumunu boş olarak güncelle
                                string updateMasaQuery = "UPDATE masa SET masaDurumu = 'Boş' WHERE masaNo = @masaNo";
                                using (SqlCommand updateMasaCmd = new SqlCommand(updateMasaQuery, connection, transaction))
                                {
                                    updateMasaCmd.Parameters.AddWithValue("@masaNo", masaNo);
                                    updateMasaCmd.ExecuteNonQuery();
                                }
                                
                                transaction.Commit();
                                MessageBox.Show($"Toplam Fiyat (KDV dahil): {toplamFiyatKDV:C}\nÖdeme başarıyla tamamlandı.", "Ödeme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                // Formun verilerini yenile
                                garsonpage_Load(sender, e);
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show("Ödeme işlemi sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            reader.Close();
                            MessageBox.Show("Sipariş bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Siparişin toplam fiyatı alınırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(birlestirBox.Text))
                {
                    MessageBox.Show("Lütfen sipariş ID'lerini girin! (Örnek: 1,2)", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Sipariş ID'lerini ayır
                string[] siparisIdler = birlestirBox.Text.Split(',');
                if (siparisIdler.Length < 2)
                {
                    MessageBox.Show("En az iki sipariş ID'si girmelisiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        decimal toplamTutar = 0;
                        decimal toplamKDV = 0;
                        int ilkSiparisId = int.Parse(siparisIdler[0]);
                        List<int> masaNumaralari = new List<int>();

                        // Tüm siparişlerin tutarlarını topla
                        foreach (string siparisId in siparisIdler)
                        {
                            if (!int.TryParse(siparisId.Trim(), out int sipId))
                            {
                                throw new Exception($"Geçersiz sipariş ID: {siparisId}");
                            }

                            string siparisQuery = "SELECT toplamTutar, KDV, masano FROM siparis WHERE siparisID = @siparisId";
                            using (SqlCommand cmd = new SqlCommand(siparisQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@siparisId", sipId);
                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        toplamTutar += reader["toplamTutar"] != DBNull.Value ? Convert.ToDecimal(reader["toplamTutar"]) : 0;
                                        toplamKDV += reader["KDV"] != DBNull.Value ? Convert.ToDecimal(reader["KDV"]) : 0;
                                        masaNumaralari.Add(Convert.ToInt32(reader["masano"]));
                                    }
                                    else
                                    {
                                        throw new Exception($"Sipariş bulunamadı: {sipId}");
                                    }
                                }
                            }
                        }

                        // İlk siparişi güncelle (birleştirilmiş sipariş olacak)
                        string updateQuery = @"UPDATE siparis 
                                             SET toplamTutar = @toplamTutar, 
                                                 KDV = @toplamKDV,
                                                 durum = 'Birleştirildi' 
                                             WHERE siparisID = @siparisId";

                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection, transaction))
                        {
                            updateCmd.Parameters.AddWithValue("@toplamTutar", toplamTutar);
                            updateCmd.Parameters.AddWithValue("@toplamKDV", toplamKDV);
                            updateCmd.Parameters.AddWithValue("@siparisId", ilkSiparisId);
                            updateCmd.ExecuteNonQuery();
                        }

                        // Diğer siparişleri iptal et
                        for (int i = 1; i < siparisIdler.Length; i++)
                        {
                            string deleteQuery = "UPDATE siparis SET durum = 'İptal' WHERE siparisID = @siparisId";
                            using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection, transaction))
                            {
                                deleteCmd.Parameters.AddWithValue("@siparisId", int.Parse(siparisIdler[i].Trim()));
                                deleteCmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        decimal toplamFiyatKDV = toplamTutar + toplamKDV;
                        MessageBox.Show($"Siparişler başarıyla birleştirildi!\nToplam Tutar: {toplamTutar:C}\nToplam KDV: {toplamKDV:C}\nGenel Toplam: {toplamFiyatKDV:C}", 
                                      "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Formu yenile
                        garsonpage_Load(sender, e);
                        birlestirBox.Clear();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Siparişler birleştirilirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
