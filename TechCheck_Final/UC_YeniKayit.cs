using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TechCheck_Final
{
    public partial class UC_YeniKayit : UserControl
    {
        string baglantiYolu = @"Data Source=KEREMKLKS\SQLEXPRESS;Initial Catalog=TechCheckDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        public UC_YeniKayit()
        {
            InitializeComponent();
        }

        private void UC_YeniKayit_Load(object sender, EventArgs e)
        {
            PersonelleriGetir(); // Sayfa açılınca teknisyenler yüklensin
        }

        private void PersonelleriGetir()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    string sorgu = "SELECT UserID, Username FROM Users";
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbPersoneller.DataSource = dt;
                    cmbPersoneller.DisplayMember = "Username";
                    cmbPersoneller.ValueMember = "UserID";
                    cmbPersoneller.SelectedIndex = -1;
                }
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMusteriAd.Text) || cmbPersoneller.SelectedValue == null)
            {
                MessageBox.Show("Lütfen müşteri adını ve teknisyeni seçiniz!");
                return;
            }

            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                try
                {
                    baglanti.Open();
                    // 1. Müşteriyi ekle
                    string mSorgu = "INSERT INTO Customers (FullName) OUTPUT INSERTED.CustomerID VALUES (@name)";
                    SqlCommand mKomut = new SqlCommand(mSorgu, baglanti);
                    mKomut.Parameters.AddWithValue("@name", txtMusteriAd.Text);
                    int mId = (int)mKomut.ExecuteScalar();

                    // 2. Cihazı ekle
                    string cSorgu = "INSERT INTO Devices (CustomerID, Model, SerialNumber) OUTPUT INSERTED.DeviceID VALUES (@mId, @model, @seri)";
                    SqlCommand cKomut = new SqlCommand(cSorgu, baglanti);
                    cKomut.Parameters.AddWithValue("@mId", mId);
                    cKomut.Parameters.AddWithValue("@model", txtCihazModel.Text);
                    cKomut.Parameters.AddWithValue("@seri", txtSeriNo.Text);
                    int dId = (int)cKomut.ExecuteScalar();

                    // 3. Servis kaydını oluştur
                    string sSorgu = "INSERT INTO ServiceRecords (DeviceID, TechnicianID, FailureDescription, Status) VALUES (@dId, @tId, @ariza, @durum)";
                    SqlCommand sKomut = new SqlCommand(sSorgu, baglanti);
                    sKomut.Parameters.AddWithValue("@dId", dId);
                    sKomut.Parameters.AddWithValue("@tId", cmbPersoneller.SelectedValue);
                    sKomut.Parameters.AddWithValue("@ariza", txtAriza.Text);
                    sKomut.Parameters.AddWithValue("@durum", cmbDurum.Text);

                    sKomut.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarılı!");
                    btnTemizle.PerformClick();
                }
                catch (Exception ex) { MessageBox.Show("Kayıt Hatası: " + ex.Message); }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtMusteriAd.Clear();
            txtCihazModel.Clear();
            txtSeriNo.Clear();
            txtAriza.Clear();
            cmbDurum.SelectedIndex = -1;
            cmbPersoneller.SelectedIndex = -1;
        }
    }
}