namespace Gestionare_Parc_Auto
{
    partial class frmAdmin_Initial
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.utilizatoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoturismeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caracteristiciAutoturismeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cacarteristiciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importAutoturismeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vanzariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Logged_Admin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vizualizareVanzariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 585);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1443, 37);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(785, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aplicatie realizata de Boghian Marius-Gabriel";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilizatoriToolStripMenuItem,
            this.autoturismeToolStripMenuItem,
            this.caracteristiciAutoturismeToolStripMenuItem,
            this.cacarteristiciToolStripMenuItem,
            this.importAutoturismeToolStripMenuItem,
            this.vanzariToolStripMenuItem,
            this.clientiToolStripMenuItem,
            this.vizualizareVanzariToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1443, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // utilizatoriToolStripMenuItem
            // 
            this.utilizatoriToolStripMenuItem.Name = "utilizatoriToolStripMenuItem";
            this.utilizatoriToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.utilizatoriToolStripMenuItem.Text = "Utilizatori";
            this.utilizatoriToolStripMenuItem.Click += new System.EventHandler(this.UtilizatoriToolStripMenuItem_Click);
            // 
            // autoturismeToolStripMenuItem
            // 
            this.autoturismeToolStripMenuItem.Name = "autoturismeToolStripMenuItem";
            this.autoturismeToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.autoturismeToolStripMenuItem.Text = "Autoturisme";
            this.autoturismeToolStripMenuItem.Click += new System.EventHandler(this.AutoturismeToolStripMenuItem_Click);
            // 
            // caracteristiciAutoturismeToolStripMenuItem
            // 
            this.caracteristiciAutoturismeToolStripMenuItem.Name = "caracteristiciAutoturismeToolStripMenuItem";
            this.caracteristiciAutoturismeToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.caracteristiciAutoturismeToolStripMenuItem.Text = "Caracteristici Autoturisme";
            this.caracteristiciAutoturismeToolStripMenuItem.Click += new System.EventHandler(this.CaracteristiciAutoturismeToolStripMenuItem_Click);
            // 
            // cacarteristiciToolStripMenuItem
            // 
            this.cacarteristiciToolStripMenuItem.Name = "cacarteristiciToolStripMenuItem";
            this.cacarteristiciToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.cacarteristiciToolStripMenuItem.Text = "Cacarteristici";
            this.cacarteristiciToolStripMenuItem.Click += new System.EventHandler(this.CacarteristiciToolStripMenuItem_Click);
            // 
            // importAutoturismeToolStripMenuItem
            // 
            this.importAutoturismeToolStripMenuItem.Name = "importAutoturismeToolStripMenuItem";
            this.importAutoturismeToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.importAutoturismeToolStripMenuItem.Text = "Import Autoturisme ";
            this.importAutoturismeToolStripMenuItem.Click += new System.EventHandler(this.ImportAutoturismeToolStripMenuItem_Click);
            // 
            // vanzariToolStripMenuItem
            // 
            this.vanzariToolStripMenuItem.Name = "vanzariToolStripMenuItem";
            this.vanzariToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.vanzariToolStripMenuItem.Text = "Vanzari";
            this.vanzariToolStripMenuItem.Click += new System.EventHandler(this.VanzariToolStripMenuItem_Click);
            // 
            // clientiToolStripMenuItem
            // 
            this.clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
            this.clientiToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.clientiToolStripMenuItem.Text = "Clienti";
            this.clientiToolStripMenuItem.Click += new System.EventHandler(this.ClientiToolStripMenuItem_Click);
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.Location = new System.Drawing.Point(12, 55);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(95, 23);
            this.lbl_User.TabIndex = 2;
            this.lbl_User.Text = "Utilizator:";
            // 
            // lbl_Logged_Admin
            // 
            this.lbl_Logged_Admin.AutoSize = true;
            this.lbl_Logged_Admin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logged_Admin.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_Logged_Admin.Location = new System.Drawing.Point(113, 55);
            this.lbl_Logged_Admin.Name = "lbl_Logged_Admin";
            this.lbl_Logged_Admin.Size = new System.Drawing.Size(0, 23);
            this.lbl_Logged_Admin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(893, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parc Autoturisme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(699, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(600, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sistem de gestiune a unui parc auto";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // vizualizareVanzariToolStripMenuItem
            // 
            this.vizualizareVanzariToolStripMenuItem.Name = "vizualizareVanzariToolStripMenuItem";
            this.vizualizareVanzariToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.vizualizareVanzariToolStripMenuItem.Text = "Vizualizare Vanzari";
            this.vizualizareVanzariToolStripMenuItem.Click += new System.EventHandler(this.VizualizareVanzariToolStripMenuItem_Click);
            // 
            // frmAdmin_Initial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 622);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Logged_Admin);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdmin_Initial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAdmin_Initial_FormClosed);
            this.Load += new System.EventHandler(this.FrmAdmin_Initial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem utilizatoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoturismeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caracteristiciAutoturismeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cacarteristiciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importAutoturismeToolStripMenuItem;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_Logged_Admin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem vanzariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareVanzariToolStripMenuItem;
    }
}

