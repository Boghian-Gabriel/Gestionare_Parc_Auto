namespace Gestionare_Parc_Auto.UI
{
    partial class frmAutoturisme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutoturisme));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_An_Fabricatie = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.text_Combustibil = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Stergere_Autoturism = new System.Windows.Forms.Button();
            this.Actualizare_Autoturism = new System.Windows.Forms.Button();
            this.Adaugare_Autoturism = new System.Windows.Forms.Button();
            this.text_Search = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_AutoturismID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.combo_Stare_Auto = new System.Windows.Forms.ComboBox();
            this.txt_Cai_Putere = new System.Windows.Forms.TextBox();
            this.txt_Culoare = new System.Windows.Forms.TextBox();
            this.txt_Pret = new System.Windows.Forms.TextBox();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_Autoturisme = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Autoturisme)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1411, 38);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1385, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(649, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Autoturisme";
            // 
            // txt_An_Fabricatie
            // 
            this.txt_An_Fabricatie.Location = new System.Drawing.Point(212, 204);
            this.txt_An_Fabricatie.Name = "txt_An_Fabricatie";
            this.txt_An_Fabricatie.Size = new System.Drawing.Size(252, 22);
            this.txt_An_Fabricatie.TabIndex = 52;
            this.txt_An_Fabricatie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_An_Fabricatie_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(57, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 21);
            this.label12.TabIndex = 51;
            this.label12.Text = "An Fabricatie";
            // 
            // text_Combustibil
            // 
            this.text_Combustibil.Location = new System.Drawing.Point(211, 282);
            this.text_Combustibil.Name = "text_Combustibil";
            this.text_Combustibil.Size = new System.Drawing.Size(252, 22);
            this.text_Combustibil.TabIndex = 50;
            this.text_Combustibil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_Combustibil_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(59, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 21);
            this.label11.TabIndex = 49;
            this.label11.Text = "Combustibil";
            // 
            // btn_Stergere_Autoturism
            // 
            this.btn_Stergere_Autoturism.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Stergere_Autoturism.FlatAppearance.BorderSize = 0;
            this.btn_Stergere_Autoturism.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Stergere_Autoturism.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stergere_Autoturism.Location = new System.Drawing.Point(1199, 513);
            this.btn_Stergere_Autoturism.Name = "btn_Stergere_Autoturism";
            this.btn_Stergere_Autoturism.Size = new System.Drawing.Size(201, 36);
            this.btn_Stergere_Autoturism.TabIndex = 48;
            this.btn_Stergere_Autoturism.Text = "Stergere";
            this.btn_Stergere_Autoturism.UseVisualStyleBackColor = false;
            this.btn_Stergere_Autoturism.Click += new System.EventHandler(this.Btn_Stergere_Autoturism_Click);
            // 
            // Actualizare_Autoturism
            // 
            this.Actualizare_Autoturism.BackColor = System.Drawing.Color.SeaGreen;
            this.Actualizare_Autoturism.FlatAppearance.BorderSize = 0;
            this.Actualizare_Autoturism.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.Actualizare_Autoturism.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Actualizare_Autoturism.Location = new System.Drawing.Point(895, 513);
            this.Actualizare_Autoturism.Name = "Actualizare_Autoturism";
            this.Actualizare_Autoturism.Size = new System.Drawing.Size(201, 36);
            this.Actualizare_Autoturism.TabIndex = 47;
            this.Actualizare_Autoturism.Text = "Actualizare";
            this.Actualizare_Autoturism.UseVisualStyleBackColor = false;
            this.Actualizare_Autoturism.Click += new System.EventHandler(this.Actualizare_Autoturism_Click);
            // 
            // Adaugare_Autoturism
            // 
            this.Adaugare_Autoturism.BackColor = System.Drawing.Color.SeaGreen;
            this.Adaugare_Autoturism.FlatAppearance.BorderSize = 0;
            this.Adaugare_Autoturism.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.Adaugare_Autoturism.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adaugare_Autoturism.Location = new System.Drawing.Point(573, 513);
            this.Adaugare_Autoturism.Name = "Adaugare_Autoturism";
            this.Adaugare_Autoturism.Size = new System.Drawing.Size(201, 36);
            this.Adaugare_Autoturism.TabIndex = 46;
            this.Adaugare_Autoturism.Text = "Adaugare";
            this.Adaugare_Autoturism.UseVisualStyleBackColor = false;
            this.Adaugare_Autoturism.Click += new System.EventHandler(this.Adaugare_Autoturism_Click);
            // 
            // text_Search
            // 
            this.text_Search.Location = new System.Drawing.Point(751, 59);
            this.text_Search.Multiline = true;
            this.text_Search.Name = "text_Search";
            this.text_Search.Size = new System.Drawing.Size(652, 27);
            this.text_Search.TabIndex = 45;
            this.text_Search.TextChanged += new System.EventHandler(this.Text_Search_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(569, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 21);
            this.label10.TabIndex = 44;
            this.label10.Text = "Cautare ";
            // 
            // txt_AutoturismID
            // 
            this.txt_AutoturismID.Location = new System.Drawing.Point(211, 50);
            this.txt_AutoturismID.Name = "txt_AutoturismID";
            this.txt_AutoturismID.Size = new System.Drawing.Size(252, 22);
            this.txt_AutoturismID.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(57, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 21);
            this.label9.TabIndex = 41;
            this.label9.Text = "Auto ID";
            // 
            // combo_Stare_Auto
            // 
            this.combo_Stare_Auto.FormattingEnabled = true;
            this.combo_Stare_Auto.Items.AddRange(new object[] {
            "Disponibil",
            "Vandut",
            "In curand"});
            this.combo_Stare_Auto.Location = new System.Drawing.Point(211, 364);
            this.combo_Stare_Auto.Name = "combo_Stare_Auto";
            this.combo_Stare_Auto.Size = new System.Drawing.Size(252, 24);
            this.combo_Stare_Auto.TabIndex = 39;
            // 
            // txt_Cai_Putere
            // 
            this.txt_Cai_Putere.Location = new System.Drawing.Point(211, 323);
            this.txt_Cai_Putere.Name = "txt_Cai_Putere";
            this.txt_Cai_Putere.Size = new System.Drawing.Size(252, 22);
            this.txt_Cai_Putere.TabIndex = 38;
            this.txt_Cai_Putere.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cai_Putere_KeyPress);
            // 
            // txt_Culoare
            // 
            this.txt_Culoare.Location = new System.Drawing.Point(211, 243);
            this.txt_Culoare.Name = "txt_Culoare";
            this.txt_Culoare.Size = new System.Drawing.Size(252, 22);
            this.txt_Culoare.TabIndex = 37;
            this.txt_Culoare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Culoare_KeyPress);
            // 
            // txt_Pret
            // 
            this.txt_Pret.Location = new System.Drawing.Point(211, 166);
            this.txt_Pret.Name = "txt_Pret";
            this.txt_Pret.Size = new System.Drawing.Size(252, 22);
            this.txt_Pret.TabIndex = 36;
            this.txt_Pret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Pret_KeyPress);
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(212, 128);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(252, 22);
            this.txt_Model.TabIndex = 35;
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(211, 88);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(252, 22);
            this.txt_Marca.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(43, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 21);
            this.label7.TabIndex = 32;
            this.label7.Text = "Stare Autoturism";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(56, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 31;
            this.label6.Text = "Cai putere";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(59, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 30;
            this.label5.Text = "Culoare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(60, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Pret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Marca";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_Marca);
            this.panel2.Controls.Add(this.txt_An_Fabricatie);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.text_Combustibil);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_Model);
            this.panel2.Controls.Add(this.txt_Pret);
            this.panel2.Controls.Add(this.txt_Culoare);
            this.panel2.Controls.Add(this.txt_Cai_Putere);
            this.panel2.Controls.Add(this.txt_AutoturismID);
            this.panel2.Controls.Add(this.combo_Stare_Auto);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(48, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 408);
            this.panel2.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, -2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 21);
            this.label8.TabIndex = 53;
            this.label8.Text = "Autoturisme";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_Autoturisme);
            this.panel3.Location = new System.Drawing.Point(570, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(833, 408);
            this.panel3.TabIndex = 54;
            // 
            // dgv_Autoturisme
            // 
            this.dgv_Autoturisme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Autoturisme.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Autoturisme.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgv_Autoturisme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Autoturisme.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Autoturisme.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Autoturisme.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_Autoturisme.ColumnHeadersHeight = 30;
            this.dgv_Autoturisme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Autoturisme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Autoturisme.EnableHeadersVisualStyles = false;
            this.dgv_Autoturisme.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv_Autoturisme.Location = new System.Drawing.Point(0, 0);
            this.dgv_Autoturisme.Name = "dgv_Autoturisme";
            this.dgv_Autoturisme.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Autoturisme.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_Autoturisme.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Autoturisme.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_Autoturisme.RowTemplate.Height = 24;
            this.dgv_Autoturisme.Size = new System.Drawing.Size(833, 408);
            this.dgv_Autoturisme.TabIndex = 18;
            this.dgv_Autoturisme.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_Users_RowHeaderMouseClick);
            // 
            // frmAutoturisme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1411, 576);
            this.Controls.Add(this.text_Search);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Stergere_Autoturism);
            this.Controls.Add(this.Actualizare_Autoturism);
            this.Controls.Add(this.Adaugare_Autoturism);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAutoturisme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAutoturisme";
            this.Load += new System.EventHandler(this.FrmAutoturisme_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Autoturisme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_An_Fabricatie;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox text_Combustibil;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Stergere_Autoturism;
        private System.Windows.Forms.Button Actualizare_Autoturism;
        private System.Windows.Forms.Button Adaugare_Autoturism;
        private System.Windows.Forms.TextBox text_Search;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_AutoturismID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combo_Stare_Auto;
        private System.Windows.Forms.TextBox txt_Cai_Putere;
        private System.Windows.Forms.TextBox txt_Culoare;
        private System.Windows.Forms.TextBox txt_Pret;
        private System.Windows.Forms.TextBox txt_Model;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_Autoturisme;
    }
}