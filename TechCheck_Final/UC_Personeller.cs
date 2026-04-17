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
            // Tasarım ayarımız: Yazıları dikeyde ortala
            dgvPersoneller.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Sahte verileri (Kristin vs.) sildik! 
            // Form açılır açılmaz direkt SQL'deki GERÇEK verileri listele diyoruz:
            PersonelListele();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            frmPersonelEkle yeniForm = new frmPersonelEkle();

            // ShowDialog sayesinde program burada 'durur'. 
            // Sen formu kapatana kadar aşağıdaki satıra geçmez.
            yeniForm.ShowDialog();

            // İŞTE ÇÖZÜM: Form kapandığı an (yani tam burada) listeleme metodunu çağırıyoruz
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

                // Önce varsayılan (default) avatarımızı elimize alıyoruz
                System.Drawing.Image profilResmi = Properties.Resources.avatar_1;

                // Eğer SQL'den bir yol gelmişse ve o yol bilgisayarda GERÇEKTEN varsa resmi değiştir:
                if (!string.IsNullOrEmpty(veritabanindakiResimYolu) && System.IO.File.Exists(veritabanindakiResimYolu))
                {
                    profilResmi = System.Drawing.Image.FromFile(veritabanindakiResimYolu);
                }

                // Şimdi elimizdeki (gerçek veya varsayılan) resmi tabloya basıyoruz:
                int satirNo = dgvPersoneller.Rows.Add(false, profilResmi, adMail, oku["Gorev"].ToString(), "08:00 h", oku["Maas"].ToString(), oku["Telefon"].ToString());

                // Silme işlemi için ID'yi arka cebe atmayı unutmuyoruz:
                dgvPersoneller.Rows[satirNo].Tag = oku["Id"];
            }

            baglanti.Close();
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mnjrosan;Integrated Security=True
");
            bool silinenVarMi = false;

            // 1. Veritabanı kapısını baştan açıyoruz (Çünkü içeride seri operasyon yapacağız)
            baglanti.Open();

            // 2. DİKKAT: Tablodan çoklu silme yaparken her zaman EN ALTTAN YUKARI doğru saymalıyız (i--). 
            // Yoksa üstten silince alttakilerin sıra numarası kayar ve program hata verir.
            for (int i = dgvPersoneller.Rows.Count - 1; i >= 0; i--)
            {
                // O anki satırın kutucuğu işaretli mi? (True / False)
                bool isChecked = Convert.ToBoolean(dgvPersoneller.Rows[i].Cells["colSec"].Value);

                if (isChecked == true)
                {
                    // Adamın arka cebinden (Tag) SQL'deki o benzersiz ID'sini alıyoruz
                    int silinecekId = Convert.ToInt32(dgvPersoneller.Rows[i].Tag);

                    // SQL'e "Bu ID numaralı adamı kalıcı olarak yok et" emrini veriyoruz
                    SqlCommand komut = new SqlCommand("DELETE FROM Personeller WHERE Id = @p1", baglanti);
                    komut.Parameters.AddWithValue("@p1", silinecekId);
                    komut.ExecuteNonQuery();

                    silinenVarMi = true;
                }
            }

            // 3. İşimizi bitirip mutfak kapısını kilitliyoruz
            baglanti.Close();

            // 4. Operasyon sonucunu ekrana yansıt
            if (silinenVarMi == true)
            {
                MessageBox.Show("Seçili personeller silindi🗑️", "İşlem Başarılı");

                // ÖNEMLİ: Silinen adamların ekrandan da gitmesi için listeyi tazelemek zorundayız!
                PersonelListele();
            }
            else
            {
                MessageBox.Show("Silebilmek için önce yanlarındaki kutucuklardan en az birini seçmeniz lazım", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
