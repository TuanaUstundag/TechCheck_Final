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
        // Bağlantı cümlesini buraya da ekliyoruz (New Record sayfasındakiyle aynı olmalı)
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TechCheckDB;Integrated Security=True");

        public void Listele()
        {
            try
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM Cihazlar"; // Tablodaki her şeyi seç
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt); // SQL'den gelen verileri bu sanal tabloya doldur
                dgvCihazListesi.AutoGenerateColumns = false; // SQL'in kafasına göre sütun eklemesini engeller
                dgvCihazListesi.DataSource = dt;
                

                dgvCihazListesi.DataSource = dt; // Guna2DataGridView'in kaynağı bu tablo olsun
                baglanti.Close();
               
                
                // Toplam sütun sayısından 1 ve 2 çıkararak en sona atıyoruz.
                dgvCihazListesi.Columns["colEdit"].DisplayIndex = dgvCihazListesi.ColumnCount - 2;
                dgvCihazListesi.Columns["colDelete"].DisplayIndex = dgvCihazListesi.ColumnCount - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu: " + ex.Message);
            }
        }
        public UC_CihazListesi()
        {
            InitializeComponent();
        }

        private void cihazıDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Seçili satırı silmek için basit bir kod:
            if (dgvCihazListesi.SelectedRows.Count > 0)
            {
                dgvCihazListesi.Rows.RemoveAt(dgvCihazListesi.SelectedRows[0].Index);
                MessageBox.Show("Cihaz kaydı başarıyla silindi!", "TechCheck", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UC_CihazListesi_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Arama kutusuna her harf yazıldığında bu kod çalışır
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                // LIKE komutu ile hem Müşteri Adı hem de Cihaz Modeli içinde arama yapıyoruz
                string sorgu = "SELECT * FROM Cihazlar WHERE MusteriAd LIKE @p1 OR CihazModel LIKE @p1";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                // % işareti "içinde geçen her şeyi bul" demektir
                da.SelectCommand.Parameters.AddWithValue("@p1", "%" + txtSearch.Text + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCihazListesi.DataSource = dt;

                baglanti.Close();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        private void kaydıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCihazListesi.SelectedRows.Count > 0) // Bir satır seçili mi?
            {
                DialogResult onay = MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "TechCheck Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (onay == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvCihazListesi.SelectedRows[0].Cells["Id"].Value); // Seçili satırın ID'sini al

                    baglanti.Open();
                    SqlCommand silKomutu = new SqlCommand("DELETE FROM Cihazlar WHERE Id=@p1", baglanti);
                    silKomutu.Parameters.AddWithValue("@p1", id);
                    silKomutu.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Kayıt başarıyla silindi!");
                    Listele(); // Listeyi güncelle ki silindiğini görelim
                }
            }
            }

        private void dgvCihazListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. GÜVENLİK: Kullanıcı yanlışlıkla tablo başlığına tıklarsa hata vermesin
            if (e.RowIndex >= 0)
            {
                string columnName = dgvCihazListesi.Columns[e.ColumnIndex].Name;

                // SİLME İKONUNA TIKLANDIYSA
                if (columnName == "colDelete")
                {
                    int id = Convert.ToInt32(dgvCihazListesi.Rows[e.RowIndex].Cells["Id"].Value);

                    if (MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "TechCheck", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        KaydiSil(id); // Veritabanından silme işlemini yapar

                        // 2. İŞTE ÇÖZÜM: Tabloyu hemen değil, tıklama olayı bitince güvenlice yenile
                        this.BeginInvoke(new Action(() => VerileriGetir()));
                    }
                }

                // DÜZENLEME İKONUNA TIKLANDIYSA
                if (columnName == "colEdit")
                {
                    // ... (Buradaki düzenleme kodlarına hiç dokunma, onlar kalsın) ...
                }
            }

            // DÜZENLEME İKONUNA TIKLANDIYSA
            if (dgvCihazListesi.Columns[e.ColumnIndex].Name == "colEdit")
            {
                // Seçili satırdaki verileri alıyoruz
                int id = Convert.ToInt32(dgvCihazListesi.Rows[e.RowIndex].Cells["Id"].Value);
                string ad = dgvCihazListesi.Rows[e.RowIndex].Cells["MusteriAd"].Value.ToString();
                string model = dgvCihazListesi.Rows[e.RowIndex].Cells["CihazModel"].Value.ToString();
                string seri = dgvCihazListesi.Rows[e.RowIndex].Cells["SeriNo"].Value.ToString();
                string ariza = dgvCihazListesi.Rows[e.RowIndex].Cells["Ariza"].Value.ToString();
                string durum = dgvCihazListesi.Rows[e.RowIndex].Cells["Durum"].Value.ToString();

                // Düzenleme formunu oluştur ve verileri gönder
                frmDuzenle frm = new frmDuzenle(id, ad, model, seri, ariza, durum);
                frm.ShowDialog(); // Formu aç

                VerileriGetir(); // Form kapandığında listeyi yenile

            }
        }
        private void KaydiSil(int id)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                SqlCommand komut = new SqlCommand("DELETE FROM Cihazlar WHERE Id=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", id);
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Kayıt başarıyla silindi!", "TechCheck", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Silme hatası: " + ex.Message);
            }
        }

        private void dgvCihazListesi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
          

            // Düzenle (Kalem) İkonu Sütunu
            if (dgvCihazListesi.Columns[e.ColumnIndex].Name == "colEdit")
            {
               
                e.Value = Properties.Resources.pencil; 
            }

            // Sil (Çöp Kutusu) İkonu Sütunu
            if (dgvCihazListesi.Columns[e.ColumnIndex].Name == "colDelete")
            {
              
                e.Value = Properties.Resources.trash; 
            }

        }
        public void VerileriGetir()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cihazlar", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // 1. Kendi tasarımımız dışında sütun oluşmasını engelliyoruz
                ((DataGridView)dgvCihazListesi).AutoGenerateColumns = false;

                // 2. Veriyi yüklüyoruz
                dgvCihazListesi.DataSource = dt;

                // 3. İkonların en sağda ve doğru sırada durduğundan emin oluyoruz
                if (dgvCihazListesi.Columns.Contains("colEdit") && dgvCihazListesi.Columns.Contains("colDelete"))
                {
                    dgvCihazListesi.Columns["colEdit"].DisplayIndex = dgvCihazListesi.Columns.Count - 2;
                    dgvCihazListesi.Columns["colDelete"].DisplayIndex = dgvCihazListesi.Columns.Count - 1;
                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                // MessageBox.Show("Hata: " + ex.Message);
            }

        }
            

    }
}
