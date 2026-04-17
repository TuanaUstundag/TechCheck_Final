using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TechCheck_Final
{
	public partial class Dashboard : Form
	{
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
			addUserControl(new UC_YeniKayit());
		}

		// PERSONELLER BUTONU (Tasarımda bu isme sahip olduğundan emin ol)
		private void btnPersoneller_Click(object sender, EventArgs e)
		{
			addUserControl(new UC_Personeller());
		}

		public SqlConnection baglanti()
		{
			// Buradaki 'Data Source' kısmını kendi SQL Server adına göre güncellemelisin!
			SqlConnection baglan = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mnjrosan;Integrated Security=True
");
			baglan.Open();
			return baglan;
		}
	}
}