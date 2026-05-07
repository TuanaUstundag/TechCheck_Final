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
        string secilenResimYolu = "";
        public frmPersonelEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mnjrosan;Integrated Security=True
");
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand(
                "INSERT INTO Personeller (AdSoyad, Email, Gorev, Maas, Telefon, ResimYolu) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)",
                baglanti);

            komut.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2", txtEmail.Text);
            komut.Parameters.AddWithValue("@p3", txtGorev.Text);
            komut.Parameters.AddWithValue("@p4", txtMaas.Text);
            komut.Parameters.AddWithValue("@p5", txtTelefon.Text);

            
            string kaydedilecekYol = string.IsNullOrEmpty(secilenResimYolu) ? "" : secilenResimYolu;
            komut.Parameters.AddWithValue("@p6", kaydedilecekYol);

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Personel başarıyla kaydedildi 🚀");
            this.Close();
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            
        }

        private void frmPersonelEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
