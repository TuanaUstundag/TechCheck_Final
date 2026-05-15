using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TechCheck_Admin
{
    public partial class Dashboard : Form
    {
        string baglantiYolu = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mnjrosan;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // LocalDB'yi otomatik başlat
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "sqllocaldb",
                    Arguments = "start MSSQLLocalDB",
                    CreateNoWindow = true,
                    UseShellExecute = false
                });
            }
            catch { }

            KullanicilariYukle();
            PersonelleriYukle();
            CihazlariYukle();
            IstatistikleriGuncelle();
        }

        private void IstatistikleriGuncelle()
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                baglanti.Open();
                lblKullaniciSayi.Text = new SqlCommand("SELECT COUNT(*) FROM Kullanicilar", baglanti).ExecuteScalar().ToString();
                lblPersonelSayi.Text = new SqlCommand("SELECT COUNT(*) FROM Personeller", baglanti).ExecuteScalar().ToString();
                lblCihazSayi.Text = new SqlCommand("SELECT COUNT(*) FROM Cihazlar", baglanti).ExecuteScalar().ToString();
            }
        }

        private void KullanicilariYukle()
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, KullaniciAdi, KullaniciRolu, Email, Maas, Telefon FROM Kullanicilar", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKullanicilar.DataSource = dt;
            }
        }

        private void PersonelleriYukle()
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, AdSoyad, Email, Gorev, Maas, Telefon FROM Personeller", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPersoneller.DataSource = dt;
            }
        }

        private void CihazlariYukle()
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, MusteriAd, CihazModel, SeriNo, Ariza, Durum, AtananPersonel, KayitTarihi FROM Cihazlar", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCihazlar.DataSource = dt;

                // Ata buton sütunu yoksa ekle
                if (!dgvCihazlar.Columns.Contains("btnAta"))
                {
                    DataGridViewButtonColumn btnAta = new DataGridViewButtonColumn();
                    btnAta.Name = "btnAta";
                    btnAta.HeaderText = "İşlem";
                    btnAta.Text = "Ata";
                    btnAta.UseColumnTextForButtonValue = true;
                    dgvCihazlar.Columns.Add(btnAta);
                }
            }
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            if (dgvKullanicilar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = Convert.ToInt32(dgvKullanicilar.SelectedRows[0].Cells["Id"].Value);
            if (MessageBox.Show("Bu kullanıcı silinsin mi?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    baglanti.Open();
                    new SqlCommand($"DELETE FROM Kullanicilar WHERE Id={id}", baglanti).ExecuteNonQuery();
                }
                KullanicilariYukle();
                IstatistikleriGuncelle();
            }
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            if (dgvPersoneller.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir personel seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = Convert.ToInt32(dgvPersoneller.SelectedRows[0].Cells["Id"].Value);
            if (MessageBox.Show("Bu personel silinsin mi?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    baglanti.Open();
                    new SqlCommand($"DELETE FROM Personeller WHERE Id={id}", baglanti).ExecuteNonQuery();
                }
                PersonelleriYukle();
                IstatistikleriGuncelle();
            }
        }

        private void btnCihazSil_Click(object sender, EventArgs e)
        {
            if (dgvCihazlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir cihaz seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = Convert.ToInt32(dgvCihazlar.SelectedRows[0].Cells["Id"].Value);
            if (MessageBox.Show("Bu kayıt silinsin mi?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    baglanti.Open();
                    new SqlCommand($"DELETE FROM Cihazlar WHERE Id={id}", baglanti).ExecuteNonQuery();
                }
                CihazlariYukle();
                IstatistikleriGuncelle();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvCihazlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvCihazlar.Columns[e.ColumnIndex].Name != "btnAta") return;

            int cihazId = Convert.ToInt32(dgvCihazlar.Rows[e.RowIndex].Cells["Id"].Value);

            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                baglanti.Open();
                // Kullanicilar tablosundan Teknisyen rolündekileri çek
                SqlDataAdapter da = new SqlDataAdapter("SELECT KullaniciAdi FROM Kullanicilar WHERE KullaniciRolu='Teknisyen'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Form secimForm = new Form();
                secimForm.Text = "Personel Seç";
                secimForm.Size = new System.Drawing.Size(300, 200);
                secimForm.StartPosition = FormStartPosition.CenterParent;

                ComboBox cmb = new ComboBox();
                cmb.Location = new System.Drawing.Point(20, 30);
                cmb.Width = 240;
                foreach (DataRow row in dt.Rows)
                    cmb.Items.Add(row["KullaniciAdi"].ToString());

                Button btnTamam = new Button();
                btnTamam.Text = "Ata";
                btnTamam.Location = new System.Drawing.Point(20, 80);
                btnTamam.Click += (s, ev) =>
                {
                    if (cmb.SelectedItem == null) { MessageBox.Show("Personel seçin!"); return; }

                    using (SqlConnection b = new SqlConnection(baglantiYolu))
                    {
                        b.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Cihazlar SET AtananPersonel=@p WHERE Id=@id", b);
                        cmd.Parameters.AddWithValue("@p", cmb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@id", cihazId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Atama başarılı!");
                    secimForm.Close();
                    CihazlariYukle();
                };

                secimForm.Controls.Add(cmb);
                secimForm.Controls.Add(btnTamam);
                secimForm.ShowDialog();
            }
        }
    }
}