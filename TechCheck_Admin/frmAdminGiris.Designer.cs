namespace TechCheck_Admin
{
    public partial class frmAdminGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSifre = new TextBox();
            txtKullanici = new TextBox();
            btnGiris = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(293, 238);
            txtSifre.Margin = new Padding(4, 5, 4, 5);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(235, 31);
            txtSifre.TabIndex = 1;
            txtSifre.Text = "Şifre:";
            txtSifre.UseSystemPasswordChar = true;
            // 
            // txtKullanici
            // 
            txtKullanici.Location = new Point(293, 133);
            txtKullanici.Margin = new Padding(4, 5, 4, 5);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new Size(235, 31);
            txtKullanici.TabIndex = 2;
            // 
            // btnGiris
            // 
            btnGiris.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnGiris.FlatAppearance.BorderSize = 0;
            btnGiris.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btnGiris.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.ForeColor = SystemColors.ControlText;
            btnGiris.Location = new Point(343, 343);
            btnGiris.Margin = new Padding(4, 5, 4, 5);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(123, 42);
            btnGiris.TabIndex = 2;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 138);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 243);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 3;
            label2.Text = "Şifre:";
            // 
            // frmAdminGiris
            // 
            AcceptButton = btnGiris;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1985, 1063);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGiris);
            Controls.Add(txtKullanici);
            Controls.Add(txtSifre);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmAdminGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "7";
            Load += frmAdminGiris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSifre;
        private TextBox txtKullanici;
        private Button btnGiris;
        private Label label1;
        private Label label2;
    }
}