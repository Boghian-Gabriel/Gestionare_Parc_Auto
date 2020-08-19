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
    public partial class frmCaracteristici : Form
    {
        public frmCaracteristici()
        {
            InitializeComponent();
        }

        Caracteristici c = new Caracteristici();
        CaracDataAcces dac = new CaracDataAcces();
        Validare validare = new Validare(); 

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Dgv_Caracteristici_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txt_CaracteristiciID.Text = dgv_Caracteristici.Rows[rowIndex].Cells[0].Value.ToString();
            txt_Denumire_Caracteristici.Text = dgv_Caracteristici.Rows[rowIndex].Cells[1].Value.ToString();
        }

        private void FrmCaracteristici_Load(object sender, EventArgs e)
        {
            DataTable dt = dac.Select();
            dgv_Caracteristici.DataSource = dt;
        }

        private void clear_Box()
        {

            txt_Denumire_Caracteristici.Text = " ";

        }

        private void Adaugare_Carac_Click(object sender, EventArgs e)
        {
            //Getting data from UI
            c.Denumire_caracteristici = txt_Denumire_Caracteristici.Text;
            

            //validare campuri
            if (txt_Denumire_Caracteristici.Text.Length == 0) {
                MessageBox.Show("Completati campuril respectiv!", "B", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Inserting data into database
                bool succes = dac.Insert(c);

                if (succes = true)
                {
                    MessageBox.Show("Inregistrarea a fost adaugata!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Eliminare date din combi dupa adaugare
                    clear_Box();

                    //Refresh datatable
                    DataTable dt = dac.Select();
                    dgv_Caracteristici.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Nu s-a putut adauga inregistrarea!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Actualizare_Carac_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_CaracteristiciID.Text, out int caracteristici_id))
                c.Id_caracteristici = caracteristici_id;
           // c.Id_caracteristici = Convert.ToInt32(txt_CaracteristiciID.Text);
            c.Denumire_caracteristici = txt_Denumire_Caracteristici.Text;
            

            if(txt_CaracteristiciID.Text.Length == 0 || txt_Denumire_Caracteristici.Text.Length == 0)
            {
                MessageBox.Show("Selectati inregistrarea pe care doriti sa o actualizati!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                //Updatind data into database

                bool succes = dac.Update(c);

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
                DataTable dt = dac.Select();
                dgv_Caracteristici.DataSource = dt;
            }
           
        }

        private void Btn_Stergere_Carac_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txt_CaracteristiciID.Text, out int caracteristici_id1))
                c.Id_caracteristici = caracteristici_id1;

           // c.Id_caracteristici = Convert.ToInt32(txt_CaracteristiciID.Text);

            if(txt_CaracteristiciID.Text.Length == 0)
            {
                MessageBox.Show("Selectati inregistrarea pe care doriti sa o stergeti!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool succes = dac.Delete(c);
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
                 DataTable dt = dac.Select();
                    dgv_Caracteristici.DataSource = dt;
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
                DataTable dt = dac.Search(keyWords);
                dgv_Caracteristici.DataSource = dt;
            }
            else
            {
                //show all Auto from the database
                DataTable dt = dac.Select();
                dgv_Caracteristici.DataSource = dt;
            }
        }

        //Validare caractere, fara a introduce numere
        private void Txt_Denumire_Caracteristici_KeyPress(object sender, KeyPressEventArgs e)
        {
            validare.Validare_Caracter(sender, e);
        }
    }
}


