namespace TechCheck_Final
{
    partial class UC_CihazListesi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CihazListesi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCihazListesi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ariza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeriNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CihazModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCihazListesi)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCihazListesi
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.dgvCihazListesi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCihazListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCihazListesi.ColumnHeadersHeight = 40;
            this.dgvCihazListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCihazListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ariza,
            this.SeriNo,
            this.CihazModel,
            this.MusteriAd,
            this.Durum,
            this.Tarih,
            this.colEdit,
            this.colDelete});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCihazListesi.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCihazListesi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.dgvCihazListesi.Location = new System.Drawing.Point(0, 120);
            this.dgvCihazListesi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCihazListesi.Name = "dgvCihazListesi";
            this.dgvCihazListesi.RowHeadersVisible = false;
            this.dgvCihazListesi.RowHeadersWidth = 51;
            this.dgvCihazListesi.RowTemplate.Height = 40;
            this.dgvCihazListesi.Size = new System.Drawing.Size(1510, 854);
            this.dgvCihazListesi.TabIndex = 1;
            this.dgvCihazListesi.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple;
            this.dgvCihazListesi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.dgvCihazListesi.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCihazListesi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCihazListesi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCihazListesi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCihazListesi.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCihazListesi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.dgvCihazListesi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.dgvCihazListesi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCihazListesi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCihazListesi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCihazListesi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCihazListesi.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvCihazListesi.ThemeStyle.ReadOnly = false;
            this.dgvCihazListesi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.dgvCihazListesi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCihazListesi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCihazListesi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCihazListesi.ThemeStyle.RowsStyle.Height = 40;
            this.dgvCihazListesi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            this.dgvCihazListesi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCihazListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCihazListesi_CellContentClick);
            this.dgvCihazListesi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCihazListesi_CellFormatting);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // Ariza
            // 
            this.Ariza.DataPropertyName = "Ariza";
            this.Ariza.HeaderText = "Ariza";
            this.Ariza.MinimumWidth = 6;
            this.Ariza.Name = "Ariza";
            // 
            // SeriNo
            // 
            this.SeriNo.DataPropertyName = "SeriNo";
            this.SeriNo.HeaderText = "SeriNo";
            this.SeriNo.MinimumWidth = 6;
            this.SeriNo.Name = "SeriNo";
            this.SeriNo.Visible = false;
            // 
            // CihazModel
            // 
            this.CihazModel.DataPropertyName = "CihazModel";
            this.CihazModel.HeaderText = "Model";
            this.CihazModel.MinimumWidth = 6;
            this.CihazModel.Name = "CihazModel";
            // 
            // MusteriAd
            // 
            this.MusteriAd.DataPropertyName = "MusteriAd";
            this.MusteriAd.HeaderText = "Müşteri";
            this.MusteriAd.MinimumWidth = 6;
            this.MusteriAd.Name = "MusteriAd";
            // 
            // Durum
            // 
            this.Durum.DataPropertyName = "Durum";
            this.Durum.HeaderText = "Durum";
            this.Durum.MinimumWidth = 6;
            this.Durum.Name = "Durum";
            // 
            // Tarih
            // 
            this.Tarih.DataPropertyName = "KayitTarihi";
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.MinimumWidth = 6;
            this.Tarih.Name = "Tarih";
            // 
            // colEdit
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8);
            this.colEdit.DefaultCellStyle = dataGridViewCellStyle3;
            this.colEdit.HeaderText = "";
            this.colEdit.Image = global::TechCheck_Final.Properties.Resources.pencil;
            this.colEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colEdit.MinimumWidth = 6;
            this.colEdit.Name = "colEdit";
            // 
            // colDelete
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(8);
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDelete.HeaderText = "";
            this.colDelete.Image = global::TechCheck_Final.Properties.Resources.trash;
            this.colDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colDelete.MinimumWidth = 6;
            this.colDelete.Name = "colDelete";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.Controls.Add(this.txtSearch);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1735, 125);
            this.guna2Panel1.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderRadius = 15;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(86)))), ((int)(((byte)(218)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = global::TechCheck_Final.Properties.Resources.search;
            this.txtSearch.Location = new System.Drawing.Point(141, 32);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Cihaz veya Müşteri Ara...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(1194, 60);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(8);
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewImageColumn1.HeaderText = "Column1";
            this.dataGridViewImageColumn1.Image = global::TechCheck_Final.Properties.Resources.pencil;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 192;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle7.NullValue")));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(8);
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewImageColumn2.HeaderText = "Column1";
            this.dataGridViewImageColumn2.Image = global::TechCheck_Final.Properties.Resources.trash__1_;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 192;
            // 
            // UC_CihazListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dgvCihazListesi);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_CihazListesi";
            this.Size = new System.Drawing.Size(1735, 1046);
            this.Load += new System.EventHandler(this.UC_CihazListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCihazListesi)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCihazListesi;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ariza;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeriNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CihazModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewImageColumn colEdit;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
    }
}
