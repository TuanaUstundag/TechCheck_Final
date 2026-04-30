using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TechCheck_Final
{
    public partial class UC_CihazListesi : UserControl
    {
        // 1. BAĞLANTI: TechCheckDB veritabanı ve senin SQL Server ismin
        string baglantiYolu = @"Data Source=KEREMKLKS\SQLEXPRESS;Initial Catalog=TechCheckDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        public UC_CihazListesi()
        {
            InitializeComponent();
        }

        private void UC_CihazListesi_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        // VERİLERİ LİSTELEME (Devices, Customers ve ServiceRecords tablolarını birleştirir)
        public void VerileriGetir()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    // "as" kullanarak SQL isimlerini senin C# butonlarının beklediği isimlere çevirdik
                    string sorgu = @"SELECT D.DeviceID as 'Id', 
                                            C.FullName as 'MusteriAd', 
                                            D.Model as 'CihazModel', 
                                            D.SerialNumber as 'SeriNo',
                                            S.FailureDescription as 'Ariza', 
                                            S.Status as 'Durum' 
                                     FROM Devices D 
                                     LEFT JOIN Customers C ON D.CustomerID = C.CustomerID
                                     LEFT JOIN ServiceRecords S ON D.DeviceID = S.DeviceID";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // GridView'i sıfırlayıp yeniden dolduruyoruz (Hataları önlemek için)
                    dgvCihazListesi.DataSource = null;
                    dgvCihazListesi.Columns.Clear();
                    dgvCihazListesi.AutoGenerateColumns = true;
                    dgvCihazListesi.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri getirme hatası: " + ex.Message);
            }
        }

        // ARAMA YAPMA (Müşteri adına veya modele göre filtreler)
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    string sorgu = @"SELECT D.DeviceID as 'Id', C.FullName as 'MusteriAd', D.Model as 'CihazModel', D.SerialNumber as 'SeriNo', S.FailureDescription as 'Ariza', S.Status as 'Durum' 
                                     FROM Devices D 
                                     LEFT JOIN Customers C ON D.CustomerID = C.CustomerID
                                     LEFT JOIN ServiceRecords S ON D.DeviceID = S.DeviceID
                                     WHERE C.FullName LIKE @p1 OR D.Model LIKE @p1";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    da.SelectCommand.Parameters.AddWithValue("@p1", "%" + txtSearch.Text + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvCihazListesi.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama hatası: " + ex.Message);
            }
        }

        // SİLME VE DÜZENLEME TIKLAMA OLAYI
        private void dgvCihazListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = dgvCihazListesi.Columns[e.ColumnIndex].Name;

                // SİLME İŞLEMİ
                if (columnName == "colDelete" || columnName == "Delete") // Guna otomatik isim verebilir, ikisini de kontrol ediyoruz
                {
                    int id = Convert.ToInt32(dgvCihazListesi.Rows[e.RowIndex].Cells["Id"].Value);
                    if (MessageBox.Show("Bu cihaz kaydını silmek istediğinize emin misiniz?", "TechCheck", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        KaydiSil(id);
                        VerileriGetir();
                    }
                }

                // DÜZENLEME İŞLEMİ
                if (columnName == "colEdit" || columnName == "Edit")
                {
                    int id = Convert.ToInt32(dgvCihazListesi.Rows[e.RowIndex].Cells["Id"].Value);
                    string ad = dgvCihazListesi.Rows[e.RowIndex].Cells["MusteriAd"].Value?.ToString();
                    string model = dgvCihazListesi.Rows[e.RowIndex].Cells["CihazModel"].Value?.ToString();
                    string seri = dgvCihazListesi.Rows[e.RowIndex].Cells["SeriNo"].Value?.ToString();
                    string ariza = dgvCihazListesi.Rows[e.RowIndex].Cells["Ariza"].Value?.ToString();
                    string durum = dgvCihazListesi.Rows[e.RowIndex].Cells["Durum"].Value?.ToString();

                    frmDuzenle frm = new frmDuzenle(id, ad, model, seri, ariza, durum);
                    frm.ShowDialog();
                    VerileriGetir();
                }
            }
        }

        private void KaydiSil(int id)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                try
                {
                    baglanti.Open();
                    // TechCheckDB yapısında ana cihaz tablosu 'Devices'dır
                    SqlCommand komut = new SqlCommand("DELETE FROM Devices WHERE DeviceID=@p1", baglanti);
                    komut.Parameters.AddWithValue("@p1", id);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Cihaz kaydı başarıyla silindi!");
                }
                catch (Exception ex) { MessageBox.Show("Silme hatası: " + ex.Message); }
            }
        }

        private void dgvCihazListesi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // İkon yollarını kendi projerine göre kontrol etmelisin
            if (dgvCihazListesi.Columns[e.ColumnIndex].Name == "colEdit") e.Value = Properties.Resources.pencil;
            if (dgvCihazListesi.Columns[e.ColumnIndex].Name == "colDelete") e.Value = Properties.Resources.trash;
        }
    }
}