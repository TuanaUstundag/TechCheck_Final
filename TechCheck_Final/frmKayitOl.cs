using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TechCheck_Final
{
    public partial class frmKayitOl : Form
    {
        string baglantiYolu = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mnjrosan;Integrated Security=True");
        string secilenResimYolu = "";

        // Liste UserControl'ümüzle bağlantı kuracak değişken
        private UC_Personeller _personelListesi;

        // Constructor güncellendi: Artık form açılırken UC_Personeller referansını alabiliyor.
        public frmKayitOl(UC_Personeller personelListesi = null)
        {
            InitializeComponent();
            _personelListesi = personelListesi;
        }

        private void btnKayitYap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(cmbRol.Text))
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                try
                {
                    baglanti.Open();

                    // SORGUN GÜNCELLENDİ: Kullanicilar tablosuna ResimYolu eklendi
                    string sorgu = "INSERT INTO Kullanicilar (KullaniciAdi, Sifre, KullaniciRolu, Email, Maas, Telefon, ResimYolu) VALUES (@user, @pass, @role, @mail, @maas, @telefon, @resimyolu)";

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@user", txtKullaniciAdi.Text.Trim());
                    komut.Parameters.AddWithValue("@pass", txtSifre.Text.Trim());
                    komut.Parameters.AddWithValue("@role", cmbRol.Text);
                    komut.Parameters.AddWithValue("@mail", txtEmail.Text.Trim());
                    komut.Parameters.AddWithValue("@maas", txtMaas.Text.Trim());
                    komut.Parameters.AddWithValue("@telefon", txtTelefon.Text.Trim());
                    komut.Parameters.AddWithValue("@resimyolu", secilenResimYolu); // Resim yolu veritabanına gidiyor

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Hesabınız başarıyla oluşturuldu! Şimdi giriş yapabilirsiniz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // LİSTEYİ ANINDA GÜNCELLEME İŞLEMİ
                    if (_personelListesi != null)
                    {
                        _personelListesi.PersonelListele();
                    }

                    FormuKapatVeGirisEkraniniAc();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıt hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaSec = new OpenFileDialog();
            dosyaSec.Title = "Personel Profil Resmi Seç";
            dosyaSec.Filter = "Resim Dosyaları |*.jpg;*.jpeg;*.png";

            if (dosyaSec.ShowDialog() == DialogResult.OK)
            {
                secilenResimYolu = dosyaSec.FileName;
                pbResim.Image = Image.FromFile(secilenResimYolu);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e) => FormuKapatVeGirisEkraniniAc();
        private void linkGirisYap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => FormuKapatVeGirisEkraniniAc();

        private void FormuKapatVeGirisEkraniniAc()
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
            this.Close();
        }

        private void txtSifre_TextChanged(object sender, EventArgs e) { }
        private void pbResim_Click(object sender, EventArgs e) { }
    }
}