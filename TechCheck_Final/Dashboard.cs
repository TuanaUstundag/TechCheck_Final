using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace TechCheck_Final
{
    public partial class Dashboard : Form
    {
        // Bağlantı yolunu buraya sabitleyelim, her yerden rahatça kullanırız
        public string baglantiYolu = @"Data Source=KEREMKLKS\SQLEXPRESS;Initial Catalog=mnjrosan;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        public Dashboard()
        {
            InitializeComponent();
        }

        // Sayfaları panelin içine yerleştiren yardımcı metod
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            addUserControl(new UC_Anasayfa());
        }

        private void btnCihazlistesi_Click(object sender, EventArgs e)
        {
            addUserControl(new UC_CihazListesi());
        }

        private void btnYenikayit_Click(object sender, EventArgs e)
        {
            // Yeni arıza kaydı sayfasına gidiyoruz
            addUserControl(new UC_YeniKayit());
        }

        private void btnPersoneller_Click(object sender, EventArgs e)
        {
            // Personel listesi veya personel ekleme sayfası
            addUserControl(new UC_Personeller());
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Form açıldığında varsayılan olarak Anasayfa gelsin
            addUserControl(new UC_Anasayfa());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}