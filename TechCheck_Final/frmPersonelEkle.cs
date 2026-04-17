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
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mnjrosan;Integrated Security=True
");
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            // DİKKAT: Sorguya "ResimYolu" eklendi!
            SqlCommand komut = new SqlCommand("INSERT INTO Personeller (AdSoyad, Email, Gorev, Maas, Telefon, ResimYolu) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)", baglanti);

            komut.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2", txtEmail.Text);
            komut.Parameters.AddWithValue("@p3", txtGorev.Text);
            komut.Parameters.AddWithValue("@p4", txtMaas.Text);
            komut.Parameters.AddWithValue("@p5", txtTelefon.Text);

            // Resmin adresini de 6. mermi olarak ekliyoruz
            komut.Parameters.AddWithValue("@p6", secilenResimYolu);

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Personel başarıyla kaydedildi 🚀");
            this.Close();
        }

        string secilenResimYolu = "";
        private void btnResimSec_Click(object sender, EventArgs e)
        {
            // C#'ın dosya seçme penceresini çağırıyoruz
            OpenFileDialog dosyaSec = new OpenFileDialog();
            dosyaSec.Title = "Personel Profil Resmi Seç";
            dosyaSec.Filter = "Resim Dosyaları |*.jpg;*.jpeg;*.png"; // Sadece resimlere izin ver

            // Eğer adam bir dosya seçip 'Tamam'a (OK) basarsa:
            if (dosyaSec.ShowDialog() == DialogResult.OK)
            {
                secilenResimYolu = dosyaSec.FileName; // Resmin adresini hafızaya al
                pbResim.ImageLocation = secilenResimYolu; // Resmi PictureBox'ta göster (Önizleme)
            }
        }
    }
}
