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
            
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

               
                string sorgu = "SELECT * FROM Cihazlar WHERE MusteriAd LIKE @p1 OR CihazModel LIKE @p1";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
          
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

        private void dgvCihazListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0)
            {
                string columnName = dgvCihazListesi.Columns[e.ColumnIndex].Name;
                if (columnName == "colDelete")
                {
                    int id = Convert.ToInt32(dgvCihazListesi.Rows[e.RowIndex].Cells["Id"].Value);

                    if (MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "TechCheck", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        KaydiSil(id); 

                        
                        this.BeginInvoke(new Action(() => VerileriGetir()));
                       

                    }
                }

                
            }

           
            if (dgvCihazListesi.Columns[e.ColumnIndex].Name == "colEdit")
            {
               
                int id = Convert.ToInt32(dgvCihazListesi.Rows[e.RowIndex].Cells["Id"].Value);
                string ad = dgvCihazListesi.Rows[e.RowIndex].Cells["MusteriAd"].Value.ToString();
                string model = dgvCihazListesi.Rows[e.RowIndex].Cells["CihazModel"].Value.ToString();
                string seri = dgvCihazListesi.Rows[e.RowIndex].Cells["SeriNo"].Value.ToString();
                string ariza = dgvCihazListesi.Rows[e.RowIndex].Cells["Ariza"].Value.ToString();
                string durum = dgvCihazListesi.Rows[e.RowIndex].Cells["Durum"].Value.ToString();

              
                frmDuzenle frm = new frmDuzenle(id, ad, model, seri, ariza, durum);
               
                frm.ShowDialog(); 

                VerileriGetir();

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
          

          
            if (dgvCihazListesi.Columns[e.ColumnIndex].Name == "colEdit")
            {
               
                e.Value = Properties.Resources.pencil;
            }

      
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

                
                ((DataGridView)dgvCihazListesi).AutoGenerateColumns = false;

               
                dgvCihazListesi.DataSource = dt;

               
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
               
            }

        }
            

    }
}
