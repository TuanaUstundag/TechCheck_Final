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
            this.btnYenikayit = new Guna.UI2.WinForms.Guna2Button();
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
            panel1.Controls.Add(this.btnYenikayit);
            panel1.Controls.Add(this.btnAnasayfa);
            panel1.Controls.Add(this.btnCihazlistesi);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(250, 775);
            panel1.TabIndex = 0;
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
            this.btnYenikayit.Name = "btnYenikayit";
            this.btnYenikayit.Size = new System.Drawing.Size(256, 69);
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
            this.btnAnasayfa.Location = new System.Drawing.Point(0, 3);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(256, 69);
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
            this.btnCihazlistesi.Name = "btnCihazlistesi";
            this.btnCihazlistesi.Size = new System.Drawing.Size(256, 69);
            this.btnCihazlistesi.TabIndex = 2;
            this.btnCihazlistesi.Text = "Cihaz Listesi";
            this.btnCihazlistesi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCihazlistesi.TextOffset = new System.Drawing.Point(10, 0);
            this.btnCihazlistesi.Click += new System.EventHandler(this.btnCihazlistesi_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(250, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1081, 775);
            this.pnlContainer.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1331, 775);
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
        private Guna.UI2.WinForms.Guna2Button btnYenikayit;
        private Guna.UI2.WinForms.Guna2Panel pnlContainer;
    }
}