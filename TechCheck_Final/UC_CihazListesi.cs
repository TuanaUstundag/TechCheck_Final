using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TechCheck_Final
{
    public partial class UC_CihazListesi : UserControl
    {
        string baglantiYolu = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mnjrosan;Integrated Security=True";

        // Seçili satırın ID'sini tutuyoruz
        private int secilenId = -1;

        // Butonları kod ile oluşturdu ve panelin içine ekledi

        public UC_CihazListesi()
        {
            InitializeComponent();
            btnDuzenle.Enabled = false;
            btnSil.Enabled = false;

        }

        // PANEL'E DÜZENLE VE SİL BUTONLARI
     
        private void UC_CihazListesi_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        // VERİLERİ LİSTELEME
        public void VerileriGetir()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    string sorgu = @"SELECT Id, MusteriAd, CihazModel, SeriNo, Ariza, Durum, KayitTarihi
                                     FROM Cihazlar";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvCihazListesi.DataSource = null;
                    dgvCihazListesi.Columns.Clear();

                    // 1) ÖNCE CHECKBOX SÜTUNUNU EKLE
                    DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn
                    {
                        Name = "colSec",
                        HeaderText = "",
                        Width = 50,
                        ReadOnly = false
                    };
                    dgvCihazListesi.Columns.Add(chk);

                    // 2) VERİYİ BAĞLA
                    dgvCihazListesi.AutoGenerateColumns = true;
                    dgvCihazListesi.DataSource = dt;

                    // 3) CHECKBOX'I EN BAŞA TAŞI
                    dgvCihazListesi.Columns["colSec"].DisplayIndex = 0;

                    // 4) ID SÜTUNUNU GİZLE
                    if (dgvCihazListesi.Columns["Id"] != null)
                        dgvCihazListesi.Columns["Id"].Visible = false;

                    // Seçimi sıfırla
                    secilenId = -1;
                    ButonlariGuncelle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri getirme hatası: " + ex.Message);
            }
        }

        // CHECKBOX'A TIKLAMA - Tek satır seçimi
        private void dgvCihazListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgvCihazListesi.Columns[e.ColumnIndex].Name;

            // CHECKBOX TIKLANDI
            if (colName == "colSec")
            {
                dgvCihazListesi.CommitEdit(DataGridViewDataErrorContexts.Commit);

                bool tikliMi = Convert.ToBoolean(dgvCihazListesi.Rows[e.RowIndex].Cells["colSec"].Value);

                // Önce tüm satırların checkboxını temizle (tek seçimli)
                foreach (DataGridViewRow row in dgvCihazListesi.Rows)
                    row.Cells["colSec"].Value = false;

                if (tikliMi)
                {
                    // Bu satırı seç
                    dgvCihazListesi.Rows[e.RowIndex].Cells["colSec"].Value = true;
                    secilenId = Convert.ToInt32(dgvCihazListesi.Rows[e.RowIndex].Cells["Id"].Value);
                }
                else
                {
                    secilenId = -1;
                }

                ButonlariGuncelle();
            }
        }

        // BUTONLARI AKTİF/PASİF YAP
        private void ButonlariGuncelle()
        {
            bool seciliVar = secilenId > 0;
            btnDuzenle.Enabled = seciliVar;
            btnSil.Enabled = seciliVar;
        }

        // DÜZENLE BUTONU
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (secilenId < 0) return;

            // Seçili satırı bul
            foreach (DataGridViewRow row in dgvCihazListesi.Rows)
            {
                if (Convert.ToBoolean(row.Cells["colSec"].Value))
                {
                    string ad = row.Cells["MusteriAd"].Value?.ToString();
                    string model = row.Cells["CihazModel"].Value?.ToString();
                    string seri = row.Cells["SeriNo"].Value?.ToString();
                    string ariza = row.Cells["Ariza"].Value?.ToString();
                    string durum = row.Cells["Durum"].Value?.ToString();

                    frmDuzenle frm = new frmDuzenle(secilenId, ad, model, seri, ariza, durum);
                    frm.ShowDialog();
                    VerileriGetir();
                    break;
                }
            }
        }

        // SİL BUTONU
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenId < 0) return;

            if (MessageBox.Show("Bu cihaz kaydını silmek istediğinize emin misiniz?", "TechCheck",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                KaydiSil(secilenId);
                VerileriGetir();
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

        // ARAMA
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    string sorgu = @"SELECT Id, MusteriAd, CihazModel, SeriNo, Ariza, Durum, KayitTarihi
                                     FROM Cihazlar
                                     WHERE MusteriAd LIKE @p1 OR CihazModel LIKE @p1";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    da.SelectCommand.Parameters.AddWithValue("@p1", "%" + txtSearch.Text + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvCihazListesi.DataSource = dt;

                    if (dgvCihazListesi.Columns["Id"] != null)
                        dgvCihazListesi.Columns["Id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama hatası: " + ex.Message);
            }
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            if (secilenId < 0) return;

            if (MessageBox.Show("Bu cihaz kaydını silmek istediğinize emin misiniz?", "TechCheck",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                KaydiSil(secilenId);
                VerileriGetir();
            }
        }
    }
}