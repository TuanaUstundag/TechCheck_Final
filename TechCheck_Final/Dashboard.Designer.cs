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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnPersoneller = new Guna.UI2.WinForms.Guna2Button();
			this.btnYenikayit = new Guna.UI2.WinForms.Guna2Button();
			this.btnAnasayfa = new Guna.UI2.WinForms.Guna2Button();
			this.btnCihazlistesi = new Guna.UI2.WinForms.Guna2Button();
			this.pnlContainer = new Guna.UI2.WinForms.Guna2Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.BlueViolet;
			this.panel1.Controls.Add(this.btnPersoneller);
			this.panel1.Controls.Add(this.btnYenikayit);
			this.panel1.Controls.Add(this.btnAnasayfa);
			this.panel1.Controls.Add(this.btnCihazlistesi);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(251, 775);
			this.panel1.TabIndex = 0;
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
			this.btnPersoneller.Image = global::TechCheck_Final.Properties.Resources.add;
			this.btnPersoneller.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnPersoneller.Location = new System.Drawing.Point(0, 242);
			this.btnPersoneller.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPersoneller.Name = "btnPersoneller";
			this.btnPersoneller.Size = new System.Drawing.Size(251, 85);
			this.btnPersoneller.TabIndex = 4;
			this.btnPersoneller.Text = "Personeller";
			this.btnPersoneller.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnPersoneller.TextOffset = new System.Drawing.Point(10, 0);
			this.btnPersoneller.Click += new System.EventHandler(this.btnPersoneller_Click);
			// 
			// btnYenikayit
			// 
			this.btnYenikayit.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
			this.btnYenikayit.CheckedState.FillColor = System.Drawing.Color.Indigo;
			this.btnYenikayit.CheckedState.ForeColor = System.Drawing.Color.White;
			this.btnYenikayit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnYenikayit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnYenikayit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnYenikayit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnYenikayit.FillColor = System.Drawing.Color.BlueViolet;
			this.btnYenikayit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnYenikayit.ForeColor = System.Drawing.Color.White;
			this.btnYenikayit.HoverState.FillColor = System.Drawing.Color.Indigo;
			this.btnYenikayit.Image = global::TechCheck_Final.Properties.Resources.add;
			this.btnYenikayit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnYenikayit.Location = new System.Drawing.Point(0, 153);
			this.btnYenikayit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnYenikayit.Name = "btnYenikayit";
			this.btnYenikayit.Size = new System.Drawing.Size(251, 85);
			this.btnYenikayit.TabIndex = 3;
			this.btnYenikayit.Text = "Yeni Kayıt";
			this.btnYenikayit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnYenikayit.TextOffset = new System.Drawing.Point(10, 0);
			this.btnYenikayit.Click += new System.EventHandler(this.btnYenikayit_Click);
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
			this.btnAnasayfa.Location = new System.Drawing.Point(0, 2);
			this.btnAnasayfa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAnasayfa.Name = "btnAnasayfa";
			this.btnAnasayfa.Size = new System.Drawing.Size(251, 85);
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
			this.btnCihazlistesi.Location = new System.Drawing.Point(0, 78);
			this.btnCihazlistesi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCihazlistesi.Name = "btnCihazlistesi";
			this.btnCihazlistesi.Size = new System.Drawing.Size(251, 85);
			this.btnCihazlistesi.TabIndex = 2;
			this.btnCihazlistesi.Text = "Cihaz Listesi";
			this.btnCihazlistesi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnCihazlistesi.TextOffset = new System.Drawing.Point(10, 0);
			this.btnCihazlistesi.Click += new System.EventHandler(this.btnCihazlistesi_Click);
			// 
			// pnlContainer
			// 
			this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlContainer.Location = new System.Drawing.Point(251, 0);
			this.pnlContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlContainer.Name = "pnlContainer";
			this.pnlContainer.Size = new System.Drawing.Size(1080, 775);
			this.pnlContainer.TabIndex = 1;
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1331, 775);
			this.Controls.Add(this.pnlContainer);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Dashboard";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private Guna.UI2.WinForms.Guna2Button btnAnasayfa;
		private Guna.UI2.WinForms.Guna2Button btnCihazlistesi;
		private Guna.UI2.WinForms.Guna2Button btnYenikayit;
		private Guna.UI2.WinForms.Guna2Panel pnlContainer;
		private Guna.UI2.WinForms.Guna2Button btnPersoneller;
	}
}