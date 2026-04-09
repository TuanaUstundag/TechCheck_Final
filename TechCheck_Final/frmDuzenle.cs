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
    public partial class frmDuzenle : Form
    {
        public int cihazId;
        public frmDuzenle(int id, string ad, string model, string seri, string ariza, string durum)
        {
            InitializeComponent();

            // 2. Dışarıdan gelen 'id' değerini yukarıdaki 'cihazId'ye atıyoruz
            this.cihazId = id;

            // Verileri kutulara doldur
            txtMusteriAd.Text = ad;
            txtCihazModel.Text = model;
            txtSeriNo.Text = seri;
            txtAriza.Text = ariza;
            cmbDurum.Text = durum;
        }
        
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TechCheckDB;Integrated Security=True");
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                // 3. Sorgu aynı kalıyor, sonundaki @p6 bizim Id'miz olacak
                string sorgu = "UPDATE Cihazlar SET MusteriAd=@p1, CihazModel=@p2, SeriNo=@p3, Ariza=@p4, Durum=@p5 WHERE Id=@p6";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", txtMusteriAd.Text);
                komut.Parameters.AddWithValue("@p2", txtCihazModel.Text);
                komut.Parameters.AddWithValue("@p3", txtSeriNo.Text);
                komut.Parameters.AddWithValue("@p4", txtAriza.Text);
                komut.Parameters.AddWithValue("@p5", cmbDurum.Text);

                // 4. İŞTE KRİTİK NOKTA: @p6 parametresine yukarıda sakladığımız cihazId'yi veriyoruz
                komut.Parameters.AddWithValue("@p6", cihazId);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kayıt başarıyla güncellendi!", "TechCheck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Pencereyi kapat
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Hata: " + ex.Message);
            }
        
    }

    }
}
