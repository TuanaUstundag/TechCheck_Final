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
        string baglantiYolu = @"Data Source=KEREMKLKS\SQLEXPRESS;Initial Catalog=TechCheckDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        private int secilenId = -1;

        public UC_CihazListesi()
        {
            InitializeComponent();
            btnDuzenle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void UC_CihazListesi_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        public void VerileriGetir(string aramaMetni = "")
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    string sorgu = @"SELECT DeviceID as Id, Brand, Model, SerialNumber, PurchaseDate FROM Devices";

                    // Arama metni varsa sorguya ekliyoruz
                    if (!string.IsNullOrEmpty(aramaMetni))
                    {
                        sorgu += " WHERE Brand LIKE @p1 OR Model LIKE @p1 OR SerialNumber LIKE @p1";
                    }

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    if (!string.IsNullOrEmpty(aramaMetni))
                        da.SelectCommand.Parameters.AddWithValue("@p1", "%" + aramaMetni + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Grid'i temizle ama sütun yapısını koru
                    dgvCihazListesi.DataSource = null;
                    dgvCihazListesi.Columns.Clear();

                    // 1) Checkbox Sütununu Ekle
                    
                    DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn
                    {
                        Name = "colSec",
                        HeaderText = "Seç",
                        Width = 40
                    };
                    dgvCihazListesi.Columns.Add(chk);

                    // 2) Veriyi bağla
                    dgvCihazListesi.DataSource = dt;

                    // 3) Görsel Ayarlar ve Türkçeleştirme
                    GridFormatla();

                    secilenId = -1;
                    ButonlariGuncelle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri getirme hatası: " + ex.Message);
            }
        }

        private void GridFormatla()
        {
            if (dgvCihazListesi.Columns["Id"] != null) dgvCihazListesi.Columns["Id"].Visible = false;
            if (dgvCihazListesi.Columns["Brand"] != null) dgvCihazListesi.Columns["Brand"].HeaderText = "Marka";
            if (dgvCihazListesi.Columns["Model"] != null) dgvCihazListesi.Columns["Model"].HeaderText = "Model";
            if (dgvCihazListesi.Columns["SerialNumber"] != null) dgvCihazListesi.Columns["SerialNumber"].HeaderText = "Seri No";
            if (dgvCihazListesi.Columns["PurchaseDate"] != null) dgvCihazListesi.Columns["PurchaseDate"].HeaderText = "Kayıt Tarihi";

            dgvCihazListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvCihazListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvCihazListesi.Columns[e.ColumnIndex].Name == "colSec")
            {
                dgvCihazListesi.CommitEdit(DataGridViewDataErrorContexts.Commit);
                bool tikliMi = Convert.ToBoolean(dgvCihazListesi.Rows[e.RowIndex].Cells["colSec"].Value);

                // Tekil seçim mantığı
                foreach (DataGridViewRow row in dgvCihazListesi.Rows)
                    row.Cells["colSec"].Value = false;

                if (tikliMi)
                {
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

        private void ButonlariGuncelle()
        {
            btnDuzenle.Enabled = secilenId > 0;
            btnSil.Enabled = secilenId > 0;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenId < 0) return;

            if (MessageBox.Show("Bu cihaz kaydını silmek istediğinize emin misiniz?", "TechCheck",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    try
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("DELETE FROM Devices WHERE DeviceID=@p1", baglanti);
                        komut.Parameters.AddWithValue("@p1", secilenId);
                        komut.ExecuteNonQuery();
                        VerileriGetir();
                    }
                    catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
                }
            }
        }

        // ARAMA - VerileriGetir metodunu kullanarak başlıkları koruyoruz
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            VerileriGetir(txtSearch.Text);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            // frmDuzenle çağırma mantığın burada kalabilir
            // ... (Aynı kodları buraya yazabilirsin)
        }
    }
}