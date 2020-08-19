namespace Gestionare_Parc_Auto.UI
{
    partial class frmImport_Auto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImport_Auto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ImportID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_DenumireTara = new System.Windows.Forms.TextBox();
            this.txt_AutoID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_Search = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Stergere_Inregistrare = new System.Windows.Forms.Button();
            this.Actualizare_Inregistrare = new System.Windows.Forms.Button();
            this.Adaugare_Inregistrare = new System.Windows.Forms.Button();
            this.dgv_ImportAuto = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ImportAuto)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(798, 38);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(772, 3);
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
            this.label1.Location = new System.Drawing.Point(290, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Import Autoturisme";
            // 
            // txt_ImportID
            // 
            this.txt_ImportID.Location = new System.Drawing.Point(31, 136);
            this.txt_ImportID.Name = "txt_ImportID";
            this.txt_ImportID.Size = new System.Drawing.Size(252, 22);
            this.txt_ImportID.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(28, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 21);
            this.label9.TabIndex = 47;
            this.label9.Text = "Import ID";
            // 
            // txt_DenumireTara
            // 
            this.txt_DenumireTara.Location = new System.Drawing.Point(29, 255);
            this.txt_DenumireTara.Name = "txt_DenumireTara";
            this.txt_DenumireTara.Size = new System.Drawing.Size(251, 22);
            this.txt_DenumireTara.TabIndex = 46;
            this.txt_DenumireTara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_DenumireTara_KeyPress);
            // 
            // txt_AutoID
            // 
            this.txt_AutoID.Location = new System.Drawing.Point(29, 196);
            this.txt_AutoID.Name = "txt_AutoID";
            this.txt_AutoID.Size = new System.Drawing.Size(251, 22);
            this.txt_AutoID.TabIndex = 45;
            this.txt_AutoID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_AutoID_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 21);
            this.label3.TabIndex = 44;
            this.label3.Text = "Denumire Tara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 43;
            this.label2.Text = "Auto ID";
            // 
            // text_Search
            // 
            this.text_Search.Location = new System.Drawing.Point(469, 66);
            this.text_Search.Name = "text_Search";
            this.text_Search.Size = new System.Drawing.Size(317, 22);
            this.text_Search.TabIndex = 51;
            this.text_Search.TextChanged += new System.EventHandler(this.Text_Search_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(356, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 21);
            this.label10.TabIndex = 50;
            this.label10.Text = "Cautare";
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // btn_Stergere_Inregistrare
            // 
            this.btn_Stergere_Inregistrare.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Stergere_Inregistrare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Stergere_Inregistrare.FlatAppearance.BorderSize = 0;
            this.btn_Stergere_Inregistrare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Stergere_Inregistrare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stergere_Inregistrare.Location = new System.Drawing.Point(27, 394);
            this.btn_Stergere_Inregistrare.Name = "btn_Stergere_Inregistrare";
            this.btn_Stergere_Inregistrare.Size = new System.Drawing.Size(256, 30);
            this.btn_Stergere_Inregistrare.TabIndex = 54;
            this.btn_Stergere_Inregistrare.Text = "Stergere";
            this.btn_Stergere_Inregistrare.UseVisualStyleBackColor = false;
            this.btn_Stergere_Inregistrare.Click += new System.EventHandler(this.Btn_Stergere_Inregistrare_Click);
            // 
            // Actualizare_Inregistrare
            // 
            this.Actualizare_Inregistrare.BackColor = System.Drawing.Color.SeaGreen;
            this.Actualizare_Inregistrare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Actualizare_Inregistrare.FlatAppearance.BorderSize = 0;
            this.Actualizare_Inregistrare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.Actualizare_Inregistrare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Actualizare_Inregistrare.Location = new System.Drawing.Point(27, 344);
            this.Actualizare_Inregistrare.Name = "Actualizare_Inregistrare";
            this.Actualizare_Inregistrare.Size = new System.Drawing.Size(256, 31);
            this.Actualizare_Inregistrare.TabIndex = 53;
            this.Actualizare_Inregistrare.Text = "Actualizare";
            this.Actualizare_Inregistrare.UseVisualStyleBackColor = false;
            this.Actualizare_Inregistrare.Click += new System.EventHandler(this.Actualizare_Inregistrare_Click);
            // 
            // Adaugare_Inregistrare
            // 
            this.Adaugare_Inregistrare.BackColor = System.Drawing.Color.SeaGreen;
            this.Adaugare_Inregistrare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Adaugare_Inregistrare.FlatAppearance.BorderSize = 0;
            this.Adaugare_Inregistrare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.Adaugare_Inregistrare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adaugare_Inregistrare.Location = new System.Drawing.Point(29, 293);
            this.Adaugare_Inregistrare.Name = "Adaugare_Inregistrare";
            this.Adaugare_Inregistrare.Size = new System.Drawing.Size(254, 32);
            this.Adaugare_Inregistrare.TabIndex = 52;
            this.Adaugare_Inregistrare.Text = "Adaugare";
            this.Adaugare_Inregistrare.UseVisualStyleBackColor = false;
            this.Adaugare_Inregistrare.Click += new System.EventHandler(this.Adaugare_Inregistrare_Click);
            // 
            // dgv_ImportAuto
            // 
            this.dgv_ImportAuto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_ImportAuto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ImportAuto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgv_ImportAuto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ImportAuto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_ImportAuto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ImportAuto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ImportAuto.ColumnHeadersHeight = 30;
            this.dgv_ImportAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_ImportAuto.EnableHeadersVisualStyles = false;
            this.dgv_ImportAuto.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv_ImportAuto.Location = new System.Drawing.Point(294, 102);
            this.dgv_ImportAuto.Name = "dgv_ImportAuto";
            this.dgv_ImportAuto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ImportAuto.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ImportAuto.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_ImportAuto.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_ImportAuto.RowTemplate.Height = 24;
            this.dgv_ImportAuto.Size = new System.Drawing.Size(492, 329);
            this.dgv_ImportAuto.TabIndex = 55;
            this.dgv_ImportAuto.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_ImportAuto_RowHeaderMouseClick_1);
            // 
            // frmImport_Auto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(798, 436);
            this.Controls.Add(this.dgv_ImportAuto);
            this.Controls.Add(this.btn_Stergere_Inregistrare);
            this.Controls.Add(this.Actualizare_Inregistrare);
            this.Controls.Add(this.Adaugare_Inregistrare);
            this.Controls.Add(this.text_Search);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_ImportID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_DenumireTara);
            this.Controls.Add(this.txt_AutoID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmImport_Auto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmImport_Auto";
            this.Load += new System.EventHandler(this.FrmImport_Auto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ImportAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ImportID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_DenumireTara;
        private System.Windows.Forms.TextBox txt_AutoID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Search;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Stergere_Inregistrare;
        private System.Windows.Forms.Button Actualizare_Inregistrare;
        private System.Windows.Forms.Button Adaugare_Inregistrare;
        private System.Windows.Forms.DataGridView dgv_ImportAuto;
    }
}