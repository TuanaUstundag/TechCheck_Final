using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TechCheck_Final  // ← BU EKSIKTI!
{
    public partial class UC_BekleyenArizalar : UserControl
    {
        string baglantiYolu = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mnjrosan;Integrated Security=True";

        public UC_BekleyenArizalar()
        {
            InitializeComponent();
            this.Load += UC_BekleyenArizalar_Load;
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
                    // Sütun isimleri Designer'daki DataPropertyName ile eşleşmeli
                    string sorgu = @"SELECT Id, Ariza, SeriNo, CihazModel, MusteriAd, Durum, KayitTarihi
                                     FROM Cihazlar 
                                     WHERE Durum LIKE '%Bekliyor%' 
                                        OR Durum LIKE '%Beklemede%'";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvBekleyenler.DataSource = null;
                    dgvBekleyenler.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}