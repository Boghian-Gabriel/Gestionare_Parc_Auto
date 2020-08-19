using Gestionare_Parc_Auto.Classes;
using Gestionare_Parc_Auto.DataAcces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionare_Parc_Auto.UI
{
    public partial class frmImport_Auto : Form
    {
        public frmImport_Auto()
        {
            InitializeComponent();
        }

        Import_Autoturisme ia = new Import_Autoturisme();
        ImportAutoDA import = new ImportAutoDA();
        Validare validare = new Validare();

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void FrmImport_Auto_Load(object sender, EventArgs e)
        {
            DataTable dt = import.Select();
            dgv_ImportAuto.DataSource = dt;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Adaugare_Inregistrare_Click(object sender, EventArgs e)
        {
            //Getting data from UI

            if (int.TryParse(txt_AutoID.Text, out int auto))
                ia.id_Auto = auto;

           // ia.id_Auto = Convert.ToInt32(txt_AutoID.Text);
            ia.Denumire_tara = txt_DenumireTara.Text;

            //validare campuri
            if (txt_AutoID.Text.Length == 0 || txt_DenumireTara.Text.Length == 0)
            {
                MessageBox.Show("Completati campurile respective!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {


                //Inserting data into database
                bool succes = import.Insert(ia);

                if (succes = true)
                {
                    MessageBox.Show("Inregistrarea a fost adaugata!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Eliminare date din combi dupa adaugare
                    clear_Box();

                    //Refresh datatable
                    DataTable dt = import.Select();
                    dgv_ImportAuto.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Nu s-a putut finaliza inregistrarea!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private void clear_Box()
        {
            txt_AutoID.Text = "";
            txt_ImportID.Text = "";
            txt_DenumireTara.Text = "";
        }

        private void Actualizare_Inregistrare_Click(object sender, EventArgs e)
        {
            //get the values for user interface

            if (int.TryParse(txt_ImportID.Text, out int auto1))
                ia.Id_import = auto1;
            //ia.Id_import = Convert.ToInt32(txt_ImportID.Text);

            if (int.TryParse(txt_AutoID.Text, out int auto2))
                ia.id_Auto = auto2;
           // ia.id_Auto = Convert.ToInt32(txt_AutoID.Text);

            ia.Denumire_tara = txt_DenumireTara.Text;

            if(txt_ImportID.Text.Length == 0 || txt_AutoID.Text.Length == 0 || txt_DenumireTara.Text.Length == 0)
            {
                MessageBox.Show("Selectati inregistrarea pe care doriti sa o actualizati!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                //Updatind data into database

                bool succes = import.Update(ia);

                if (succes = true)
                {
                    MessageBox.Show("Inregistrarea a fost actualizata!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Eliminare date din combi dupa adaugare
                    clear_Box();
                }
                else
                {
                    MessageBox.Show("Eroare la actualizare!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Refresh datatable
                DataTable dt = import.Select();
                dgv_ImportAuto.DataSource = dt;
            }
           
        }

        private void Btn_Stergere_Inregistrare_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_ImportID.Text, out int auto1))
                ia.Id_import = auto1;
           // ia.Id_import = Convert.ToInt32(txt_ImportID.Text);

            if(txt_ImportID.Text.Length == 0)
            {
                MessageBox.Show("Selectati inregistrarea pe care doriti sa o stergeti!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                bool succes = import.Delete(ia);
                if (succes = true)
                {
                    MessageBox.Show("Stergerea s-a realizat cu succes", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear_Box();
                }
                else
                {
                    MessageBox.Show("Eroare la stergere", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                //refresh
                DataTable dt = import.Select();
                dgv_ImportAuto.DataSource = dt;
            }

           
        }

        private void Text_Search_TextChanged(object sender, EventArgs e)
        {
            //get keyword from text box
            string keyWords = text_Search.Text;

            //check if the keywords has value or not
            if (keyWords != null)
            {
                //show Auto base on kewywords
                DataTable dt = import.Search(keyWords);
                dgv_ImportAuto.DataSource = dt;
            }
            else
            {
                //show all Auto from the database
                DataTable dt = import.Select();
                dgv_ImportAuto.DataSource = dt;
            }
        }

        private void Dgv_ImportAuto_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txt_ImportID.Text = dgv_ImportAuto.Rows[rowIndex].Cells[0].Value.ToString();
            txt_AutoID.Text = dgv_ImportAuto.Rows[rowIndex].Cells[1].Value.ToString();
            txt_DenumireTara.Text = dgv_ImportAuto.Rows[rowIndex].Cells[2].Value.ToString();
        }

        private void Txt_AutoID_KeyPress(object sender, KeyPressEventArgs e)
        {
            validare.Validare_Numar(sender, e);
        }

        private void Txt_DenumireTara_KeyPress(object sender, KeyPressEventArgs e)
        {
            validare.Validare_Caracter(sender, e);
        }

      
    }
}
