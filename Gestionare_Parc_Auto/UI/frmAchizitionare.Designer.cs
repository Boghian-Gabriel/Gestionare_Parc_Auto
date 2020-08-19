namespace Gestionare_Parc_Auto.UI
{
    partial class frmAchizitionare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAchizitionare));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.Combustibil = new System.Windows.Forms.Label();
            this.txtCombustibil = new System.Windows.Forms.TextBox();
            this.txtAnFabricatie = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.lbl_Detalii_Auto = new System.Windows.Forms.Label();
            this.panel_DataGridView = new System.Windows.Forms.Panel();
            this.dgv_Adaugare_Autoturisme = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAdresaClient = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTelefonClient = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmailClient = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrenumeClient = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNumeClient = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_DataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Adaugare_Autoturisme)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1286, 38);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1263, 0);
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
            this.label1.Location = new System.Drawing.Point(632, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Achizitionare";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnAdaugare);
            this.panel2.Controls.Add(this.Combustibil);
            this.panel2.Controls.Add(this.txtCombustibil);
            this.panel2.Controls.Add(this.txtAnFabricatie);
            this.panel2.Controls.Add(this.txtPret);
            this.panel2.Controls.Add(this.txtModel);
            this.panel2.Controls.Add(this.txt_Marca);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_Search);
            this.panel2.Controls.Add(this.lbl_Search);
            this.panel2.Controls.Add(this.lbl_Detalii_Auto);
            this.panel2.Location = new System.Drawing.Point(12, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1271, 136);
            this.panel2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cautare Autoturism";
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdaugare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdaugare.FlatAppearance.BorderSize = 0;
            this.btnAdaugare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdaugare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdaugare.Location = new System.Drawing.Point(954, 92);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(228, 31);
            this.btnAdaugare.TabIndex = 13;
            this.btnAdaugare.Text = "Adaugare inregistrare";
            this.btnAdaugare.UseVisualStyleBackColor = false;
            this.btnAdaugare.Click += new System.EventHandler(this.BtnAdaugare_Click);
            // 
            // Combustibil
            // 
            this.Combustibil.AutoSize = true;
            this.Combustibil.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combustibil.ForeColor = System.Drawing.Color.White;
            this.Combustibil.Location = new System.Drawing.Point(597, 92);
            this.Combustibil.Name = "Combustibil";
            this.Combustibil.Size = new System.Drawing.Size(107, 21);
            this.Combustibil.TabIndex = 12;
            this.Combustibil.Text = "Combustibil";
            // 
            // txtCombustibil
            // 
            this.txtCombustibil.Location = new System.Drawing.Point(742, 92);
            this.txtCombustibil.Name = "txtCombustibil";
            this.txtCombustibil.Size = new System.Drawing.Size(161, 22);
            this.txtCombustibil.TabIndex = 11;
            this.txtCombustibil.TextChanged += new System.EventHandler(this.TxtCombustibil_TextChanged);
            // 
            // txtAnFabricatie
            // 
            this.txtAnFabricatie.Location = new System.Drawing.Point(424, 95);
            this.txtAnFabricatie.Name = "txtAnFabricatie";
            this.txtAnFabricatie.Size = new System.Drawing.Size(161, 22);
            this.txtAnFabricatie.TabIndex = 10;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(1021, 48);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(161, 22);
            this.txtPret.TabIndex = 9;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(742, 48);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(161, 22);
            this.txtModel.TabIndex = 8;
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(424, 45);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(161, 22);
            this.txt_Marca.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(290, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "An fabricatie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(950, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(640, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(342, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marca";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(87, 68);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(179, 22);
            this.txt_Search.TabIndex = 2;
            this.txt_Search.TextChanged += new System.EventHandler(this.Txt_Search_TextChanged);
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search.ForeColor = System.Drawing.Color.White;
            this.lbl_Search.Location = new System.Drawing.Point(14, 67);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(67, 21);
            this.lbl_Search.TabIndex = 1;
            this.lbl_Search.Text = "Search";
            // 
            // lbl_Detalii_Auto
            // 
            this.lbl_Detalii_Auto.AutoSize = true;
            this.lbl_Detalii_Auto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Detalii_Auto.ForeColor = System.Drawing.Color.White;
            this.lbl_Detalii_Auto.Location = new System.Drawing.Point(3, 0);
            this.lbl_Detalii_Auto.Name = "lbl_Detalii_Auto";
            this.lbl_Detalii_Auto.Size = new System.Drawing.Size(160, 19);
            this.lbl_Detalii_Auto.TabIndex = 0;
            this.lbl_Detalii_Auto.Text = "Detalii Autoturisme";
            // 
            // panel_DataGridView
            // 
            this.panel_DataGridView.Controls.Add(this.dgv_Adaugare_Autoturisme);
            this.panel_DataGridView.Controls.Add(this.label7);
            this.panel_DataGridView.Location = new System.Drawing.Point(12, 240);
            this.panel_DataGridView.Name = "panel_DataGridView";
            this.panel_DataGridView.Size = new System.Drawing.Size(660, 402);
            this.panel_DataGridView.TabIndex = 4;
            // 
            // dgv_Adaugare_Autoturisme
            // 
            this.dgv_Adaugare_Autoturisme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Adaugare_Autoturisme.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Adaugare_Autoturisme.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgv_Adaugare_Autoturisme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Adaugare_Autoturisme.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Adaugare_Autoturisme.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Adaugare_Autoturisme.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Adaugare_Autoturisme.ColumnHeadersHeight = 30;
            this.dgv_Adaugare_Autoturisme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Adaugare_Autoturisme.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Adaugare_Autoturisme.EnableHeadersVisualStyles = false;
            this.dgv_Adaugare_Autoturisme.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv_Adaugare_Autoturisme.Location = new System.Drawing.Point(0, 34);
            this.dgv_Adaugare_Autoturisme.Name = "dgv_Adaugare_Autoturisme";
            this.dgv_Adaugare_Autoturisme.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Adaugare_Autoturisme.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Adaugare_Autoturisme.RowHeadersWidth = 51;
            this.dgv_Adaugare_Autoturisme.RowTemplate.Height = 24;
            this.dgv_Adaugare_Autoturisme.Size = new System.Drawing.Size(660, 368);
            this.dgv_Adaugare_Autoturisme.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Adaugare Autoturisme";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.txtAdresaClient);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txtTelefonClient);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtEmailClient);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtPrenumeClient);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtNumeClient);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(678, 240);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(605, 402);
            this.panel3.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(131, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(399, 19);
            this.label14.TabIndex = 15;
            this.label14.Text = "Introduceti datele persoanei care cumpara autoturismul";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(219, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 46);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cumpara";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtAdresaClient
            // 
            this.txtAdresaClient.Location = new System.Drawing.Point(219, 266);
            this.txtAdresaClient.Name = "txtAdresaClient";
            this.txtAdresaClient.Size = new System.Drawing.Size(250, 22);
            this.txtAdresaClient.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(131, 265);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 21);
            this.label13.TabIndex = 11;
            this.label13.Text = "Adresa";
            // 
            // txtTelefonClient
            // 
            this.txtTelefonClient.Location = new System.Drawing.Point(219, 228);
            this.txtTelefonClient.Name = "txtTelefonClient";
            this.txtTelefonClient.Size = new System.Drawing.Size(250, 22);
            this.txtTelefonClient.TabIndex = 10;
            this.txtTelefonClient.TextChanged += new System.EventHandler(this.TxtTelefonClient_TextChanged);
            this.txtTelefonClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefonClient_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(131, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 21);
            this.label12.TabIndex = 9;
            this.label12.Text = "Telefon";
            // 
            // txtEmailClient
            // 
            this.txtEmailClient.Location = new System.Drawing.Point(219, 188);
            this.txtEmailClient.Name = "txtEmailClient";
            this.txtEmailClient.Size = new System.Drawing.Size(250, 22);
            this.txtEmailClient.TabIndex = 8;
            this.txtEmailClient.TextChanged += new System.EventHandler(this.TxtEmailClient_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(131, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 21);
            this.label11.TabIndex = 7;
            this.label11.Text = "Email";
            // 
            // txtPrenumeClient
            // 
            this.txtPrenumeClient.Location = new System.Drawing.Point(219, 144);
            this.txtPrenumeClient.Name = "txtPrenumeClient";
            this.txtPrenumeClient.Size = new System.Drawing.Size(250, 22);
            this.txtPrenumeClient.TabIndex = 6;
            this.txtPrenumeClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrenumeClient_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(131, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 21);
            this.label10.TabIndex = 5;
            this.label10.Text = "Prenume";
            // 
            // txtNumeClient
            // 
            this.txtNumeClient.Location = new System.Drawing.Point(219, 106);
            this.txtNumeClient.Name = "txtNumeClient";
            this.txtNumeClient.Size = new System.Drawing.Size(250, 22);
            this.txtNumeClient.TabIndex = 4;
            this.txtNumeClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeClient_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(131, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nume";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Formular Cumparare Autoturism";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // frmAchizitionare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1286, 654);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_DataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAchizitionare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAchizitionare";
            this.Load += new System.EventHandler(this.FrmAchizitionare_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_DataGridView.ResumeLayout(false);
            this.panel_DataGridView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Adaugare_Autoturisme)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Label Combustibil;
        private System.Windows.Forms.TextBox txtCombustibil;
        private System.Windows.Forms.TextBox txtAnFabricatie;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.Label lbl_Detalii_Auto;
        private System.Windows.Forms.Panel panel_DataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAdresaClient;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTelefonClient;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmailClient;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrenumeClient;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNumeClient;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_Adaugare_Autoturisme;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}