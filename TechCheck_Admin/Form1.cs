using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace TechCheck_Admin
{
    public partial class Form1 : Form
    {
        // Veritabaný baðlantýmýz
        string baglantiYolu = "Data Source=TechCheck.db;Version=3;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Program açýldýðýnda Admins tablosu yoksa oluþturur
            using (SQLiteConnection baglanti = new SQLiteConnection(baglantiYolu))
            {
                baglanti.Open();
                string sql = "CREATE TABLE IF NOT EXISTS Admins (Id INTEGER PRIMARY KEY AUTOINCREMENT, KullaniciAdi TEXT, Sifre TEXT)";
                using (SQLiteCommand komut = new SQLiteCommand(sql, baglanti))
                {
                    komut.ExecuteNonQuery();
                }

                // Veritabanýnda hiç admin yoksa, test için varsayýlan bir admin ekleyelim
                string checkSql = "SELECT COUNT(*) FROM Admins";
                using (SQLiteCommand checkCmd = new SQLiteCommand(checkSql, baglanti))
                {
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count == 0)
                    {
                        string insertSql = "INSERT INTO Admins (KullaniciAdi, Sifre) VALUES ('admin', '1234')";
                        using (SQLiteCommand insertCmd = new SQLiteCommand(insertSql, baglanti))
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
            using (SQLiteConnection baglanti = new SQLiteConnection(baglantiYolu))
            {
                baglanti.Open();
                string sql = "SELECT COUNT(*) FROM Admins WHERE KullaniciAdi=@k1 AND Sifre=@s1";
                using (SQLiteCommand komut = new SQLiteCommand(sql, baglanti))
                {
                    komut.Parameters.AddWithValue("@k1", txtKullanici.Text);
                    komut.Parameters.AddWithValue("@s1", txtSifre.Text);

                    int sonuc = Convert.ToInt32(komut.ExecuteScalar());

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Giriþ Baþarýlý!", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Hatalý Kullanýcý Adý veya Þifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}