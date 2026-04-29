using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechCheck_Final
{
    public partial class UC_Personeller : UserControl
    {

        private void dgvPersoneller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Burayı boş bırakabilirsin, sadece hata gitmesi için ekliyoruz.
        }
        // Bağlantı adresini buraya sabitliyoruz ki her yerde tek tek değiştirmek zorunda kalma
        // Satırın sonuna TrustServerCertificate=True eklediğinden emin ol:
        string baglantiYolu = @"Data Source=KEREMKLKS\SQLEXPRESS;Initial Catalog=mnjrosan;Trusted_Connection=True;TrustServerCertificate=True";

        public UC_Personeller()
        {
            InitializeComponent();
        }

        private void UC_Personeller_Load(object sender, EventArgs e)
        {
            dgvPersoneller.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            PersonelListele();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            frmPersonelEkle yeniForm = new frmPersonelEkle();
            yeniForm.ShowDialog();
            PersonelListele(); // Form kapanınca listeyi tazele
        }

        public void PersonelListele()
        {
            try
            {
                SqlConnection baglanti = new SqlConnection(baglantiYolu);
                dgvPersoneller.Rows.Clear();

                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM Personeller", baglanti);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    string adMail = oku["AdSoyad"].ToString() + "\n" + oku["Email"].ToString();
                    string veritabanindakiResimYolu = oku["ResimYolu"].ToString();

                    System.Drawing.Image profilResmi = Properties.Resources.avatar_1;

                    if (!string.IsNullOrEmpty(veritabanindakiResimYolu) && System.IO.File.Exists(veritabanindakiResimYolu))
                    {
                        profilResmi = System.Drawing.Image.FromFile(veritabanindakiResimYolu);
                    }

                    int satirNo = dgvPersoneller.Rows.Add(false, profilResmi, adMail, oku["Gorev"].ToString(), "08:00 h", oku["Maas"].ToString(), oku["Telefon"].ToString());
                    dgvPersoneller.Rows[satirNo].Tag = oku["Id"];
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message);
            }
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            bool silinenVarMi = false;

            try
            {
                baglanti.Open();

                for (int i = dgvPersoneller.Rows.Count - 1; i >= 0; i--)
                {
                    bool isChecked = Convert.ToBoolean(dgvPersoneller.Rows[i].Cells["colSec"].Value);

                    if (isChecked == true)
                    {
                        int silinecekId = Convert.ToInt32(dgvPersoneller.Rows[i].Tag);

                        SqlCommand komut = new SqlCommand("DELETE FROM Personeller WHERE Id = @p1", baglanti);
                        komut.Parameters.AddWithValue("@p1", silinecekId);
                        komut.ExecuteNonQuery();

                        silinenVarMi = true;
                    }
                }
                baglanti.Close();

                if (silinenVarMi)
                {
                    MessageBox.Show("Seçili personeller silindi🗑️", "İşlem Başarılı");
                    PersonelListele();
                }
                else
                {
                    MessageBox.Show("Silebilmek için önce yanlarındaki kutucuklardan en az birini seçmeniz lazım", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası: " + ex.Message);
            }
        }
    }
}