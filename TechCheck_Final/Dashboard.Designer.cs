namespace TechCheck_Final
{
	partial class Dashboard
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.Panel panel1;
            this.btnArizakyt = new Guna.UI2.WinForms.Guna2Button();
            this.btnBekleyenArizalar = new Guna.UI2.WinForms.Guna2Button();
            this.btnKayitOl = new Guna.UI2.WinForms.Guna2Button();
            this.btnPersoneller = new Guna.UI2.WinForms.Guna2Button();
            this.btnAnasayfa = new Guna.UI2.WinForms.Guna2Button();
            this.btnCihazlistesi = new Guna.UI2.WinForms.Guna2Button();
            this.pnlContainer = new Guna.UI2.WinForms.Guna2Panel();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.BlueViolet;
            panel1.Controls.Add(this.btnArizakyt);
            panel1.Controls.Add(this.btnBekleyenArizalar);
            panel1.Controls.Add(this.btnKayitOl);
            panel1.Controls.Add(this.btnPersoneller);
            panel1.Controls.Add(this.btnAnasayfa);
            panel1.Controls.Add(this.btnCihazlistesi);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(282, 1068);
            panel1.TabIndex = 0;
            // 
            // btnArizakyt
            // 
            this.btnArizakyt.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnArizakyt.CheckedState.FillColor = System.Drawing.Color.Indigo;
            this.btnArizakyt.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnArizakyt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnArizakyt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnArizakyt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnArizakyt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnArizakyt.FillColor = System.Drawing.Color.BlueViolet;
            this.btnArizakyt.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArizakyt.ForeColor = System.Drawing.Color.White;
            this.btnArizakyt.HoverState.FillColor = System.Drawing.Color.Indigo;
            this.btnArizakyt.Image = global::TechCheck_Final.Properties.Resources.menu_dots_vertical;
            this.btnArizakyt.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnArizakyt.Location = new System.Drawing.Point(0, 514);
            this.btnArizakyt.Name = "btnArizakyt";
            this.btnArizakyt.Size = new System.Drawing.Size(282, 106);
            this.btnArizakyt.TabIndex = 7;
            this.btnArizakyt.Text = "Arıza Kaydı";
            this.btnArizakyt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnArizakyt.TextOffset = new System.Drawing.Point(10, 0);
            this.btnArizakyt.Click += new System.EventHandler(this.btnArizakyt_Click);
            // 
            // btnBekleyenArizalar
            // 
            this.btnBekleyenArizalar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBekleyenArizalar.CheckedState.FillColor = System.Drawing.Color.Indigo;
            this.btnBekleyenArizalar.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnBekleyenArizalar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBekleyenArizalar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBekleyenArizalar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBekleyenArizalar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBekleyenArizalar.FillColor = System.Drawing.Color.BlueViolet;
            this.btnBekleyenArizalar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBekleyenArizalar.ForeColor = System.Drawing.Color.White;
            this.btnBekleyenArizalar.HoverState.FillColor = System.Drawing.Color.Indigo;
            this.btnBekleyenArizalar.Image = global::TechCheck_Final.Properties.Resources.settings;
            this.btnBekleyenArizalar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBekleyenArizalar.Location = new System.Drawing.Point(0, 411);
            this.btnBekleyenArizalar.Name = "btnBekleyenArizalar";
            this.btnBekleyenArizalar.Size = new System.Drawing.Size(282, 106);
            this.btnBekleyenArizalar.TabIndex = 6;
            this.btnBekleyenArizalar.Text = "Bekleyen Arızalar";
            this.btnBekleyenArizalar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBekleyenArizalar.TextOffset = new System.Drawing.Point(10, 0);
            this.btnBekleyenArizalar.Click += new System.EventHandler(this.btnBekleyenArizalar_Click);
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnKayitOl.CheckedState.FillColor = System.Drawing.Color.Indigo;
            this.btnKayitOl.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnKayitOl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKayitOl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKayitOl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKayitOl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKayitOl.FillColor = System.Drawing.Color.BlueViolet;
            this.btnKayitOl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKayitOl.ForeColor = System.Drawing.Color.White;
            this.btnKayitOl.HoverState.FillColor = System.Drawing.Color.Indigo;
            this.btnKayitOl.Image = global::TechCheck_Final.Properties.Resources.user4;
            this.btnKayitOl.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKayitOl.Location = new System.Drawing.Point(0, 308);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(282, 106);
            this.btnKayitOl.TabIndex = 5;
            this.btnKayitOl.Text = "Personel Ekle";
            this.btnKayitOl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKayitOl.TextOffset = new System.Drawing.Point(10, 0);
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // btnPersoneller
            // 
            this.btnPersoneller.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPersoneller.CheckedState.FillColor = System.Drawing.Color.Indigo;
            this.btnPersoneller.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnPersoneller.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPersoneller.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPersoneller.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPersoneller.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPersoneller.FillColor = System.Drawing.Color.BlueViolet;
            this.btnPersoneller.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersoneller.ForeColor = System.Drawing.Color.White;
            this.btnPersoneller.HoverState.FillColor = System.Drawing.Color.Indigo;
            this.btnPersoneller.Image = global::TechCheck_Final.Properties.Resources.admin_alt;
            this.btnPersoneller.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPersoneller.Location = new System.Drawing.Point(0, 207);
            this.btnPersoneller.Name = "btnPersoneller";
            this.btnPersoneller.Size = new System.Drawing.Size(282, 106);
            this.btnPersoneller.TabIndex = 4;
            this.btnPersoneller.Text = "Personeller";
            this.btnPersoneller.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPersoneller.TextOffset = new System.Drawing.Point(10, 0);
            this.btnPersoneller.Click += new System.EventHandler(this.btnPersoneller_Click);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAnasayfa.CheckedState.FillColor = System.Drawing.Color.Indigo;
            this.btnAnasayfa.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnAnasayfa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnasayfa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnasayfa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnasayfa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnasayfa.FillColor = System.Drawing.Color.BlueViolet;
            this.btnAnasayfa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnasayfa.ForeColor = System.Drawing.Color.White;
            this.btnAnasayfa.HoverState.FillColor = System.Drawing.Color.Indigo;
            this.btnAnasayfa.Image = global::TechCheck_Final.Properties.Resources.home__1_;
            this.btnAnasayfa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAnasayfa.Location = new System.Drawing.Point(0, 3);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(282, 106);
            this.btnAnasayfa.TabIndex = 1;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAnasayfa.TextOffset = new System.Drawing.Point(10, 0);
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // btnCihazlistesi
            // 
            this.btnCihazlistesi.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCihazlistesi.CheckedState.FillColor = System.Drawing.Color.Indigo;
            this.btnCihazlistesi.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnCihazlistesi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCihazlistesi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCihazlistesi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCihazlistesi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCihazlistesi.FillColor = System.Drawing.Color.BlueViolet;
            this.btnCihazlistesi.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCihazlistesi.ForeColor = System.Drawing.Color.White;
            this.btnCihazlistesi.HoverState.FillColor = System.Drawing.Color.Indigo;
            this.btnCihazlistesi.Image = global::TechCheck_Final.Properties.Resources.menu_burger;
            this.btnCihazlistesi.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCihazlistesi.Location = new System.Drawing.Point(0, 105);
            this.btnCihazlistesi.Name = "btnCihazlistesi";
            this.btnCihazlistesi.Size = new System.Drawing.Size(282, 106);
            this.btnCihazlistesi.TabIndex = 2;
            this.btnCihazlistesi.Text = "Cihaz Listesi";
            this.btnCihazlistesi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCihazlistesi.TextOffset = new System.Drawing.Point(10, 0);
            this.btnCihazlistesi.Click += new System.EventHandler(this.btnCihazlistesi_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(282, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1695, 1068);
            this.pnlContainer.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1977, 1068);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Dashboard";
            panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private Guna.UI2.WinForms.Guna2Button btnAnasayfa;
		private Guna.UI2.WinForms.Guna2Button btnCihazlistesi;
		private Guna.UI2.WinForms.Guna2Panel pnlContainer;
		private Guna.UI2.WinForms.Guna2Button btnPersoneller;
        private Guna.UI2.WinForms.Guna2Button btnKayitOl;
        private Guna.UI2.WinForms.Guna2Button btnBekleyenArizalar;
        private Guna.UI2.WinForms.Guna2Button btnArizakyt;
    }
}