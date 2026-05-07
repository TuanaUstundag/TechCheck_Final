namespace TechCheck_Final
{
    partial class UC_Personeller
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtArama = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPersonelEkle = new Guna.UI2.WinForms.Guna2Button();
            this.dgvPersoneller = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colSec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colResim = new System.Windows.Forms.DataGridViewImageColumn();
            this.AdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gorev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPersonelSil = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPersonelDuzenle = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoneller)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtArama
            // 
            this.txtArama.BorderRadius = 15;
            this.txtArama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtArama.DefaultText = "";
            this.txtArama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtArama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtArama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtArama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtArama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtArama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtArama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtArama.Location = new System.Drawing.Point(18, 25);
            this.txtArama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtArama.Name = "txtArama";
            this.txtArama.PlaceholderText = "🔍 Personel Ara...";
            this.txtArama.SelectedText = "";
            this.txtArama.Size = new System.Drawing.Size(973, 60);
            this.txtArama.TabIndex = 0;
            this.txtArama.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPersonelEkle.BorderRadius = 20;
            this.btnPersonelEkle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPersonelEkle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPersonelEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPersonelEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPersonelEkle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(86)))), ((int)(((byte)(218)))));
            this.btnPersonelEkle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPersonelEkle.ForeColor = System.Drawing.Color.White;
            this.btnPersonelEkle.Location = new System.Drawing.Point(1217, 23);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(160, 62);
            this.btnPersonelEkle.TabIndex = 1;
            this.btnPersonelEkle.Text = "+ Personel Ekle";
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // dgvPersoneller
            // 
            this.dgvPersoneller.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPersoneller.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersoneller.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersoneller.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPersoneller.ColumnHeadersHeight = 40;
            this.dgvPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPersoneller.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSec,
            this.colResim,
            this.AdSoyad,
            this.Gorev,
            this.Id,
            this.Maas,
            this.Telefon});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPersoneller.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPersoneller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersoneller.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvPersoneller.Location = new System.Drawing.Point(0, 135);
            this.dgvPersoneller.Name = "dgvPersoneller";
            this.dgvPersoneller.RowHeadersVisible = false;
            this.dgvPersoneller.RowHeadersWidth = 62;
            this.dgvPersoneller.RowTemplate.Height = 70;
            this.dgvPersoneller.Size = new System.Drawing.Size(1867, 994);
            this.dgvPersoneller.TabIndex = 2;
            this.dgvPersoneller.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPersoneller.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPersoneller.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPersoneller.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvPersoneller.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPersoneller.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPersoneller.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvPersoneller.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPersoneller.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPersoneller.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvPersoneller.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPersoneller.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPersoneller.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvPersoneller.ThemeStyle.ReadOnly = false;
            this.dgvPersoneller.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPersoneller.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPersoneller.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvPersoneller.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPersoneller.ThemeStyle.RowsStyle.Height = 70;
            this.dgvPersoneller.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPersoneller.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colSec
            // 
            this.colSec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colSec.FillWeight = 27.27272F;
            this.colSec.HeaderText = "";
            this.colSec.MinimumWidth = 8;
            this.colSec.Name = "colSec";
            this.colSec.Width = 8;
            // 
            // colResim
            // 
            this.colResim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colResim.FillWeight = 27.27272F;
            this.colResim.HeaderText = "Profil";
            this.colResim.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colResim.MinimumWidth = 70;
            this.colResim.Name = "colResim";
            this.colResim.Width = 70;
            // 
            // AdSoyad
            // 
            this.AdSoyad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AdSoyad.DataPropertyName = "MusteriAd";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AdSoyad.DefaultCellStyle = dataGridViewCellStyle3;
            this.AdSoyad.FillWeight = 463.6364F;
            this.AdSoyad.HeaderText = "AdSoyad";
            this.AdSoyad.MinimumWidth = 8;
            this.AdSoyad.Name = "AdSoyad";
            this.AdSoyad.Width = 108;
            // 
            // Gorev
            // 
            this.Gorev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gorev.FillWeight = 27.27272F;
            this.Gorev.HeaderText = "Gorev";
            this.Gorev.MinimumWidth = 8;
            this.Gorev.Name = "Gorev";
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 57;
            // 
            // Maas
            // 
            this.Maas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Maas.FillWeight = 27.27272F;
            this.Maas.HeaderText = "Maas";
            this.Maas.MinimumWidth = 8;
            this.Maas.Name = "Maas";
            // 
            // Telefon
            // 
            this.Telefon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telefon.FillWeight = 27.27272F;
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.MinimumWidth = 8;
            this.Telefon.Name = "Telefon";
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPersonelSil.BorderRadius = 20;
            this.btnPersonelSil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPersonelSil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPersonelSil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPersonelSil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPersonelSil.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(86)))), ((int)(((byte)(218)))));
            this.btnPersonelSil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPersonelSil.ForeColor = System.Drawing.Color.White;
            this.btnPersonelSil.Location = new System.Drawing.Point(1416, 23);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(160, 62);
            this.btnPersonelSil.TabIndex = 4;
            this.btnPersonelSil.Text = "-  Personel Sil";
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnPersonelDuzenle);
            this.guna2Panel1.Controls.Add(this.txtArama);
            this.guna2Panel1.Controls.Add(this.btnPersonelSil);
            this.guna2Panel1.Controls.Add(this.btnPersonelEkle);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1867, 135);
            this.guna2Panel1.TabIndex = 5;
            // 
            // btnPersonelDuzenle
            // 
            this.btnPersonelDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPersonelDuzenle.BorderRadius = 20;
            this.btnPersonelDuzenle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPersonelDuzenle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPersonelDuzenle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPersonelDuzenle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPersonelDuzenle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(86)))), ((int)(((byte)(218)))));
            this.btnPersonelDuzenle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPersonelDuzenle.ForeColor = System.Drawing.Color.White;
            this.btnPersonelDuzenle.Location = new System.Drawing.Point(1614, 23);
            this.btnPersonelDuzenle.Name = "btnPersonelDuzenle";
            this.btnPersonelDuzenle.Size = new System.Drawing.Size(178, 62);
            this.btnPersonelDuzenle.TabIndex = 5;
            this.btnPersonelDuzenle.Text = "Personel Düzenle";
            this.btnPersonelDuzenle.Click += new System.EventHandler(this.btnPersonelDuzenle_Click);
            // 
            // UC_Personeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvPersoneller);
            this.Controls.Add(this.guna2Panel1);
            this.MinimumSize = new System.Drawing.Size(1050, 650);
            this.Name = "UC_Personeller";
            this.Size = new System.Drawing.Size(1867, 1129);
            this.Load += new System.EventHandler(this.UC_Personeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoneller)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtArama;
        private Guna.UI2.WinForms.Guna2Button btnPersonelEkle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPersoneller;
        private Guna.UI2.WinForms.Guna2Button btnPersonelSil;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSec;
        private System.Windows.Forms.DataGridViewImageColumn colResim;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gorev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private Guna.UI2.WinForms.Guna2Button btnPersonelDuzenle;
    }
}
