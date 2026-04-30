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
using Microsoft.VisualBasic;

namespace TechCheck_Final
{
    public partial class Form1 : Form
    {
        // Bağlantı adresin (TrustServerCertificate eklendi, hata vermez)
        string baglantiYolu = @"Data Source=KEREMKLKS\SQLEXPRESS;Initial Catalog=mnjrosan;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            try
            {
                baglanti.Open();

                // --- 1. ADIM: ADMIN KONTROLÜ (Kullanicilar Tablosu) ---
                string sorguAdmin = "SELECT * FROM Kullanicilar WHERE KullaniciAdi=@p1 AND Sifre=@p2";
                SqlCommand komutAdmin = new SqlCommand(sorguAdmin, baglanti);
                komutAdmin.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                komutAdmin.Parameters.AddWithValue("@p2", txtSifre.Text);

                SqlDataReader drAdmin = komutAdmin.ExecuteReader();

                if (drAdmin.Read())
                {
                    MessageBox.Show("Yönetici Girişi Başarılı!", "TechCheck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    drAdmin.Close();
                    Dashboard dsh = new Dashboard();
                    dsh.Show();
                    this.Hide();
                }
                else
                {
                    // Admin değilse okuyucuyu kapatıp Personellere bakıyoruz
                    drAdmin.Close();

                    // --- 2. ADIM: PERSONEL KONTROLÜ (Senin Fotoğraftaki Tablo Yapına Göre) ---
                    // ÖNEMLİ: SQL'de 'Sifre' sütununu eklemiş olman gerekiyor.
                    string sorguPersonel = "SELECT * FROM Personeller WHERE Email=@p1 AND Sifre=@p2";
                    SqlCommand komutPersonel = new SqlCommand(sorguPersonel, baglanti);
                    komutPersonel.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text); // Personel emailini buraya girecek
                    komutPersonel.Parameters.AddWithValue("@p2", txtSifre.Text);

                    SqlDataReader drPersonel = komutPersonel.ExecuteReader();

                    if (drPersonel.Read())
                    {
                        // Senin tablandaki sütun adı 'AdSoyad' olduğu için onu çekiyoruz
                        string adSoyad = drPersonel["AdSoyad"].ToString();
                        MessageBox.Show("Hoş geldin Personel: " + adSoyad, "TechCheck", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        drPersonel.Close();
                        Dashboard dsh = new Dashboard(); // Şimdilik ana panele yönlendirir
                        dsh.Show();
                        this.Hide();
                    }
                    else
                    {
                        drPersonel.Close();
                        MessageBox.Show("Kullanıcı adı/Email veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        // ... Diğer metodlar (Şifre unuttum vs.) burada aynen kalabilir ...
    }
}