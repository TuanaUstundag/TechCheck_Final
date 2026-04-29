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
        public UC_Personeller()
        {
            InitializeComponent();
        }

        private void dgvPersoneller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
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

            
            PersonelListele();
        }

        public void PersonelListele()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mnjrosan;Integrated Security=True
");
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

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mnjrosan;Integrated Security=True
");
            bool silinenVarMi = false;

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

            if (silinenVarMi == true)
            {
                MessageBox.Show("Seçili personeller silindi🗑️", "İşlem Başarılı");

                PersonelListele();
            }
            else
            {
                MessageBox.Show("Silebilmek için önce yanlarındaki kutucuklardan en az birini seçmeniz lazım", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mnjrosan;Integrated Security=True");

            try
            {
                dgvPersoneller.Rows.Clear(); 

                baglanti.Open();

                string sorgu = "SELECT * FROM Personeller WHERE AdSoyad LIKE @aranan";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@aranan", "%" + txtArama.Text + "%");

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
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Arama hatası: " + ex.Message);
            }
        }

        private void btnPersonelDuzenle_Click(object sender, EventArgs e)
        {
            
            int isaretlenenSayisi = 0;
            int seciliId = -1;

            foreach (DataGridViewRow satir in dgvPersoneller.Rows)
            {
                bool isChecked = Convert.ToBoolean(satir.Cells["colSec"].Value);
                if (isChecked)
                {
                    isaretlenenSayisi++;
                    seciliId = Convert.ToInt32(satir.Tag);
                }
            }

           
            if (isaretlenenSayisi == 0)
            {
                MessageBox.Show("Düzenlemek için önce bir personel seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (isaretlenenSayisi > 1)
            {
                MessageBox.Show("Aynı anda sadece 1 personel düzenlenebilir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            frmPersonelDuzenle duzenleForm = new frmPersonelDuzenle();
            duzenleForm.PersonelId = seciliId;
            duzenleForm.ShowDialog();

            
            PersonelListele();
        
        }
    }
}
