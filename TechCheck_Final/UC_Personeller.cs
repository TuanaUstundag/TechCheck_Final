using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace TechCheck_Final
{
    public partial class UC_Personeller : UserControl
    {
        string baglantiYolu = @"Data Source=KEREMKLKS\SQLEXPRESS;Initial Catalog=TechCheckDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        public UC_Personeller()
        {
            InitializeComponent();
        }

        private void UC_Personeller_Load(object sender, EventArgs e)
        {
            dgvPersoneller.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            PersonelListele();
        }

        public void PersonelListele()
        {
            VeriGetir("SELECT * FROM Users");
            
            frmKayitOl yeniForm = new frmKayitOl(this);
            yeniForm.ShowDialog();

            
            PersonelListele();
        }

        private void VeriGetir(string sorgu, SqlParameter parametre = null)
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    // dgvPersoneller.Rows.Clear(); // Eğer sütunları tasarımda elle eklediysen bunu kullan
                    // Eğer dgvPersoneller.DataSource kullanıyorsan Rows.Clear hata verir. 
                    // Senin kodun Rows.Add üzerine kurulu, o yüzden temizlemeye devam ediyoruz:
                    dgvPersoneller.Rows.Clear();

                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    if (parametre != null) komut.Parameters.Add(parametre);

                    SqlDataReader oku = komut.ExecuteReader();

                    while (oku.Read())
                    {
                        // Username ve Email null kontrolü
                        string username = oku["Username"]?.ToString() ?? "Bilinmiyor";
                        string email = oku["Email"]?.ToString() ?? "-";
                        string adMail = $"{username}\n{email}";

                        string resimYolu = oku["ProfilePicture"]?.ToString();

                        // Resim Yükleme: MemoryStream kullanarak dosya kilitlemeyi önlüyoruz
                        Image profilResmi = Properties.Resources.avatar_1; // Varsayılan resim

                        if (!string.IsNullOrEmpty(resimYolu) && File.Exists(resimYolu))
                        {
                            try
                            {
                                using (FileStream fs = new FileStream(resimYolu, FileMode.Open, FileAccess.Read))
                                {
                                    profilResmi = Image.FromStream(fs);
                                }
                            }
                            catch { /* Resim okunamazsa varsayılan kalsın */ }
                        }

                        // Satırı ekle
                        int satirNo = dgvPersoneller.Rows.Add(
                            false,
                            profilResmi,
                            adMail,
                            oku["Role"]?.ToString() ?? "Personel",
                            "08:00 h",
                            oku["Salary"]?.ToString() ?? "0",
                            oku["Phone"]?.ToString() ?? "-"
                        );

                        // ID bilgisini Tag içinde saklıyoruz (Silme ve Düzenleme için)
                        dgvPersoneller.Rows[satirNo].Tag = oku["UserID"];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme Hatası: " + ex.Message, "TechCheck", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili personelleri silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    baglanti.Open();
                    bool herhangiBirKayitSilindiMi = false;

                    foreach (DataGridViewRow satir in dgvPersoneller.Rows)
                    {
                        if (Convert.ToBoolean(satir.Cells[0].Value) == true)
                        {
                            int id = Convert.ToInt32(satir.Tag);
                            SqlCommand silKomut = new SqlCommand("DELETE FROM Users WHERE UserID = @id", baglanti);
                            silKomut.Parameters.AddWithValue("@id", id);
                            silKomut.ExecuteNonQuery();
                            herhangiBirKayitSilindiMi = true;
                        }
                    }

                    if (herhangiBirKayitSilindiMi)
                    {
                        MessageBox.Show("Seçili personeller başarıyla silindi.");
                        PersonelListele();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Silme Hatası: " + ex.Message); }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            // Performans için kısa metinlerde sorgu atmayabilirsin veya:
            string sorgu = "SELECT * FROM Users WHERE Username LIKE @p1 OR Email LIKE @p1";
            VeriGetir(sorgu, new SqlParameter("@p1", "%" + txtArama.Text + "%"));
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            frmKayitOl frm = new frmKayitOl(this);
            frm.ShowDialog();
            // Kayıt formunda listeyi yenilettiğimiz için burada tekrar çağırmaya gerek yok ama garanti olsun:
            PersonelListele();
        }

        private void btnPersonelDuzenle_Click(object sender, EventArgs e)
        {
            // Tekli seçim kontrolü
            int seciliId = -1;
            int secilenSayisi = 0;

            foreach (DataGridViewRow satir in dgvPersoneller.Rows)
            {
                if (Convert.ToBoolean(satir.Cells[0].Value) == true)
                {
                    seciliId = Convert.ToInt32(satir.Tag);
                    secilenSayisi++;
                }
            }

            if (secilenSayisi == 1)
            {
                // frmPersonelDuzenle formunda 'public int PersonelId' değişkeni olmalı
                frmPersonelDuzenle frm = new frmPersonelDuzenle();
                frm.PersonelId = seciliId;
                frm.ShowDialog();
                PersonelListele();
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek için (sadece) bir personel seçin.");
            }
        }
    }
}