using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using Microsoft.VisualBasic; // InputBox kullanabilmek için (Referanslardan eklemelisin)

namespace TechCheck_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Veritabanı bağlantısı
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TechCheckDB;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM Kullanicilar WHERE KullaniciAdi=@p1 AND Sifre=@p2";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);

                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Giriş Başarılı!", "TechCheck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dashboard dsh = new Dashboard();
                    dsh.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası: " + ex.Message);
            }
            finally { baglanti.Close(); }
        }

        private void lblForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text))
            {
                MessageBox.Show("Lütfen önce kullanıcı adınızı giriniz!");
                return;
            }

            try
            {
                // 1. Kod Üret
                Random rnd = new Random();
                string kod = rnd.Next(100000, 999999).ToString();

                // 2. Veritabanına Yaz ve Mail Çek
                baglanti.Open();
                SqlCommand komutKod = new SqlCommand("UPDATE Kullanicilar SET KurtarmaKodu=@k1 WHERE KullaniciAdi=@p1", baglanti);
                komutKod.Parameters.AddWithValue("@k1", kod);
                komutKod.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                komutKod.ExecuteNonQuery();

                SqlCommand komutMail = new SqlCommand("SELECT Email FROM Kullanicilar WHERE KullaniciAdi=@p1", baglanti);
                komutMail.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                string aliciMail = komutMail.ExecuteScalar()?.ToString();
                baglanti.Close();

                if (string.IsNullOrEmpty(aliciMail))
                {
                    MessageBox.Show("Bu kullanıcıya ait kayıtlı bir e-posta bulunamadı!");
                    return;
                }

                // 3. Mail Gönder (BURAYI GÜNCELLE)
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.gmail.com";
                sc.EnableSsl = true;
                // Kendi bilgilerini buraya yaz:
                sc.Credentials = new NetworkCredential("mustafakilkis739@gmail.com", "epzccctfecqtxbgc");

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("mustafakilkis739@gmail.com", "TechCheck Güvenlik");
                mail.To.Add(aliciMail);
                mail.Subject = "Şifre Sıfırlama Kodu";
                mail.Body = $"Sayın {txtKullaniciAdi.Text},\n\nŞifrenizi sıfırlamak için güvenlik kodunuz: {kod}";

                sc.Send(mail);
                MessageBox.Show("Kurtarma kodu e-posta adresinize gönderildi!");

                // 4. Kod Doğrulama (Basit bir InputBox ile)
                string girilenKod = Interaction.InputBox("Lütfen mailinize gelen 6 haneli kodu giriniz:", "Kod Doğrulama");

                if (girilenKod == kod)
                {
                    string yeniSifre = Interaction.InputBox("Kod Doğrulandı! Yeni şifrenizi giriniz:", "Şifre Güncelleme");

                    baglanti.Open();
                    SqlCommand komutGuncelle = new SqlCommand("UPDATE Kullanicilar SET Sifre=@s1 WHERE KullaniciAdi=@p1", baglanti);
                    komutGuncelle.Parameters.AddWithValue("@s1", yeniSifre);
                    komutGuncelle.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                    komutGuncelle.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Şifreniz başarıyla güncellendi! Yeni şifrenizle giriş yapabilirsiniz.");
                }
                else
                {
                    MessageBox.Show("Hatalı kod girdiniz!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem sırasında hata oluştu: " + ex.Message);
            }
            finally { if (baglanti.State == ConnectionState.Open) baglanti.Close(); }
        }
    }
}