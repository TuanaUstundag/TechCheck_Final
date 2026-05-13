using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace TechCheck_Final
{
    public partial class frmKayitOl : Form
    {
        string baglantiYolu = @"Data Source=KEREMKLKS\SQLEXPRESS;Initial Catalog=TechCheckDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        string secilenResimYolu = "";

        private UC_Personeller _personelListesi;

        public frmKayitOl(UC_Personeller personelListesi = null)
        {
            InitializeComponent();
            _personelListesi = personelListesi;
        }

        private void btnKayitYap_Click(object sender, EventArgs e)
        {
            // 1. ADIM: Boş alan kontrolü
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(cmbRol.Text))
            {
                MessageBox.Show("Lütfen yıldızlı alanları eksiksiz doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                try
                {
                    baglanti.Open();

                    // 2. ADIM: SQL Sorgusu (UserRole sütununa dikkat!)
                    string sorgu = @"INSERT INTO Users (Username, Password, UserRole, Email, Salary, Phone, ProfilePicture) 
                                   VALUES (@user, @pass, @role, @mail, @maas, @telefon, @resimyolu)";

                    // 3. ADIM: Önce komutu OLUŞTURUYORUZ (Hata buradaydı)
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    // 4. ADIM: Şimdi parametreleri EKLEYEBİLİRİZ
                    komut.Parameters.AddWithValue("@user", txtKullaniciAdi.Text.Trim());
                    komut.Parameters.AddWithValue("@pass", txtSifre.Text.Trim());
                    komut.Parameters.AddWithValue("@role", cmbRol.Text); // Seçilen Admin/Teknisyen
                    komut.Parameters.AddWithValue("@mail", txtEmail.Text.Trim());
                    komut.Parameters.AddWithValue("@maas", string.IsNullOrEmpty(txtMaas.Text) ? "0" : txtMaas.Text.Trim());
                    komut.Parameters.AddWithValue("@telefon", string.IsNullOrEmpty(txtTelefon.Text) ? "-" : txtTelefon.Text.Trim());
                    komut.Parameters.AddWithValue("@resimyolu", secilenResimYolu);

                    // 5. ADIM: Sorguyu çalıştır
                    komut.ExecuteNonQuery();

                    MessageBox.Show("Personel kaydı başarıyla oluşturuldu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Listeyi yenile
                    if (_personelListesi != null)
                    {
                        _personelListesi.PersonelListele();
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıt sırasında bir hata oluştu: " + ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dosyaSec = new OpenFileDialog())
            {
                dosyaSec.Title = "Personel Profil Resmi Seç";
                dosyaSec.Filter = "Resim Dosyaları |*.jpg;*.jpeg;*.png";

                if (dosyaSec.ShowDialog() == DialogResult.OK)
                {
                    secilenResimYolu = dosyaSec.FileName;

                    // MemoryStream kullanımı: Dosyanın kilitlenmesini önler
                    byte[] resimByte = File.ReadAllBytes(secilenResimYolu);
                    using (MemoryStream ms = new MemoryStream(resimByte))
                    {
                        pbResim.Image = Image.FromStream(ms);
                    }
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e) => this.Close();

        private void linkGirisYap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => this.Close();
    }
}