namespace Gestionare_Parc_Auto.UI
{
    partial class frmVanzari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVanzari));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.text_Search = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Actualizare_Clienti = new System.Windows.Forms.Button();
            this.Adaugare_Clienti = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Vanzari_ID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Client_ID = new System.Windows.Forms.TextBox();
            this.txt_Auto_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_Data_V = new System.Windows.Forms.DateTimePicker();
            this.dgv_Vanzari = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vanzari)).BeginInit();
            this.SuspendLayout();
            // 
            // text_Search
            // 
            this.text_Search.Location = new System.Drawing.Point(563, 73);
            this.text_Search.Name = "text_Search";
            this.text_Search.Size = new System.Drawing.Size(389, 22);
            this.text_Search.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(425, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 21);
            this.label10.TabIndex = 50;
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
            this.panel1.Size = new System.Drawing.Size(965, 38);
            this.panel1.TabIndex = 49;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(939, 3);
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
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vanzari";
            // 
            // Actualizare_Clienti
            // 
            this.Actualizare_Clienti.BackColor = System.Drawing.Color.SeaGreen;
            this.Actualizare_Clienti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Actualizare_Clienti.FlatAppearance.BorderSize = 0;
            this.Actualizare_Clienti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.Actualizare_Clienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Actualizare_Clienti.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualizare_Clienti.Location = new System.Drawing.Point(229, 319);
            this.Actualizare_Clienti.Name = "Actualizare_Clienti";
            this.Actualizare_Clienti.Size = new System.Drawing.Size(167, 32);
            this.Actualizare_Clienti.TabIndex = 81;
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
            this.Adaugare_Clienti.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adaugare_Clienti.Location = new System.Drawing.Point(39, 319);
            this.Adaugare_Clienti.Name = "Adaugare_Clienti";
            this.Adaugare_Clienti.Size = new System.Drawing.Size(144, 32);
            this.Adaugare_Clienti.TabIndex = 80;
            this.Adaugare_Clienti.Text = "Adaugare";
            this.Adaugare_Clienti.UseVisualStyleBackColor = false;
            this.Adaugare_Clienti.Click += new System.EventHandler(this.Adaugare_Clienti_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(16, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 21);
            this.label12.TabIndex = 77;
            this.label12.Text = "Data Vanzare";
            // 
            // txt_Vanzari_ID
            // 
            this.txt_Vanzari_ID.Location = new System.Drawing.Point(152, 125);
            this.txt_Vanzari_ID.Name = "txt_Vanzari_ID";
            this.txt_Vanzari_ID.Size = new System.Drawing.Size(244, 22);
            this.txt_Vanzari_ID.TabIndex = 76;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 21);
            this.label9.TabIndex = 75;
            this.label9.Text = "Vanzari ID";
            // 
            // txt_Client_ID
            // 
            this.txt_Client_ID.Location = new System.Drawing.Point(152, 217);
            this.txt_Client_ID.Name = "txt_Client_ID";
            this.txt_Client_ID.Size = new System.Drawing.Size(244, 22);
            this.txt_Client_ID.TabIndex = 72;
            this.txt_Client_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Client_ID_KeyPress);
            // 
            // txt_Auto_ID
            // 
            this.txt_Auto_ID.Location = new System.Drawing.Point(152, 168);
            this.txt_Auto_ID.Name = "txt_Auto_ID";
            this.txt_Auto_ID.Size = new System.Drawing.Size(244, 22);
            this.txt_Auto_ID.TabIndex = 71;
            this.txt_Auto_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Auto_ID_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 70;
            this.label3.Text = "Client ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 82;
            this.label2.Text = "Auto ID";
            // 
            // dateTimePicker_Data_V
            // 
            this.dateTimePicker_Data_V.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker_Data_V.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Data_V.Location = new System.Drawing.Point(153, 264);
            this.dateTimePicker_Data_V.Name = "dateTimePicker_Data_V";
            this.dateTimePicker_Data_V.Size = new System.Drawing.Size(243, 22);
            this.dateTimePicker_Data_V.TabIndex = 83;
            // 
            // dgv_Vanzari
            // 
            this.dgv_Vanzari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Vanzari.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Vanzari.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgv_Vanzari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Vanzari.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Vanzari.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Vanzari.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Vanzari.ColumnHeadersHeight = 30;
            this.dgv_Vanzari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Vanzari.EnableHeadersVisualStyles = false;
            this.dgv_Vanzari.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv_Vanzari.Location = new System.Drawing.Point(414, 101);
            this.dgv_Vanzari.Name = "dgv_Vanzari";
            this.dgv_Vanzari.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Vanzari.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Vanzari.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Vanzari.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Vanzari.RowTemplate.Height = 24;
            this.dgv_Vanzari.Size = new System.Drawing.Size(539, 272);
            this.dgv_Vanzari.TabIndex = 84;
            this.dgv_Vanzari.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_Vanzari_RowHeaderMouseClick);
            // 
            // frmVanzari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(965, 385);
            this.Controls.Add(this.dgv_Vanzari);
            this.Controls.Add(this.dateTimePicker_Data_V);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Actualizare_Clienti);
            this.Controls.Add(this.Adaugare_Clienti);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_Vanzari_ID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Client_ID);
            this.Controls.Add(this.txt_Auto_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_Search);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVanzari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVanzari";
            this.Load += new System.EventHandler(this.FrmVanzari_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vanzari)).EndInit();
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
        private System.Windows.Forms.Button Actualizare_Clienti;
        private System.Windows.Forms.Button Adaugare_Clienti;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Vanzari_ID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Client_ID;
        private System.Windows.Forms.TextBox txt_Auto_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Data_V;
        private System.Windows.Forms.DataGridView dgv_Vanzari;
    }
}