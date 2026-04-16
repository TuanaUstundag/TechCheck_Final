using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TechCheck_Final
{
	public partial class UC_Personeller : UserControl
	{
		// Veritabanı bağlantı cümlesi
		SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mnjrosan;Integrated Security=True
");

		public UC_Personeller()
		{
			InitializeComponent();
		}

		// Sayfa yüklendiğinde otomatik listeleme yapar
		private void UC_Personeller_Load(object sender, EventArgs e)
		{
			PersonelListele();
		}

		public void PersonelListele()
		{
			flowLayoutPanel1.Controls.Clear();
			try
			{
				if (baglanti.State == ConnectionState.Closed) baglanti.Open();

				SqlCommand komut = new SqlCommand("SELECT * FROM Personeller", baglanti);
				SqlDataReader oku = komut.ExecuteReader();

				while (oku.Read())
				{
					UC_PersonelKarti kart = new UC_PersonelKarti();
					// Veritabanı kolon isimlerinin AdSoyad ve Gorev olduğundan emin ol
					kart.PersonelAdi = oku["AdSoyad"].ToString();
					kart.PersonelGorevi = oku["Gorev"].ToString();
					kart.Tag = oku["Id"].ToString();

					// Karta veya içindeki Labellara tıklandığında sağ paneli doldur
					Action tiklamaIslemi = () => {
						txtID.Text = kart.Tag.ToString();
						txtAdSoyad.Text = kart.PersonelAdi;
						txtGorev.Text = kart.PersonelGorevi;
					};

					kart.Click += (s, ev) => tiklamaIslemi();
					foreach (Control ctrl in kart.Controls)
					{
						ctrl.Click += (s, ev) => tiklamaIslemi();
					}

					flowLayoutPanel1.Controls.Add(kart);
				}
				baglanti.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Listeleme sırasında hata oluştu: " + ex.Message);
				if (baglanti.State == ConnectionState.Open) baglanti.Close();
			}
		}

		// EKLEME İŞLEMİ
		private void btnEkle_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtAdSoyad.Text) || string.IsNullOrWhiteSpace(txtGorev.Text))
			{
				MessageBox.Show("Lütfen tüm alanları doldurun!");
				return;
			}

			try
			{
				if (baglanti.State == ConnectionState.Closed) baglanti.Open();
				SqlCommand komut = new SqlCommand("INSERT INTO Personeller (AdSoyad, Gorev) VALUES (@p1, @p2)", baglanti);
				komut.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
				komut.Parameters.AddWithValue("@p2", txtGorev.Text);
				komut.ExecuteNonQuery();
				baglanti.Close();

				PersonelListele();
				Temizle();
			}
			catch (Exception ex) { MessageBox.Show("Ekleme Hatası: " + ex.Message); baglanti.Close(); }
		}

		// GÜNCELLEME İŞLEMİ
		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtID.Text))
			{
				MessageBox.Show("Lütfen listeden güncellenecek bir personel seçin!");
				return;
			}

			try
			{
				if (baglanti.State == ConnectionState.Closed) baglanti.Open();
				SqlCommand komut = new SqlCommand("UPDATE Personeller SET AdSoyad=@p1, Gorev=@p2 WHERE Id=@id", baglanti);
				komut.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
				komut.Parameters.AddWithValue("@p2", txtGorev.Text);
				komut.Parameters.AddWithValue("@id", txtID.Text);
				komut.ExecuteNonQuery();
				baglanti.Close();

				PersonelListele();
				Temizle();
			}
			catch (Exception ex) { MessageBox.Show("Güncelleme Hatası: " + ex.Message); baglanti.Close(); }
		}

		// SİLME İŞLEMİ
		private void btnSil_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtID.Text))
			{
				MessageBox.Show("Lütfen listeden silinecek bir personel seçin!");
				return;
			}

			DialogResult secim = MessageBox.Show("Bu personeli silmek istediğinize emin misiniz?", "Personel Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (secim == DialogResult.Yes)
			{
				try
				{
					if (baglanti.State == ConnectionState.Closed) baglanti.Open();
					SqlCommand komut = new SqlCommand("DELETE FROM Personeller WHERE Id=@id", baglanti);
					komut.Parameters.AddWithValue("@id", txtID.Text);
					komut.ExecuteNonQuery();
					baglanti.Close();

					PersonelListele();
					Temizle();
				}
				catch (Exception ex) { MessageBox.Show("Silme Hatası: " + ex.Message); baglanti.Close(); }
			}
		}

		private void Temizle()
		{
			txtAdSoyad.Clear();
			txtGorev.Clear();
			txtID.Clear();
			txtAdSoyad.Focus();
		}
	}
}