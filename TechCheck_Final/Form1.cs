using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TechCheck_Final
{
    public partial class Form1 : Form
    {
        // Bağlantı yolunu TechCheckDB ve Users tablosuna göre eşitledik
        string baglantiYolu = @"Data Source=KEREMKLKS\SQLEXPRESS;Initial Catalog=TechCheckDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

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
            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                try
                {
                    baglanti.Open();
                    // Yeni Users tablosuna göre sorgu
                    string sorgu = "SELECT * FROM Users WHERE Username=@p1 AND Password=@p2";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                    komut.Parameters.AddWithValue("@p2", txtSifre.Text);

                    SqlDataReader dr = komut.ExecuteReader();

                    if (dr.Read())
                    {
                        string rol = dr["UserRole"].ToString();
                        MessageBox.Show("Giriş Başarılı! Rolünüz: " + rol, "TechCheck", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            }
        }

        // "Kayıt Ol" yazısına tıklandığında çalışan yer
        private void lblForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKayitOl kayitFormu = new frmKayitOl();
            kayitFormu.Owner = this; // Form1'i bu formun sahibi yapıyoruz
            kayitFormu.Show();       // Kayıt formunu aç
            this.Hide();             // Login formunu gizle (Kapanmaz, sadece saklanır)
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}