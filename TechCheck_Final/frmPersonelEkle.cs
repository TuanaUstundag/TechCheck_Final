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

namespace TechCheck_Final
{
    public partial class frmPersonelEkle : Form
    {
        public frmPersonelEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=KEREMKLKS\SQLEXPRESS;Initial Catalog=mnjrosan;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");

        string secilenResimYolu = "";

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                string sorgu = "INSERT INTO Personeller (AdSoyad, Email, Gorev, Maas, Telefon, ResimYolu) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                // EĞER BURADA HATA ALIYORSAN, TASARIMDAKİ TEXTBOX İSİMLERİNİ BUNLARLA AYNI YAP:
                komut.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@p2", txtMail.Text); // Tasarımda adı 'txtMail' olmalı
                komut.Parameters.AddWithValue("@p3", txtGorev.Text);
                komut.Parameters.AddWithValue("@p4", txtMaas.Text);
                komut.Parameters.AddWithValue("@p5", txtTelefon.Text);
                komut.Parameters.AddWithValue("@p6", secilenResimYolu);

                komut.ExecuteNonQuery();
                MessageBox.Show("Personel başarıyla kaydedildi!", "TechCheck", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
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
                pbResim.ImageLocation = secilenResimYolu; // Tasarımda PictureBox adı 'pbResim' olmalı
            }
        }
    }
}