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
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mnjrosan;Integrated Security=True");

        public UC_CihazListesi()
        {
            InitializeComponent();
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
                string sorgu = "SELECT * FROM Cihazlar WHERE MusteriAd LIKE @p1 OR CihazModel LIKE @p1"; // @p1 parametresi, txtSearch.Text içindeki değeri alır ve % ile sarar, böylece içinde geçen her şeyi bulur

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                // % işareti "içinde geçen her şeyi bul" demektir
                da.SelectCommand.Parameters.AddWithValue("@p1", "%" + txtSearch.Text + "%");
                //% (Yüzde İşareti): SQL dilinde "Her şey gelebilir" anlamına gelen bir joker karakterdir (wildcard).

                DataTable dt = new DataTable();
                da.Fill(dt); // Arama sonuçlarını bu tabloya doldurur
                dgvCihazListesi.DataSource = dt; // Arama sonuçlarını tabloya yansıtır

                baglanti.Close();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        private void dgvCihazListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. GÜVENLİK: Kullanıcı yanlışlıkla tablo başlığına tıklarsa hata vermesin
            if (e.RowIndex >= 0) // Sadece veri satırlarına tıklanırsa işlemi yap
            {
                string columnName = dgvCihazListesi.Columns[e.ColumnIndex].Name; // Tıklanan sütunun adını alır

                // SİLME İKONUNA TIKLANDIYSA
                if (columnName == "colDelete")
                {
                    int id = Convert.ToInt32(dgvCihazListesi.Rows[e.RowIndex].Cells["Id"].Value);

                    if (MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "TechCheck", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        KaydiSil(id); // Veritabanından silme işlemini yapar

                        
                        this.BeginInvoke(new Action(() => VerileriGetir()));
                        //BeginInvoke, işlemi güvenli bir şekilde sıraya koyar ve mevcut olay tamamlandıktan sonra çalıştırır. Böylece, tıklama olayının bitmesini bekler ve ardından tabloyu yeniler, böylece hata olmaz.

                    }
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
               
                e.Value = Properties.Resources.pencil; // Proje kaynaklarına eklediğimiz kalem ikonunu burada kullanıyoruz
                //e.Value: Hücrenin içindeki asıl değerdir(normalde boştur veya metindir).
                //Properties.Resources.pencil: Projenin kaynaklar (Resources) klasörüne daha önce eklediğin pencil isimli görseli çağırır.
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
                    dgvCihazListesi.Columns["colEdit"].DisplayIndex = dgvCihazListesi.Columns.Count - 2; // Toplam sütun sayısından 2 çıkararak en sona atıyoruz.
                    dgvCihazListesi.Columns["colDelete"].DisplayIndex = dgvCihazListesi.Columns.Count - 1; // Toplam sütun sayısından 1 çıkararak en sona atıyoruz.
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
