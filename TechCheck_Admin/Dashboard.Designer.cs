namespace TechCheck_Admin
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
            btnMenuDashboard = new Button();
            btnMenuKullanicilar = new Button();
            btnMenuPersoneller = new Button();
            btnMenuCihazlar = new Button();
            pnlSidebar = new Panel();
            label5 = new Label();
            label1 = new Label();
            pnlMain = new Panel();
            tabMain = new TabControl();
            Kullanıcılar = new TabPage();
            button1 = new Button();
            dgvKullanicilar = new DataGridView();
            Personeller = new TabPage();
            button2 = new Button();
            dgvPersoneller = new DataGridView();
            Cihazlar = new TabPage();
            button3 = new Button();
            dgvCihazlar = new DataGridView();
            pnlStats = new Panel();
            pnlStatKullanici = new Panel();
            lblKullaniciSayi = new Label();
            label2 = new Label();
            pnlStatPersonel = new Panel();
            lblPersonelSayi = new Label();
            label4 = new Label();
            pnlStatCihaz = new Panel();
            lblCihazSayi = new Label();
            label3 = new Label();
            pnlTopBar = new Panel();
            btnCikis = new Button();
            lblBaslik = new Label();
            pnlSidebar.SuspendLayout();
            pnlMain.SuspendLayout();
            tabMain.SuspendLayout();
            Kullanıcılar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).BeginInit();
            Personeller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersoneller).BeginInit();
            Cihazlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCihazlar).BeginInit();
            pnlStats.SuspendLayout();
            pnlStatKullanici.SuspendLayout();
            pnlStatPersonel.SuspendLayout();
            pnlStatCihaz.SuspendLayout();
            pnlTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // btnMenuDashboard
            // 
            btnMenuDashboard.BackColor = Color.FromArgb(60, 52, 137);
            btnMenuDashboard.FlatAppearance.BorderSize = 0;
            btnMenuDashboard.FlatStyle = FlatStyle.Flat;
            btnMenuDashboard.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnMenuDashboard.ForeColor = Color.White;
            btnMenuDashboard.Location = new Point(0, 106);
            btnMenuDashboard.Name = "btnMenuDashboard";
            btnMenuDashboard.Size = new Size(198, 61);
            btnMenuDashboard.TabIndex = 4;
            btnMenuDashboard.Text = "📊  Dashboard";
            btnMenuDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuDashboard.UseVisualStyleBackColor = false;
            // 
            // btnMenuKullanicilar
            // 
            btnMenuKullanicilar.BackColor = Color.FromArgb(60, 52, 137);
            btnMenuKullanicilar.FlatAppearance.BorderSize = 0;
            btnMenuKullanicilar.FlatStyle = FlatStyle.Flat;
            btnMenuKullanicilar.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnMenuKullanicilar.ForeColor = Color.White;
            btnMenuKullanicilar.Location = new Point(0, 174);
            btnMenuKullanicilar.Name = "btnMenuKullanicilar";
            btnMenuKullanicilar.Size = new Size(198, 61);
            btnMenuKullanicilar.TabIndex = 5;
            btnMenuKullanicilar.Text = "👥  Kullanıcılar";
            btnMenuKullanicilar.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuKullanicilar.UseVisualStyleBackColor = false;
            // 
            // btnMenuPersoneller
            // 
            btnMenuPersoneller.BackColor = Color.FromArgb(60, 52, 137);
            btnMenuPersoneller.FlatAppearance.BorderSize = 0;
            btnMenuPersoneller.FlatStyle = FlatStyle.Flat;
            btnMenuPersoneller.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnMenuPersoneller.ForeColor = Color.White;
            btnMenuPersoneller.Location = new Point(0, 243);
            btnMenuPersoneller.Name = "btnMenuPersoneller";
            btnMenuPersoneller.Size = new Size(198, 61);
            btnMenuPersoneller.TabIndex = 6;
            btnMenuPersoneller.Text = "\U0001faaa  Personeller";
            btnMenuPersoneller.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuPersoneller.UseVisualStyleBackColor = false;
            // 
            // btnMenuCihazlar
            // 
            btnMenuCihazlar.BackColor = Color.FromArgb(60, 52, 137);
            btnMenuCihazlar.FlatAppearance.BorderSize = 0;
            btnMenuCihazlar.FlatStyle = FlatStyle.Flat;
            btnMenuCihazlar.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnMenuCihazlar.ForeColor = Color.White;
            btnMenuCihazlar.Location = new Point(0, 307);
            btnMenuCihazlar.Name = "btnMenuCihazlar";
            btnMenuCihazlar.Size = new Size(198, 61);
            btnMenuCihazlar.TabIndex = 7;
            btnMenuCihazlar.Text = "💻  Cihazlar";
            btnMenuCihazlar.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuCihazlar.UseVisualStyleBackColor = false;
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(label5);
            pnlSidebar.Controls.Add(label1);
            pnlSidebar.Controls.Add(btnMenuCihazlar);
            pnlSidebar.Controls.Add(btnMenuDashboard);
            pnlSidebar.Controls.Add(btnMenuKullanicilar);
            pnlSidebar.Controls.Add(btnMenuPersoneller);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(200, 804);
            pnlSidebar.TabIndex = 8;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(127, 119, 221);
            label5.Location = new Point(21, 95);
            label5.Name = "label5";
            label5.Size = new Size(160, 1);
            label5.TabIndex = 10;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 13);
            label1.Name = "label1";
            label1.Size = new Size(189, 74);
            label1.TabIndex = 9;
            label1.Text = "⚙ TechCheck Admin";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(tabMain);
            pnlMain.Controls.Add(pnlStats);
            pnlMain.Controls.Add(pnlTopBar);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(200, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1306, 804);
            pnlMain.TabIndex = 9;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(Kullanıcılar);
            tabMain.Controls.Add(Personeller);
            tabMain.Controls.Add(Cihazlar);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 182);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(1306, 622);
            tabMain.TabIndex = 4;
            tabMain.Tag = "";
            // 
            // Kullanıcılar
            // 
            Kullanıcılar.Controls.Add(button1);
            Kullanıcılar.Controls.Add(dgvKullanicilar);
            Kullanıcılar.Location = new Point(4, 34);
            Kullanıcılar.Name = "Kullanıcılar";
            Kullanıcılar.Padding = new Padding(3);
            Kullanıcılar.Size = new Size(1175, 584);
            Kullanıcılar.TabIndex = 0;
            Kullanıcılar.Text = "Kullanıcılar";
            Kullanıcılar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(250, 236, 231);
            button1.FlatAppearance.BorderColor = Color.FromArgb(240, 153, 123);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(153, 60, 29);
            button1.Location = new Point(1057, 6);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "sil";
            button1.UseVisualStyleBackColor = false;
            // 
            // dgvKullanicilar
            // 
            dgvKullanicilar.BackgroundColor = Color.White;
            dgvKullanicilar.BorderStyle = BorderStyle.None;
            dgvKullanicilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKullanicilar.Dock = DockStyle.Fill;
            dgvKullanicilar.Location = new Point(3, 3);
            dgvKullanicilar.Name = "dgvKullanicilar";
            dgvKullanicilar.ReadOnly = true;
            dgvKullanicilar.RowHeadersWidth = 62;
            dgvKullanicilar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKullanicilar.Size = new Size(1169, 578);
            dgvKullanicilar.TabIndex = 0;
            // 
            // Personeller
            // 
            Personeller.Controls.Add(button2);
            Personeller.Controls.Add(dgvPersoneller);
            Personeller.Location = new Point(4, 34);
            Personeller.Name = "Personeller";
            Personeller.Padding = new Padding(3);
            Personeller.Size = new Size(1175, 584);
            Personeller.TabIndex = 1;
            Personeller.Text = "Personeller";
            Personeller.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(250, 236, 231);
            button2.FlatAppearance.BorderColor = Color.FromArgb(240, 153, 123);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(153, 60, 29);
            button2.Location = new Point(1057, 6);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 3;
            button2.Text = "sil";
            button2.UseVisualStyleBackColor = false;
            // 
            // dgvPersoneller
            // 
            dgvPersoneller.BackgroundColor = Color.White;
            dgvPersoneller.BorderStyle = BorderStyle.None;
            dgvPersoneller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersoneller.Dock = DockStyle.Fill;
            dgvPersoneller.Location = new Point(3, 3);
            dgvPersoneller.Name = "dgvPersoneller";
            dgvPersoneller.ReadOnly = true;
            dgvPersoneller.RowHeadersWidth = 62;
            dgvPersoneller.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersoneller.Size = new Size(1169, 578);
            dgvPersoneller.TabIndex = 1;
            // 
            // Cihazlar
            // 
            Cihazlar.Controls.Add(button3);
            Cihazlar.Controls.Add(dgvCihazlar);
            Cihazlar.Location = new Point(4, 34);
            Cihazlar.Name = "Cihazlar";
            Cihazlar.Padding = new Padding(3);
            Cihazlar.Size = new Size(1298, 584);
            Cihazlar.TabIndex = 2;
            Cihazlar.Text = "Cihazlar";
            Cihazlar.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(250, 236, 231);
            button3.FlatAppearance.BorderColor = Color.FromArgb(240, 153, 123);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(153, 60, 29);
            button3.Location = new Point(1180, 6);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 3;
            button3.Text = "sil";
            button3.UseVisualStyleBackColor = false;
            // 
            // dgvCihazlar
            // 
            dgvCihazlar.AllowUserToAddRows = false;
            dgvCihazlar.BackgroundColor = Color.White;
            dgvCihazlar.BorderStyle = BorderStyle.None;
            dgvCihazlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCihazlar.Dock = DockStyle.Fill;
            dgvCihazlar.Location = new Point(3, 3);
            dgvCihazlar.Name = "dgvCihazlar";
            dgvCihazlar.ReadOnly = true;
            dgvCihazlar.RowHeadersWidth = 62;
            dgvCihazlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCihazlar.Size = new Size(1292, 578);
            dgvCihazlar.TabIndex = 2;
            // 
            // pnlStats
            // 
            pnlStats.Controls.Add(pnlStatKullanici);
            pnlStats.Controls.Add(pnlStatPersonel);
            pnlStats.Controls.Add(pnlStatCihaz);
            pnlStats.Dock = DockStyle.Top;
            pnlStats.Location = new Point(0, 55);
            pnlStats.Name = "pnlStats";
            pnlStats.Size = new Size(1306, 127);
            pnlStats.TabIndex = 5;
            // 
            // pnlStatKullanici
            // 
            pnlStatKullanici.BackColor = Color.FromArgb(238, 237, 254);
            pnlStatKullanici.Controls.Add(lblKullaniciSayi);
            pnlStatKullanici.Controls.Add(label2);
            pnlStatKullanici.Location = new Point(219, 24);
            pnlStatKullanici.Name = "pnlStatKullanici";
            pnlStatKullanici.Size = new Size(188, 88);
            pnlStatKullanici.TabIndex = 2;
            // 
            // lblKullaniciSayi
            // 
            lblKullaniciSayi.AutoSize = true;
            lblKullaniciSayi.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKullaniciSayi.ForeColor = Color.FromArgb(60, 52, 137);
            lblKullaniciSayi.Location = new Point(68, 28);
            lblKullaniciSayi.Name = "lblKullaniciSayi";
            lblKullaniciSayi.Size = new Size(0, 46);
            lblKullaniciSayi.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(83, 74, 183);
            label2.Location = new Point(44, 3);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 4;
            label2.Text = "Kullanıcılar";
            // 
            // pnlStatPersonel
            // 
            pnlStatPersonel.BackColor = Color.FromArgb(238, 237, 254);
            pnlStatPersonel.Controls.Add(lblPersonelSayi);
            pnlStatPersonel.Controls.Add(label4);
            pnlStatPersonel.Location = new Point(511, 24);
            pnlStatPersonel.Name = "pnlStatPersonel";
            pnlStatPersonel.Size = new Size(188, 88);
            pnlStatPersonel.TabIndex = 3;
            // 
            // lblPersonelSayi
            // 
            lblPersonelSayi.AutoSize = true;
            lblPersonelSayi.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPersonelSayi.ForeColor = Color.FromArgb(60, 52, 137);
            lblPersonelSayi.Location = new Point(67, 28);
            lblPersonelSayi.Name = "lblPersonelSayi";
            lblPersonelSayi.Size = new Size(0, 46);
            lblPersonelSayi.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(83, 74, 183);
            label4.Location = new Point(44, 3);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 6;
            label4.Text = "Personeller";
            // 
            // pnlStatCihaz
            // 
            pnlStatCihaz.BackColor = Color.FromArgb(238, 237, 254);
            pnlStatCihaz.Controls.Add(lblCihazSayi);
            pnlStatCihaz.Controls.Add(label3);
            pnlStatCihaz.Location = new Point(814, 24);
            pnlStatCihaz.Name = "pnlStatCihaz";
            pnlStatCihaz.Size = new Size(188, 88);
            pnlStatCihaz.TabIndex = 3;
            // 
            // lblCihazSayi
            // 
            lblCihazSayi.AutoSize = true;
            lblCihazSayi.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCihazSayi.ForeColor = Color.FromArgb(60, 52, 137);
            lblCihazSayi.Location = new Point(72, 28);
            lblCihazSayi.Name = "lblCihazSayi";
            lblCihazSayi.Size = new Size(0, 46);
            lblCihazSayi.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(83, 74, 183);
            label3.Location = new Point(59, 3);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 5;
            label3.Text = "Cihazlar";
            // 
            // pnlTopBar
            // 
            pnlTopBar.Controls.Add(btnCikis);
            pnlTopBar.Controls.Add(lblBaslik);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(0, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1306, 55);
            pnlTopBar.TabIndex = 0;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.FromArgb(238, 237, 254);
            btnCikis.FlatAppearance.BorderColor = Color.FromArgb(127, 119, 221);
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.ForeColor = Color.FromArgb(60, 52, 137);
            btnCikis.Location = new Point(1194, 12);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(100, 32);
            btnCikis.TabIndex = 1;
            btnCikis.Text = "Çıkış Yap";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik.ForeColor = Color.FromArgb(60, 52, 137);
            lblBaslik.Location = new Point(7, 19);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(141, 26);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Genel Bakış";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 52, 137);
            ClientSize = new Size(1506, 804);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechCheck Admin";
            Load += Dashboard_Load;
            pnlSidebar.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            tabMain.ResumeLayout(false);
            Kullanıcılar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).EndInit();
            Personeller.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersoneller).EndInit();
            Cihazlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCihazlar).EndInit();
            pnlStats.ResumeLayout(false);
            pnlStatKullanici.ResumeLayout(false);
            pnlStatKullanici.PerformLayout();
            pnlStatPersonel.ResumeLayout(false);
            pnlStatPersonel.PerformLayout();
            pnlStatCihaz.ResumeLayout(false);
            pnlStatCihaz.PerformLayout();
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnMenuDashboard;
        private Button btnMenuKullanicilar;
        private Button btnMenuPersoneller;
        private Button btnMenuCihazlar;
        private Panel pnlSidebar;
        private Label label1;
        private Panel pnlMain;
        private Button btnCikis;
        private Panel pnlTopBar;
        private Label lblBaslik;
        private Panel pnlStatPersonel;
        private Label label4;
        private Panel pnlStatCihaz;
        private Label label3;
        private Panel pnlStatKullanici;
        private Label label2;
        private Label lblKullaniciSayi;
        private TabControl tabMain;
        private TabPage Kullanıcılar;
        private TabPage Personeller;
        private Label lblPersonelSayi;
        private Label lblCihazSayi;
        private TabPage Cihazlar;
        private DataGridView dgvKullanicilar;
        private DataGridView dgvPersoneller;
        private DataGridView dgvCihazlar;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel pnlStats;
        private Label label5;
    }
}