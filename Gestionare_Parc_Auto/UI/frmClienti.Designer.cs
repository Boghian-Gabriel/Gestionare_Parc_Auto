namespace Gestionare_Parc_Auto.UI
{
    partial class frmClienti
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClienti));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.text_Search = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nr_Tell = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Clienti = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Adresa = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Prenume = new System.Windows.Forms.TextBox();
            this.txt_Nume = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Actualizare_Clienti = new System.Windows.Forms.Button();
            this.Adaugare_Clienti = new System.Windows.Forms.Button();
            this.dgv_Clienti = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // text_Search
            // 
            this.text_Search.Location = new System.Drawing.Point(571, 60);
            this.text_Search.Name = "text_Search";
            this.text_Search.Size = new System.Drawing.Size(460, 22);
            this.text_Search.TabIndex = 48;
            this.text_Search.TextChanged += new System.EventHandler(this.Text_Search_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(481, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 21);
            this.label10.TabIndex = 47;
            this.label10.Text = "Cautare";
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
            this.panel1.Size = new System.Drawing.Size(1043, 38);
            this.panel1.TabIndex = 46;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1017, 0);
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
            this.label1.Location = new System.Drawing.Point(441, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clienti";
            // 
            // txt_Nr_Tell
            // 
            this.txt_Nr_Tell.Location = new System.Drawing.Point(157, 259);
            this.txt_Nr_Tell.Name = "txt_Nr_Tell";
            this.txt_Nr_Tell.Size = new System.Drawing.Size(252, 22);
            this.txt_Nr_Tell.TabIndex = 66;
            this.txt_Nr_Tell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nr_Tell_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(20, 260);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 21);
            this.label12.TabIndex = 65;
            this.label12.Text = "Nr. Telefon";
            // 
            // txt_Clienti
            // 
            this.txt_Clienti.Location = new System.Drawing.Point(158, 100);
            this.txt_Clienti.Name = "txt_Clienti";
            this.txt_Clienti.Size = new System.Drawing.Size(252, 22);
            this.txt_Clienti.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(22, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 21);
            this.label9.TabIndex = 61;
            this.label9.Text = "Client ID";
            // 
            // txt_Adresa
            // 
            this.txt_Adresa.Location = new System.Drawing.Point(157, 299);
            this.txt_Adresa.Name = "txt_Adresa";
            this.txt_Adresa.Size = new System.Drawing.Size(252, 22);
            this.txt_Adresa.TabIndex = 60;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(157, 220);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(252, 22);
            this.txt_Email.TabIndex = 59;
            this.txt_Email.TextChanged += new System.EventHandler(this.Txt_Email_TextChanged);
            // 
            // txt_Prenume
            // 
            this.txt_Prenume.Location = new System.Drawing.Point(157, 179);
            this.txt_Prenume.Name = "txt_Prenume";
            this.txt_Prenume.Size = new System.Drawing.Size(252, 22);
            this.txt_Prenume.TabIndex = 58;
            this.txt_Prenume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Prenume_KeyPress);
            // 
            // txt_Nume
            // 
            this.txt_Nume.Location = new System.Drawing.Point(157, 140);
            this.txt_Nume.Name = "txt_Nume";
            this.txt_Nume.Size = new System.Drawing.Size(252, 22);
            this.txt_Nume.TabIndex = 57;
            this.txt_Nume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nume_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 56;
            this.label5.Text = "Adresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 55;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 54;
            this.label3.Text = "Prenume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 53;
            this.label2.Text = "Nume";
            // 
            // Actualizare_Clienti
            // 
            this.Actualizare_Clienti.BackColor = System.Drawing.Color.SeaGreen;
            this.Actualizare_Clienti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Actualizare_Clienti.FlatAppearance.BorderSize = 0;
            this.Actualizare_Clienti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.Actualizare_Clienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Actualizare_Clienti.Location = new System.Drawing.Point(228, 359);
            this.Actualizare_Clienti.Name = "Actualizare_Clienti";
            this.Actualizare_Clienti.Size = new System.Drawing.Size(181, 33);
            this.Actualizare_Clienti.TabIndex = 69;
            this.Actualizare_Clienti.Text = "Actualizare";
            this.Actualizare_Clienti.UseVisualStyleBackColor = false;
            this.Actualizare_Clienti.Click += new System.EventHandler(this.Actualizare_Clienti_Click);
            // 
            // Adaugare_Clienti
            // 
            this.Adaugare_Clienti.BackColor = System.Drawing.Color.SeaGreen;
            this.Adaugare_Clienti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Adaugare_Clienti.FlatAppearance.BorderSize = 0;
            this.Adaugare_Clienti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.Adaugare_Clienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adaugare_Clienti.Location = new System.Drawing.Point(25, 359);
            this.Adaugare_Clienti.Name = "Adaugare_Clienti";
            this.Adaugare_Clienti.Size = new System.Drawing.Size(161, 33);
            this.Adaugare_Clienti.TabIndex = 68;
            this.Adaugare_Clienti.Text = "Adaugare";
            this.Adaugare_Clienti.UseVisualStyleBackColor = false;
            this.Adaugare_Clienti.Click += new System.EventHandler(this.Adaugare_Clienti_Click);
            // 
            // dgv_Clienti
            // 
            this.dgv_Clienti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Clienti.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Clienti.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgv_Clienti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Clienti.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Clienti.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Clienti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Clienti.ColumnHeadersHeight = 30;
            this.dgv_Clienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Clienti.EnableHeadersVisualStyles = false;
            this.dgv_Clienti.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv_Clienti.Location = new System.Drawing.Point(431, 88);
            this.dgv_Clienti.Name = "dgv_Clienti";
            this.dgv_Clienti.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Clienti.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Clienti.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Clienti.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Clienti.RowTemplate.Height = 24;
            this.dgv_Clienti.Size = new System.Drawing.Size(600, 304);
            this.dgv_Clienti.TabIndex = 70;
            this.dgv_Clienti.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_Clienti_RowHeaderMouseClick_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1043, 403);
            this.Controls.Add(this.dgv_Clienti);
            this.Controls.Add(this.Actualizare_Clienti);
            this.Controls.Add(this.Adaugare_Clienti);
            this.Controls.Add(this.txt_Nr_Tell);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_Clienti);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Adresa);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Prenume);
            this.Controls.Add(this.txt_Nume);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_Search);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClienti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClienti";
            this.Load += new System.EventHandler(this.FrmClienti_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clienti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Search;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nr_Tell;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Clienti;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Adresa;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Prenume;
        private System.Windows.Forms.TextBox txt_Nume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Actualizare_Clienti;
        private System.Windows.Forms.Button Adaugare_Clienti;
        private System.Windows.Forms.DataGridView dgv_Clienti;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}