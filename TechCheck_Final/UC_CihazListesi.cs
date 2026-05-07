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
        // Veritabanı bağlantı yolu
        string baglantiYolu = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mnjrosan;Integrated Security=True");

        public UC_CihazListesi()
        {
            InitializeComponent();
        }

        private void UC_CihazListesi_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        // VERİLERİ LİSTELEME - Cihazlar tablosundan direkt çekiyoruz
        public void VerileriGetir()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    string sorgu = @"SELECT Id, 
                                            MusteriAd, 
                                            CihazModel, 
                                            SeriNo, 
                                            Ariza, 
                                            Durum,
                                            KayitTarihi
                                     FROM Cihazlar";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

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

        // ARAMA YAPMA - Müşteri adına veya modele göre filtreler
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    string sorgu = @"SELECT Id, 
                                            MusteriAd, 
                                            CihazModel, 
                                            SeriNo, 
                                            Ariza, 
                                            Durum,
                                            KayitTarihi
                                     FROM Cihazlar
                                     WHERE MusteriAd LIKE @p1 OR CihazModel LIKE @p1";

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
                if (columnName == "colDelete" || columnName == "Delete")
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

        // SİLME METODU
        private void KaydiSil(int id)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM Cihazlar WHERE Id=@p1", baglanti);
                    komut.Parameters.AddWithValue("@p1", id);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Cihaz kaydı başarıyla silindi!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme hatası: " + ex.Message);
                }
            }
        }

        private void dgvCihazListesi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCihazListesi.Columns[e.ColumnIndex].Name == "colEdit") e.Value = Properties.Resources.pencil;
            if (dgvCihazListesi.Columns[e.ColumnIndex].Name == "colDelete") e.Value = Properties.Resources.trash;
        }
    }
}