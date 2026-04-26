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

            
            this.cihazId = id;

           
            txtMusteriAd.Text = ad; 
            txtCihazModel.Text = model;
            txtSeriNo.Text = seri;
            txtAriza.Text = ariza;
            cmbDurum.Text = durum;
        }
        
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mnjrosan;Integrated Security=True");
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                
                string sorgu = "UPDATE Cihazlar SET MusteriAd=@p1, CihazModel=@p2, SeriNo=@p3, Ariza=@p4, Durum=@p5 WHERE Id=@p6"; 

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", txtMusteriAd.Text);
                komut.Parameters.AddWithValue("@p2", txtCihazModel.Text);
                komut.Parameters.AddWithValue("@p3", txtSeriNo.Text);
                komut.Parameters.AddWithValue("@p4", txtAriza.Text);
                komut.Parameters.AddWithValue("@p5", cmbDurum.Text);
                komut.Parameters.AddWithValue("@p6", cihazId);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kayıt başarıyla güncellendi!", "TechCheck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Hata: " + ex.Message);
            }
        
    }

        private void frmDuzenle_Load(object sender, EventArgs e)
        {

        }
    }
}
