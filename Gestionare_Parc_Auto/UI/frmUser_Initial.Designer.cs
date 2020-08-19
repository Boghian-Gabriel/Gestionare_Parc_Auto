namespace Gestionare_Parc_Auto
{
    partial class frmUser
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.autoturismeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.achizitionareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vanzariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Logged_InUser = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.frmUset_Initial = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.vizualizareVanzariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.frmUset_Initial.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoturismeToolStripMenuItem,
            this.achizitionareToolStripMenuItem,
            this.vanzariToolStripMenuItem,
            this.clientiToolStripMenuItem,
            this.vizualizareVanzariToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1443, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // autoturismeToolStripMenuItem
            // 
            this.autoturismeToolStripMenuItem.Name = "autoturismeToolStripMenuItem";
            this.autoturismeToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.autoturismeToolStripMenuItem.Text = "Autoturisme";
            this.autoturismeToolStripMenuItem.Click += new System.EventHandler(this.AutoturismeToolStripMenuItem_Click);
            // 
            // achizitionareToolStripMenuItem
            // 
            this.achizitionareToolStripMenuItem.Name = "achizitionareToolStripMenuItem";
            this.achizitionareToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.achizitionareToolStripMenuItem.Text = "Achizitionare";
            this.achizitionareToolStripMenuItem.Click += new System.EventHandler(this.AchizitionareToolStripMenuItem_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(690, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(600, 39);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sistem de gestiune a unui parc auto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(884, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Parc Autoturisme";
            // 
            // lbl_Logged_InUser
            // 
            this.lbl_Logged_InUser.AutoSize = true;
            this.lbl_Logged_InUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logged_InUser.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_Logged_InUser.Location = new System.Drawing.Point(113, 56);
            this.lbl_Logged_InUser.Name = "lbl_Logged_InUser";
            this.lbl_Logged_InUser.Size = new System.Drawing.Size(0, 23);
            this.lbl_Logged_InUser.TabIndex = 8;
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.Location = new System.Drawing.Point(12, 56);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(95, 23);
            this.lbl_User.TabIndex = 7;
            this.lbl_User.Text = "Utilizator:";
            // 
            // frmUset_Initial
            // 
            this.frmUset_Initial.BackColor = System.Drawing.Color.SteelBlue;
            this.frmUset_Initial.Controls.Add(this.label1);
            this.frmUset_Initial.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.frmUset_Initial.Location = new System.Drawing.Point(0, 585);
            this.frmUset_Initial.Name = "frmUset_Initial";
            this.frmUset_Initial.Size = new System.Drawing.Size(1443, 37);
            this.frmUset_Initial.TabIndex = 6;
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
            // vizualizareVanzariToolStripMenuItem
            // 
            this.vizualizareVanzariToolStripMenuItem.Name = "vizualizareVanzariToolStripMenuItem";
            this.vizualizareVanzariToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.vizualizareVanzariToolStripMenuItem.Text = "Vizualizare Vanzari";
            this.vizualizareVanzariToolStripMenuItem.Click += new System.EventHandler(this.VizualizareVanzariToolStripMenuItem_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 622);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Logged_InUser);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.frmUset_Initial);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utilizator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmUser_FormClosed);
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.frmUset_Initial.ResumeLayout(false);
            this.frmUset_Initial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem autoturismeToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Logged_InUser;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Panel frmUset_Initial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem achizitionareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vanzariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareVanzariToolStripMenuItem;
    }
}