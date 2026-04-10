using Guna.UI2.WinForms;
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
    public partial class UC_YeniKayit : UserControl
    {
        public UC_YeniKayit()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtMusteriAd.Clear(); // Clear() metodu, TextBox içindeki metni temizler ve kutuyu boş hale getirir.
            txtCihazModel.Clear();
            txtSeriNo.Clear();
            txtAriza.Clear();
            cmbDurum.SelectedIndex = -1;
            dtpKayitTarihi.Value = DateTime.Now;

            // Temizledikten sonra imleci ilk kutuya odakla ki kullanıcı hemen yazabilsin
            txtMusteriAd.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mnjrosan;Integrated Security=True
");

            try
            {
                baglanti.Open(); // Kapıyı açtık
                string sorgu = "INSERT INTO Cihazlar (MusteriAd, CihazModel, SeriNo, Ariza, Durum) VALUES (@p1, @p2, @p3, @p4, @p5)"; // SQL sorgusu, parametreler kullanarak veri eklemek için hazırlandı

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", txtMusteriAd.Text); // Parametreleri ekleyerek SQL sorgusunu güvenli hale getiriyoruz, böylece SQL enjeksiyon saldırılarına karşı koruma sağlanır
                komut.Parameters.AddWithValue("@p2", txtCihazModel.Text);
                komut.Parameters.AddWithValue("@p3", txtSeriNo.Text);
                komut.Parameters.AddWithValue("@p4", txtAriza.Text);
                komut.Parameters.AddWithValue("@p5", cmbDurum.Text);
                //AddWithValue bir parametreyi ve bunun karşılık gelen değerini tek bir adımda bir veritabanı komutuna eklemek için kullanılır.

                komut.ExecuteNonQuery(); // SQL sorgusunu çalıştırarak veritabanına veri ekliyoruz
                baglanti.Close(); // Kapıyı kapattık

                MessageBox.Show("Cihaz başarıyla kaydedildi!", "TechCheck", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    }
}
