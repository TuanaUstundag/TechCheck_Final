namespace TechCheck_Final
{
    partial class UC_YeniKayit
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTemizle = new Guna.UI2.WinForms.Guna2Button();
            this.btnKaydet = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDurum = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpKayitTarihi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtCihazModel = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSeriNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAriza = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMusteriAd = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.label5);
            this.guna2ShadowPanel1.Controls.Add(this.label4);
            this.guna2ShadowPanel1.Controls.Add(this.label3);
            this.guna2ShadowPanel1.Controls.Add(this.btnTemizle);
            this.guna2ShadowPanel1.Controls.Add(this.btnKaydet);
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.cmbDurum);
            this.guna2ShadowPanel1.Controls.Add(this.dtpKayitTarihi);
            this.guna2ShadowPanel1.Controls.Add(this.txtCihazModel);
            this.guna2ShadowPanel1.Controls.Add(this.txtSeriNo);
            this.guna2ShadowPanel1.Controls.Add(this.txtAriza);
            this.guna2ShadowPanel1.Controls.Add(this.txtMusteriAd);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(143, 117);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 20;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1062, 618);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(105, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cihaz Durumu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(42, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Seri No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(650, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Arıza Durumu";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BorderThickness = 1;
            this.btnTemizle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTemizle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTemizle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTemizle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTemizle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(86)))), ((int)(((byte)(218)))));
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(673, 489);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(281, 65);
            this.btnTemizle.TabIndex = 11;
            this.btnTemizle.Text = "Formu Boşalt";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BorderThickness = 1;
            this.btnKaydet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKaydet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKaydet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKaydet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKaydet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(86)))), ((int)(((byte)(218)))));
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Image = global::TechCheck_Final.Properties.Resources.bookmark;
            this.btnKaydet.Location = new System.Drawing.Point(139, 489);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(281, 65);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Cihazı Sisteme İşle";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(42, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(42, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ad Soyad";
            // 
            // cmbDurum
            // 
            this.cmbDurum.BackColor = System.Drawing.Color.Transparent;
            this.cmbDurum.BorderRadius = 10;
            this.cmbDurum.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurum.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDurum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDurum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDurum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDurum.ItemHeight = 30;
            this.cmbDurum.Items.AddRange(new object[] {
            "Beklemede",
            "Tamirde",
            "Parça  Bekliyor",
            "Teslim Edildi"});
            this.cmbDurum.Location = new System.Drawing.Point(110, 399);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(346, 36);
            this.cmbDurum.TabIndex = 7;
            this.cmbDurum.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // dtpKayitTarihi
            // 
            this.dtpKayitTarihi.BorderRadius = 10;
            this.dtpKayitTarihi.Checked = true;
            this.dtpKayitTarihi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(86)))), ((int)(((byte)(218)))));
            this.dtpKayitTarihi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpKayitTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpKayitTarihi.Location = new System.Drawing.Point(637, 399);
            this.dtpKayitTarihi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpKayitTarihi.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpKayitTarihi.Name = "dtpKayitTarihi";
            this.dtpKayitTarihi.Size = new System.Drawing.Size(346, 47);
            this.dtpKayitTarihi.TabIndex = 6;
            this.dtpKayitTarihi.Value = new System.DateTime(2026, 3, 20, 21, 43, 8, 543);
            // 
            // txtCihazModel
            // 
            this.txtCihazModel.BorderRadius = 10;
            this.txtCihazModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCihazModel.DefaultText = "";
            this.txtCihazModel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCihazModel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCihazModel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCihazModel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCihazModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCihazModel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCihazModel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCihazModel.IconLeft = global::TechCheck_Final.Properties.Resources.mobile_notch;
            this.txtCihazModel.Location = new System.Drawing.Point(175, 170);
            this.txtCihazModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCihazModel.Name = "txtCihazModel";
            this.txtCihazModel.PlaceholderText = "Örn: iPhone 13 Pro";
            this.txtCihazModel.SelectedText = "";
            this.txtCihazModel.Size = new System.Drawing.Size(388, 48);
            this.txtCihazModel.TabIndex = 5;
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.BorderRadius = 10;
            this.txtSeriNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSeriNo.DefaultText = "";
            this.txtSeriNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSeriNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSeriNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSeriNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSeriNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSeriNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSeriNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSeriNo.Location = new System.Drawing.Point(175, 254);
            this.txtSeriNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.PlaceholderText = "IMEI veya Seri Numarası";
            this.txtSeriNo.SelectedText = "";
            this.txtSeriNo.Size = new System.Drawing.Size(388, 48);
            this.txtSeriNo.TabIndex = 4;
            // 
            // txtAriza
            // 
            this.txtAriza.BorderRadius = 10;
            this.txtAriza.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAriza.DefaultText = "";
            this.txtAriza.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAriza.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAriza.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAriza.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAriza.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAriza.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAriza.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAriza.Location = new System.Drawing.Point(655, 119);
            this.txtAriza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAriza.Multiline = true;
            this.txtAriza.Name = "txtAriza";
            this.txtAriza.PlaceholderText = "Cihazın nesi var?";
            this.txtAriza.SelectedText = "";
            this.txtAriza.Size = new System.Drawing.Size(346, 183);
            this.txtAriza.TabIndex = 3;
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.BorderRadius = 10;
            this.txtMusteriAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMusteriAd.DefaultText = "";
            this.txtMusteriAd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMusteriAd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMusteriAd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMusteriAd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMusteriAd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMusteriAd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMusteriAd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMusteriAd.IconLeft = global::TechCheck_Final.Properties.Resources.user;
            this.txtMusteriAd.Location = new System.Drawing.Point(175, 89);
            this.txtMusteriAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.PlaceholderText = "Ad Soyad";
            this.txtMusteriAd.SelectedText = "";
            this.txtMusteriAd.Size = new System.Drawing.Size(388, 48);
            this.txtMusteriAd.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(163, 57);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(659, 43);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Yeni Cihaz Kaydı Oluştur";
            // 
            // UC_YeniKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "UC_YeniKayit";
            this.Size = new System.Drawing.Size(1338, 809);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtCihazModel;
        private Guna.UI2.WinForms.Guna2TextBox txtSeriNo;
        private Guna.UI2.WinForms.Guna2TextBox txtAriza;
        private Guna.UI2.WinForms.Guna2TextBox txtMusteriAd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpKayitTarihi;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDurum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnTemizle;
        private Guna.UI2.WinForms.Guna2Button btnKaydet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
