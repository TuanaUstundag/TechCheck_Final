using System;
using System.Drawing;
using System.Windows.Forms;

namespace TechCheck_Final
{
	public partial class UC_PersonelKarti : UserControl
	{
		public UC_PersonelKarti()
		{
			InitializeComponent();
		}

		// Sadece 1'er tane kalsın, fazlalıkları sildik:
		public string PersonelAdi
		{
			get => lblAd.Text;
			set => lblAd.Text = value;
		}

		public string PersonelGorevi
		{
			get => lblGorev.Text;
			set => lblGorev.Text = value;
		}

		public Image PersonelResmi
		{
			get => pbResim.Image;
			set => pbResim.Image = value;
		}
	}
}