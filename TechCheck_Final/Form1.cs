using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // SQL Server bağlantısı için 
using System.Net;            // Mail gönderirken kimlik doğrulama için
using System.Net.Mail;       // Mail gönderme sınıfları için

namespace TechCheck_Final
{
    public partial class Form1 : Form
    {
        private string connectionString;

        public Form1()
        {
            InitializeComponent();
            // Initialize connectionString once so all methods (login, password recovery) can use it
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Label'ın babası artık o mor panel olsun diyoruz:
            label1.Parent = pictureBox1; // Buradaki isimleri kendi panel ve label ismine göre düzelt
            label1.BackColor = Color.Transparent;


        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TechCheckDB;Integrated Security=True");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                // İsmi ve şifreyi aynı anda kontrol eden sorgu
                string sorgu = "SELECT * FROM Kullanicilar WHERE KullaniciAdi=@p1 AND Sifre=@p2";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);

                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read()) // Eğer veritabanında böyle bir eşleşme varsa (Data bulunursa)
                {
                    MessageBox.Show("Giriş Başarılı!", "TechCheck", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Dashboard formunu aç
                    Dashboard dsh = new Dashboard();
                    dsh.Show();

                    this.Hide(); // Login formunu gizle
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası: " + ex.Message);
            }
        }
        }

        
    }
    

