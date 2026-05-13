using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TechCheck_Final
{
    public partial class UC_YeniKayit : UserControl
    {
        string baglantiYolu = @"Data Source=KEREMKLKS\SQLEXPRESS;Initial Catalog=TechCheckDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        public UC_YeniKayit()
        {
            InitializeComponent();
        }

        private void UC_YeniKayit_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Yükleme metodu çalıştı!"); // Bu mesaj gelmiyorsa Load olayı bağlı değildir
            TeknisyenleriYukle();
        }

        public void TeknisyenleriYukle()
        {
            string baglantiYolu = @"Data Source=KEREMKLKS\SQLEXPRESS;Initial Catalog=TechCheckDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    baglanti.Open();

                    // 1. ADIM: Her ihtimale karşı tüm kullanıcıları çekelim (Hata payını sıfırlıyoruz)
                    string sorgu = "SELECT UserID, Username FROM Users";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // 2. ADIM: Veri geldi mi kontrol et
                    if (dt.Rows.Count > 0)
                    {
                        cmbPersoneller.DataSource = null; // Önce temizle
                        cmbPersoneller.ValueMember = "UserID";
                        cmbPersoneller.DisplayMember = "Username";
                        cmbPersoneller.DataSource = dt;

                        cmbPersoneller.SelectedIndex = -1; // Seçimsiz başlasın

                        // TEST: Burası çalışırsa kutunun dolmuş olması lazım
                        Console.WriteLine("Kutuya " + dt.Rows.Count + " kişi eklendi.");
                    }
                    else
                    {
                        MessageBox.Show("DİKKAT: Users tablosu tamamen boş! Önce personel kaydı yapmalısın.", "Veri Yok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BAĞLANTI HATASI: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMusteriAd.Text) || cmbPersoneller.SelectedValue == null)
            {
                MessageBox.Show("Lütfen Müşteri Adını yazın ve bir Teknisyen seçin!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                try
                {
                    baglanti.Open();
                    using (SqlTransaction islem = baglanti.BeginTransaction())
                    {
                        try
                        {
                            // 1. ADIM: Müşteriyi Ekle (Customers tablosu)
                            string mSorgu = "INSERT INTO Customers (FullName) OUTPUT INSERTED.CustomerID VALUES (@name)";
                            SqlCommand mKomut = new SqlCommand(mSorgu, baglanti, islem);
                            mKomut.Parameters.AddWithValue("@name", txtMusteriAd.Text.Trim());
                            int musteriId = (int)mKomut.ExecuteScalar();

                            // 2. ADIM: Cihazı Ekle (Devices tablosu)
                            // Not: Veritabanında Brand sütunu varsa ekle, yoksa sorgudan çıkar.
                            string cSorgu = "INSERT INTO Devices (CustomerID, Model, SerialNumber) OUTPUT INSERTED.DeviceID VALUES (@mId, @model, @seri)";
                            SqlCommand cKomut = new SqlCommand(cSorgu, baglanti, islem);
                            cKomut.Parameters.AddWithValue("@mId", musteriId);
                            cKomut.Parameters.AddWithValue("@model", txtCihazModel.Text.Trim());
                            cKomut.Parameters.AddWithValue("@seri", txtSeriNo.Text.Trim());
                            int cihazId = (int)cKomut.ExecuteScalar();

                            // 3. ADIM: Servis Kaydını Oluştur (ServiceRecords tablosu)
                            string sSorgu = "INSERT INTO ServiceRecords (DeviceID, TechnicianID, FailureDescription, Status) VALUES (@dId, @tId, @ariza, @durum)";
                            SqlCommand sKomut = new SqlCommand(sSorgu, baglanti, islem);
                            sKomut.Parameters.AddWithValue("@dId", cihazId);
                            sKomut.Parameters.AddWithValue("@tId", cmbPersoneller.SelectedValue);
                            sKomut.Parameters.AddWithValue("@ariza", txtAriza.Text.Trim());
                            sKomut.Parameters.AddWithValue("@durum", cmbDurum.Text != "" ? cmbDurum.Text : "Yeni");

                            sKomut.ExecuteNonQuery();

                            islem.Commit();
                            MessageBox.Show("Kayıt başarıyla oluşturuldu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Temizle();
                        }
                        catch (Exception ex)
                        {
                            islem.Rollback();
                            throw ex;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıt Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Temizle()
        {
            txtMusteriAd.Clear();
            txtCihazModel.Clear();
            txtSeriNo.Clear();
            txtAriza.Clear();
            cmbPersoneller.SelectedIndex = -1;
            if (cmbDurum.Items.Count > 0) cmbDurum.SelectedIndex = -1;
        }

        private void btnTemizle_Click(object sender, EventArgs e) => Temizle();

        private void guna2HtmlLabel1_LoadComplete(object sender, EventArgs e)
        {
            TeknisyenleriYukle();
        }

        private void UC_YeniKayit_Load_1(object sender, EventArgs e)
        {
            TeknisyenleriYukle();
        }
    }
}