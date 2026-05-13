using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TechCheck_Final
{
    public partial class UC_Anasayfa : UserControl
    {
        // Bağlantı yolunun doğruluğundan emin ol (KEREMKLKS\SQLEXPRESS ve TechCheckDB)
        string baglantiYolu = @"Data Source=KEREMKLKS\SQLEXPRESS;Initial Catalog=TechCheckDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        public UC_Anasayfa()
        {
            InitializeComponent();
        }

        private void UC_Anasayfa_Load(object sender, EventArgs e)
        {
            // Sayfa her açıldığında verileri tazele
            IstatistikleriGetir();
            SonCihazlariListele();
        }

        private void IstatistikleriGetir()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    baglanti.Open();

                    // 1. Kayıtlı Cihaz Sayısı
                    SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Devices", baglanti);
                    object result1 = cmd1.ExecuteScalar();
                    lblToplamCihaz.Text = result1 != null ? result1.ToString() : "0";

                    // 2. Toplam Kullanıcı Sayısı
                    SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM Users", baglanti);
                    object result2 = cmd2.ExecuteScalar();
                    lblToplamPersonel.Text = result2 != null ? result2.ToString() : "0";

                    // 3. Bekleyen Arıza Sayısı
                    SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM ServiceRecords WHERE Status IN ('Beklemede', 'Yeni', 'Bekliyor')", baglanti);
                    object result3 = cmd3.ExecuteScalar();
                    lblBekleyenCihaz.Text = result3 != null ? result3.ToString() : "0";
                }
            }
            catch (Exception ex)
            {
                // Bağlantı hatası olsa bile arayüzün çökmesini engelle, 0 yazdır
                lblToplamCihaz.Text = "0";
                lblToplamPersonel.Text = "0";
                lblBekleyenCihaz.Text = "0";
                Console.WriteLine("Dashboard İstatistik Hatası: " + ex.Message);
            }
        }

        public void SonCihazlariListele()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    // Sorgu içine 'Kayıt Yok' yerine daha profesyonel '-' ekledim
                    string sorgu = @"
                        SELECT TOP 10 
                            D.Model as [Cihaz Modeli], 
                            D.SerialNumber as [Seri No], 
                            ISNULL(S.Status, 'Servis Kaydı Yok') as [Durum], 
                            ISNULL(S.FailureDescription, '-') as [Arıza Tanımı]
                        FROM Devices D
                        LEFT JOIN ServiceRecords S ON D.DeviceID = S.DeviceID
                        ORDER BY D.DeviceID DESC";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Veri bağlama
                    guna2DataGridView1.DataSource = null; // Önceki veriyi temizle
                    guna2DataGridView1.DataSource = dt;

                    // Grid Tasarım Ayarları
                    if (guna2DataGridView1.Columns.Count > 0)
                    {
                        guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        guna2DataGridView1.ReadOnly = true;
                        guna2DataGridView1.AllowUserToAddRows = false; // Boş satır eklemeyi kapat
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Son Cihazlar Listeleme Hatası: " + ex.Message);
            }
        }
    }
}