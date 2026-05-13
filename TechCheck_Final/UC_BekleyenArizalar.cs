using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TechCheck_Final
{
    public partial class UC_BekleyenArizalar : UserControl
    {
        string baglantiYolu = @"Data Source=KEREMKLKS\SQLEXPRESS;Initial Catalog=TechCheckDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        public UC_BekleyenArizalar()
        {
            InitializeComponent();
        }

        private void UC_BekleyenArizalar_Load(object sender, EventArgs e)
        {
            BekleyenleriListele();
        }

        public void BekleyenleriListele()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    // JOIN sorgunu koruduk, Alias (takma isim) kullanarak daha okunaklı yaptık
                    string sorgu = @"
                        SELECT 
                            S.RecordID as [Id], 
                            C.FullName as [Müşteri], 
                            D.Model as [Model], 
                            D.SerialNumber as [Seri No], 
                            S.FailureDescription as [Arıza Tanımı], 
                            S.Status as [Durum], 
                            S.CreatedAt as [Geliş Tarihi]
                        FROM ServiceRecords S
                        INNER JOIN Devices D ON S.DeviceID = D.DeviceID
                        INNER JOIN Customers C ON D.CustomerID = C.CustomerID
                        WHERE S.Status LIKE 'Bek%' OR S.Status = 'Yeni'
                        ORDER BY S.CreatedAt DESC"; // En yeni arıza en üstte

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // DataSource bağlamadan önce temizlik
                    dgvBekleyenler.DataSource = null;
                    dgvBekleyenler.DataSource = dt;

                    // Grid Görsel Ayarları
                    GridAyarla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message, "TechCheck", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridAyarla()
        {
            if (dgvBekleyenler.Columns["Id"] != null) dgvBekleyenler.Columns["Id"].Visible = false;

            // Otomatik genişlik ayarı
            dgvBekleyenler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Satır yüksekliklerini içeriklere göre ayarla (Arıza tanımı uzun olabilir)
            dgvBekleyenler.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvBekleyenler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        // Eğer bir butona basıp statü değiştirirsen bu metodu tekrar çağırırsın
        private void btnYenile_Click(object sender, EventArgs e)
        {
            BekleyenleriListele();
        }
    }
}