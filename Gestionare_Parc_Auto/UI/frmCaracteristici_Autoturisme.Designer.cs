namespace Gestionare_Parc_Auto.UI
{
    partial class frmCaracteristici_Autoturisme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaracteristici_Autoturisme));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_Search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Stergere_Carac = new System.Windows.Forms.Button();
            this.Actualizare_Carac = new System.Windows.Forms.Button();
            this.Adaugare_Carac = new System.Windows.Forms.Button();
            this.txt_Caracteristici_AutoID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Den_Carac_Auto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Valoare_Carac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ID_A_C = new System.Windows.Forms.TextBox();
            this.dgv_Carac_Auto = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Carac_Auto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 38);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(888, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1338, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caracteristici Autoturisme";
            // 
            // text_Search
            // 
            this.text_Search.Location = new System.Drawing.Point(433, 59);
            this.text_Search.Name = "text_Search";
            this.text_Search.Size = new System.Drawing.Size(434, 22);
            this.text_Search.TabIndex = 64;
            this.text_Search.TextChanged += new System.EventHandler(this.Text_Search_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(314, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 63;
            this.label3.Text = "Cautare";
            // 
            // btn_Stergere_Carac
            // 
            this.btn_Stergere_Carac.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Stergere_Carac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Stergere_Carac.FlatAppearance.BorderSize = 0;
            this.btn_Stergere_Carac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Stergere_Carac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stergere_Carac.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stergere_Carac.Location = new System.Drawing.Point(742, 443);
            this.btn_Stergere_Carac.Name = "btn_Stergere_Carac";
            this.btn_Stergere_Carac.Size = new System.Drawing.Size(160, 38);
            this.btn_Stergere_Carac.TabIndex = 61;
            this.btn_Stergere_Carac.Text = "Stergere";
            this.btn_Stergere_Carac.UseVisualStyleBackColor = false;
            this.btn_Stergere_Carac.Click += new System.EventHandler(this.Btn_Stergere_Carac_Click);
            // 
            // Actualizare_Carac
            // 
            this.Actualizare_Carac.BackColor = System.Drawing.Color.SeaGreen;
            this.Actualizare_Carac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Actualizare_Carac.FlatAppearance.BorderSize = 0;
            this.Actualizare_Carac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.Actualizare_Carac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Actualizare_Carac.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualizare_Carac.Location = new System.Drawing.Point(533, 443);
            this.Actualizare_Carac.Name = "Actualizare_Carac";
            this.Actualizare_Carac.Size = new System.Drawing.Size(160, 38);
            this.Actualizare_Carac.TabIndex = 60;
            this.Actualizare_Carac.Text = "Actualizare";
            this.Actualizare_Carac.UseVisualStyleBackColor = false;
            this.Actualizare_Carac.Click += new System.EventHandler(this.Actualizare_Carac_Click);
            // 
            // Adaugare_Carac
            // 
            this.Adaugare_Carac.BackColor = System.Drawing.Color.SeaGreen;
            this.Adaugare_Carac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Adaugare_Carac.FlatAppearance.BorderSize = 0;
            this.Adaugare_Carac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.Adaugare_Carac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adaugare_Carac.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adaugare_Carac.Location = new System.Drawing.Point(318, 443);
            this.Adaugare_Carac.Name = "Adaugare_Carac";
            this.Adaugare_Carac.Size = new System.Drawing.Size(145, 38);
            this.Adaugare_Carac.TabIndex = 59;
            this.Adaugare_Carac.Text = "Adaugare";
            this.Adaugare_Carac.UseVisualStyleBackColor = false;
            this.Adaugare_Carac.Click += new System.EventHandler(this.Adaugare_Carac_Click);
            // 
            // txt_Caracteristici_AutoID
            // 
            this.txt_Caracteristici_AutoID.Location = new System.Drawing.Point(38, 206);
            this.txt_Caracteristici_AutoID.Name = "txt_Caracteristici_AutoID";
            this.txt_Caracteristici_AutoID.Size = new System.Drawing.Size(236, 22);
            this.txt_Caracteristici_AutoID.TabIndex = 58;
            this.txt_Caracteristici_AutoID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Caracteristici_AutoID_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(34, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 21);
            this.label9.TabIndex = 57;
            this.label9.Text = "Id Autoturisme:";
            // 
            // txt_Den_Carac_Auto
            // 
            this.txt_Den_Carac_Auto.Location = new System.Drawing.Point(38, 275);
            this.txt_Den_Carac_Auto.Name = "txt_Den_Carac_Auto";
            this.txt_Den_Carac_Auto.Size = new System.Drawing.Size(236, 22);
            this.txt_Den_Carac_Auto.TabIndex = 56;
            this.txt_Den_Carac_Auto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Den_Carac_Auto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 21);
            this.label2.TabIndex = 55;
            this.label2.Text = "Id Caracteristici Autoturisme:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 21);
            this.label4.TabIndex = 65;
            this.label4.Text = "Valoarea Caracteristicii";
            // 
            // txt_Valoare_Carac
            // 
            this.txt_Valoare_Carac.Location = new System.Drawing.Point(38, 351);
            this.txt_Valoare_Carac.Name = "txt_Valoare_Carac";
            this.txt_Valoare_Carac.Size = new System.Drawing.Size(236, 22);
            this.txt_Valoare_Carac.TabIndex = 66;
            this.txt_Valoare_Carac.TextChanged += new System.EventHandler(this.Txt_Valoare_Carac_TextChanged);
            this.txt_Valoare_Carac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Valoare_Carac_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 21);
            this.label5.TabIndex = 67;
            this.label5.Text = "Id Caracteristici:";
            // 
            // txt_ID_A_C
            // 
            this.txt_ID_A_C.Location = new System.Drawing.Point(38, 142);
            this.txt_ID_A_C.Name = "txt_ID_A_C";
            this.txt_ID_A_C.Size = new System.Drawing.Size(236, 22);
            this.txt_ID_A_C.TabIndex = 68;
            // 
            // dgv_Carac_Auto
            // 
            this.dgv_Carac_Auto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Carac_Auto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Carac_Auto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgv_Carac_Auto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Carac_Auto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Carac_Auto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Carac_Auto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Carac_Auto.ColumnHeadersHeight = 30;
            this.dgv_Carac_Auto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Carac_Auto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Carac_Auto.EnableHeadersVisualStyles = false;
            this.dgv_Carac_Auto.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv_Carac_Auto.Location = new System.Drawing.Point(318, 87);
            this.dgv_Carac_Auto.Name = "dgv_Carac_Auto";
            this.dgv_Carac_Auto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Carac_Auto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Carac_Auto.RowHeadersWidth = 51;
            this.dgv_Carac_Auto.RowTemplate.Height = 24;
            this.dgv_Carac_Auto.Size = new System.Drawing.Size(584, 350);
            this.dgv_Carac_Auto.TabIndex = 69;
            this.dgv_Carac_Auto.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_Carac_Auto_RowHeaderMouseClick);
            // 
            // frmCaracteristici_Autoturisme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(914, 502);
            this.Controls.Add(this.dgv_Carac_Auto);
            this.Controls.Add(this.txt_ID_A_C);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Valoare_Carac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_Search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Stergere_Carac);
            this.Controls.Add(this.Actualizare_Carac);
            this.Controls.Add(this.Adaugare_Carac);
            this.Controls.Add(this.txt_Caracteristici_AutoID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Den_Carac_Auto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCaracteristici_Autoturisme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCaracteristici_Autoturisme";
            this.Load += new System.EventHandler(this.FrmCaracteristici_Autoturisme_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Carac_Auto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Stergere_Carac;
        private System.Windows.Forms.Button Actualizare_Carac;
        private System.Windows.Forms.Button Adaugare_Carac;
        private System.Windows.Forms.TextBox txt_Caracteristici_AutoID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Den_Carac_Auto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Valoare_Carac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ID_A_C;
        private System.Windows.Forms.DataGridView dgv_Carac_Auto;
    }
}