using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TechCheck_Final
{
    public partial class frmKayitOl : Form
    {
        // Bağlantı yolunu Form1 ile aynı yaptık
        string baglantiYolu = @"Data Source=KEREMKLKS\SQLEXPRESS;Initial Catalog=TechCheckDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        public frmKayitOl()
        {
            InitializeComponent();
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
                    string sorgu = "INSERT INTO Users (Username, Password, UserRole, Email) VALUES (@user, @pass, @role, @mail)";

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@user", txtKullaniciAdi.Text.Trim());
                    komut.Parameters.AddWithValue("@pass", txtSifre.Text.Trim());
                    komut.Parameters.AddWithValue("@role", cmbRol.Text);
                    komut.Parameters.AddWithValue("@mail", txtEmail.Text.Trim());

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Hesabınız başarıyla oluşturuldu! Şimdi giriş yapabilirsiniz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormuKapatVeGirisEkraniniAc();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıt hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e) => FormuKapatVeGirisEkraniniAc();
        private void linkGirisYap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => FormuKapatVeGirisEkraniniAc();

        private void FormuKapatVeGirisEkraniniAc()
        {
            // Bu formun sahibi (Owner) varsa onu göster
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
            this.Close();
        }
    }
}