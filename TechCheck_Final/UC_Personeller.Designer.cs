namespace TechCheck_Final
{
	partial class UC_Personeller
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.pnlIslem = new System.Windows.Forms.Panel();
			this.txtAdSoyad = new System.Windows.Forms.TextBox();
			this.txtGorev = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.btnEkle = new Guna.UI2.WinForms.Guna2Button();
			this.btnGuncelle = new Guna.UI2.WinForms.Guna2Button();
			this.btnSil = new Guna.UI2.WinForms.Guna2Button();
			this.pnlIslem.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(700, 775);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// pnlIslem
			// 
			this.pnlIslem.Controls.Add(this.btnSil);
			this.pnlIslem.Controls.Add(this.btnGuncelle);
			this.pnlIslem.Controls.Add(this.btnEkle);
			this.pnlIslem.Controls.Add(this.txtID);
			this.pnlIslem.Controls.Add(this.txtGorev);
			this.pnlIslem.Controls.Add(this.txtAdSoyad);
			this.pnlIslem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlIslem.Location = new System.Drawing.Point(700, 0);
			this.pnlIslem.Name = "pnlIslem";
			this.pnlIslem.Size = new System.Drawing.Size(380, 775);
			this.pnlIslem.TabIndex = 1;
			// 
			// txtAdSoyad
			// 
			this.txtAdSoyad.Location = new System.Drawing.Point(54, 128);
			this.txtAdSoyad.Name = "txtAdSoyad";
			this.txtAdSoyad.Size = new System.Drawing.Size(100, 22);
			this.txtAdSoyad.TabIndex = 0;
			this.txtAdSoyad.Text = "Ad Soyad";
			// 
			// txtGorev
			// 
			this.txtGorev.Location = new System.Drawing.Point(214, 128);
			this.txtGorev.Name = "txtGorev";
			this.txtGorev.Size = new System.Drawing.Size(100, 22);
			this.txtGorev.TabIndex = 0;
			this.txtGorev.Text = "Görev";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(54, 201);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(100, 22);
			this.txtID.TabIndex = 1;
			this.txtID.Text = "ID";
			this.txtID.Visible = false;
			// 
			// btnEkle
			// 
			this.btnEkle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnEkle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnEkle.ForeColor = System.Drawing.Color.White;
			this.btnEkle.Location = new System.Drawing.Point(99, 388);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(180, 45);
			this.btnEkle.TabIndex = 2;
			this.btnEkle.Text = "Ekle";
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnGuncelle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnGuncelle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnGuncelle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnGuncelle.ForeColor = System.Drawing.Color.White;
			this.btnGuncelle.Location = new System.Drawing.Point(99, 489);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(180, 45);
			this.btnGuncelle.TabIndex = 3;
			this.btnGuncelle.Text = "Güncelle";
			// 
			// btnSil
			// 
			this.btnSil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSil.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnSil.ForeColor = System.Drawing.Color.White;
			this.btnSil.Location = new System.Drawing.Point(99, 591);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(180, 45);
			this.btnSil.TabIndex = 3;
			this.btnSil.Text = "Sil";
			// 
			// UC_Personeller
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnlIslem);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "UC_Personeller";
			this.Size = new System.Drawing.Size(1080, 775);
			this.pnlIslem.ResumeLayout(false);
			this.pnlIslem.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel pnlIslem;
		private System.Windows.Forms.TextBox txtAdSoyad;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtGorev;
		private Guna.UI2.WinForms.Guna2Button btnSil;
		private Guna.UI2.WinForms.Guna2Button btnGuncelle;
		private Guna.UI2.WinForms.Guna2Button btnEkle;
	}
}
