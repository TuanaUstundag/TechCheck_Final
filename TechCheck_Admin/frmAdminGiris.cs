using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TechCheck_Admin
{
    public partial class frmAdminGiris : Form
    {
        // Veritabaný baðlantýmýz
        // LocalDB ile TLS el sýkýþmasý sorunlarýný önlemek için geliþtirme ortamýnda Encrypt devre dýþý býrakýldý
        // ve sunucu sertifikasý kabul ediliyor. Üretimde geçerli bir sertifika kullanýn.
        string baglantiYolu = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mnjrosan;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        public frmAdminGiris()
        {
            InitializeComponent();
        }

        private void frmAdminGiris_Load(object sender, EventArgs e)
        {
            // Program açýldýðýnda Admins tablosu yoksa oluþturur
            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                baglanti.Open();
                string sql = "IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Admins') CREATE TABLE Admins (Id INT PRIMARY KEY IDENTITY(1,1), KullaniciAdi NVARCHAR(50), Sifre NVARCHAR(50))";
                using (SqlCommand komut = new SqlCommand(sql, baglanti))
                {
                    komut.ExecuteNonQuery();
                }

                // Veritabanýnda hiç admin yoksa, test için varsayýlan bir admin ekleyelim
                string checkSql = "SELECT COUNT(*) FROM Admins";
                using (SqlCommand checkCmd = new SqlCommand(checkSql, baglanti))
                {
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count == 0)
                    {
                        string insertSql = "INSERT INTO Admins (KullaniciAdi, Sifre) VALUES ('admin', '1234')";
                        using (SqlCommand insertCmd = new SqlCommand(insertSql, baglanti))
                        {
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        // Tasarýmdaki btnGiris butonuna çift týklayýnca bu kod çalýþacak
        private void btnGiris_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                baglanti.Open();
                string sql = "SELECT COUNT(*) FROM Admins WHERE KullaniciAdi=@k1 AND Sifre=@s1";
                using (SqlCommand komut = new SqlCommand(sql, baglanti))
                {
                    komut.Parameters.AddWithValue("@k1", txtKullanici.Text);
                    komut.Parameters.AddWithValue("@s1", txtSifre.Text);

                    int sonuc = Convert.ToInt32(komut.ExecuteScalar());

                    if (sonuc > 0)
                    {
                        // Admin dashboard formunu buraya yaz, arkadaþ ne isim verdiyse
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                }
            }
        }

        
    }
}