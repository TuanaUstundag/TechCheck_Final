// frmPersonelDuzenle.cs
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
            SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mnjrosan;Integrated Security=True");

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM Personeller WHERE Id = @id", baglanti);
                komut.Parameters.AddWithValue("@id", PersonelId);
                SqlDataReader oku = komut.ExecuteReader();

                if (oku.Read())
                {
                    txtAdSoyad.Text = oku["AdSoyad"].ToString();
                    txtEmail.Text = oku["Email"].ToString();
                    txtGorev.Text = oku["Gorev"].ToString();
                    txtMaas.Text = oku["Maas"].ToString();
                    txtTelefon.Text = oku["Telefon"].ToString();

                    secilenResimYolu = oku["ResimYolu"].ToString();

                    if (!string.IsNullOrEmpty(secilenResimYolu) && System.IO.File.Exists(secilenResimYolu))
                        pbResim.Image = Image.FromFile(secilenResimYolu);
                    else
                        pbResim.Image = Properties.Resources.avatar_1;
                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                if (baglanti.State == System.Data.ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Bilgiler yüklenemedi: " + ex.Message);
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
                MessageBox.Show("Ad Soyad boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mnjrosan;Integrated Security=True");

            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand(
                    @"UPDATE Personeller SET 
                        AdSoyad   = @ad, 
                        Email     = @email, 
                        Gorev     = @gorev, 
                        Maas      = @maas, 
                        Telefon   = @telefon, 
                        ResimYolu = @resim 
                      WHERE Id = @id", baglanti);

                komut.Parameters.AddWithValue("@ad", txtAdSoyad.Text.Trim());
                komut.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                komut.Parameters.AddWithValue("@gorev", txtGorev.Text.Trim());
                komut.Parameters.AddWithValue("@maas", txtMaas.Text.Trim());
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text.Trim());
                komut.Parameters.AddWithValue("@resim", secilenResimYolu);
                komut.Parameters.AddWithValue("@id", PersonelId);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Personel bilgileri güncellendi ✅", "Başarılı");
                this.Close();
            }
            catch (Exception ex)
            {
                if (baglanti.State == System.Data.ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Güncelleme hatası: " + ex.Message);
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