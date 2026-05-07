using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TechCheck_Final
{
    public partial class frmPersonelDuzenle : Form
    {
        public int PersonelId { get; set; }
        private string secilenResimYolu = "";

        // Bağlantı yolunu her seferinde uzun uzun yazmamak için buraya aldım
        string baglantiYolu = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mnjrosan;Integrated Security=True";

        public frmPersonelDuzenle()
        {
            InitializeComponent();
        }

        private void frmPersonelDuzenle_Load(object sender, EventArgs e)
        {
            MevcutBilgileriYukle();
        }

        private void MevcutBilgileriYukle()
        {
            SqlConnection baglanti = new SqlConnection(baglantiYolu);

            try
            {
                baglanti.Open();

                // TABLO GÜNCELLENDİ: Kullanicilar
                SqlCommand komut = new SqlCommand("SELECT * FROM Kullanicilar WHERE Id = @id", baglanti);
                komut.Parameters.AddWithValue("@id", PersonelId);
                SqlDataReader oku = komut.ExecuteReader();

                if (oku.Read())
                {
                    // SÜTUN ADLARI GÜNCELLENDİ (Veritabanındaki gerçek isimlerine göre)
                    txtAdSoyad.Text = oku["KullaniciAdi"].ToString();
                    txtEmail.Text = oku["Email"].ToString();
                    txtGorev.Text = oku["KullaniciRolu"].ToString();
                    txtMaas.Text = oku["Maas"].ToString();
                    txtTelefon.Text = oku["Telefon"].ToString();

                    secilenResimYolu = oku["ResimYolu"].ToString();

                    if (!string.IsNullOrEmpty(secilenResimYolu) && System.IO.File.Exists(secilenResimYolu))
                        pbResim.Image = Image.FromFile(secilenResimYolu);
                    else
                        pbResim.Image = Properties.Resources.avatar_1; // Resim yoksa varsayılanı koy
                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                if (baglanti.State == System.Data.ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Bilgiler yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text))
            {
                MessageBox.Show("Personel adı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // İŞTE ÇÖZÜM BURADA: Maaşı güvenli bir şekilde sayıya (decimal) çeviriyoruz.
            // Replace(".", ",") kısmı, eğer kullanıcı 50000.00 yazarsa sistemin bunu hata vermeden 50000,00 şeklinde sayıya çevirmesini sağlar (Türkçe formatına uyum için).
            decimal maasDegeri = 0;
            decimal.TryParse(txtMaas.Text.Trim().Replace(".", ","), out maasDegeri);

            SqlConnection baglanti = new SqlConnection(baglantiYolu);

            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand(
                    @"UPDATE Kullanicilar SET 
                KullaniciAdi   = @ad, 
                Email          = @email, 
                KullaniciRolu  = @gorev, 
                Maas           = @maas, 
                Telefon        = @telefon, 
                ResimYolu      = @resim 
              WHERE Id = @id", baglanti);

                komut.Parameters.AddWithValue("@ad", txtAdSoyad.Text.Trim());
                komut.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                komut.Parameters.AddWithValue("@gorev", txtGorev.Text.Trim());

                // DEĞİŞİKLİK BURADA: Artık txtMaas.Text (metin) değil, maasDegeri (sayı) değişkenini gönderiyoruz!
                komut.Parameters.AddWithValue("@maas", maasDegeri);

                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text.Trim());
                komut.Parameters.AddWithValue("@resim", secilenResimYolu);
                komut.Parameters.AddWithValue("@id", PersonelId);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Personel bilgileri başarıyla güncellendi ✅", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                if (baglanti.State == System.Data.ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Güncelleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResimSec_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
            ofd.Title = "Profil Resmi Seç";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                secilenResimYolu = ofd.FileName;
                pbResim.Image = Image.FromFile(secilenResimYolu);
            }
        }
    }
}