using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechCheck_Final
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            UC_Anasayfa uc = new UC_Anasayfa();
            addUserControl(uc);
        }

        private void btnCihazlistesi_Click(object sender, EventArgs e)
        {
            UC_CihazListesi uc = new UC_CihazListesi();
            addUserControl(uc);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnYenikayit_Click(object sender, EventArgs e)
        {
            // Daha önce yazdığımız o metodu çağırıyoruz
            addUserControl(new UC_YeniKayit());
        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
