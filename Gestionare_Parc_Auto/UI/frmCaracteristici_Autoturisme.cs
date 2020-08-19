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
    public partial class frmCaracteristici_Autoturisme : Form
    {
        public frmCaracteristici_Autoturisme()
        {
            InitializeComponent();
        }

        Caracteristici_Autoturisme ca = new Caracteristici_Autoturisme();
        Caracteristici_Autoturisme_DA  carac_auto= new Caracteristici_Autoturisme_DA();
        Validare validare = new Validare();

        private void FrmCaracteristici_Autoturisme_Load(object sender, EventArgs e)
        {
            DataTable dt = carac_auto.Select();
            dgv_Carac_Auto.DataSource = dt; ;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Adaugare_Carac_Click(object sender, EventArgs e)
        {
            //Getting data from UI

            if (int.TryParse(txt_Caracteristici_AutoID.Text, out int carac_auto1))
                ca.Id_auto = carac_auto1;

            //ca.Id_auto = Convert.ToInt32(txt_Caracteristici_AutoID.Text);

            if (int.TryParse(txt_Den_Carac_Auto.Text, out int carac_auto2))
                ca.Id_carac = carac_auto2;

            //ca.Id_carac = Convert.ToInt32(txt_Den_Carac_Auto.Text);
            ca.Valoare = txt_Valoare_Carac.Text;

            //validare campuri
            if (txt_Caracteristici_AutoID.Text.Length == 0 || txt_Den_Carac_Auto.Text.Length == 0 || txt_Valoare_Carac.Text.Length==0)
            {
                MessageBox.Show("Completati campurile respective!", "B", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Inserting data into database
                bool succes = carac_auto.Insert(ca);

                if (succes = true)
                {
                    MessageBox.Show("Inregistrarea a fost adaugata!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Eliminare date din combi dupa adaugare
                    clear_Box();

                    //Refresh datatable
                    DataTable dt = carac_auto.Select();
                    dgv_Carac_Auto.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Nu s-a putut finaliza inregistrarea!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }
        private void clear_Box()
        {
            txt_ID_A_C.Text = "";
            txt_Den_Carac_Auto.Text = "";
            txt_Caracteristici_AutoID.Text = " ";
            txt_Valoare_Carac.Text = "";
        }

        //Dreptul de a actualiza doar campul valoare
        private void Actualizare_Carac_Click(object sender, EventArgs e)
        {
            //get the values for user interface

            if (int.TryParse(txt_ID_A_C.Text, out int carac_auto1))
                ca.Id_Carac_Auto = carac_auto1;
           // ca.Id_Carac_Auto = Convert.ToInt32(txt_ID_A_C.Text);

            if (int.TryParse(txt_Caracteristici_AutoID.Text, out int carac_auto2))
                ca.Id_auto = carac_auto2;
            //ca.Id_auto = Convert.ToInt32(txt_Caracteristici_AutoID.Text);

            if (int.TryParse(txt_Den_Carac_Auto.Text, out int carac_auto3))
                ca.Id_carac = carac_auto3;
            //ca.Id_carac = Convert.ToInt32(txt_Den_Carac_Auto.Text);

            ca.Valoare = txt_Valoare_Carac.Text;
          
            if(txt_ID_A_C.Text.Length ==0 || txt_Caracteristici_AutoID.Text.Length == 0 || txt_Den_Carac_Auto.Text.Length == 0)
            {
                MessageBox.Show("Selectati inregistrarea pe care doriti sa o actualizati!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Updatind data into database

                bool succes = carac_auto.Update(ca);

                if (succes = true)
                {
                    MessageBox.Show("Inregistrarea a fost actualizata!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Eliminare date din combi dupa adaugare
                    clear_Box();

                    //Refresh datatable
                    DataTable dt = carac_auto.Select();
                    dgv_Carac_Auto.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Eroare la actualizare!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void Btn_Stergere_Carac_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_ID_A_C.Text, out int carac_auto1))
                ca.Id_Carac_Auto = carac_auto1;

            // ca.Id_Carac_Auto = Convert.ToInt32(txt_ID_A_C.Text);

            if (txt_ID_A_C.Text.Length == 0)
            {
                MessageBox.Show("Selectati inregistrarea pe care doriti sa o stergeti!" , "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
              
                bool succes = carac_auto.Delete(ca);
                if (succes = true)
                {
                    MessageBox.Show("Stergerea s-a realizat cu succes", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    clear_Box();

                    //refresh
                    DataTable dt = carac_auto.Select();
                    dgv_Carac_Auto.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Eroare la stergere", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
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
                DataTable dt = carac_auto.Search(keyWords);
                dgv_Carac_Auto.DataSource = dt;
            }
            else
            {
                //show all Auto from the database
                DataTable dt = carac_auto.Select();
                dgv_Carac_Auto.DataSource = dt;
            }
        }

        private void Dgv_Carac_Auto_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txt_ID_A_C.Text = dgv_Carac_Auto.Rows[rowIndex].Cells[0].Value.ToString();
            txt_Caracteristici_AutoID.Text = dgv_Carac_Auto.Rows[rowIndex].Cells[1].Value.ToString();
            txt_Den_Carac_Auto.Text = dgv_Carac_Auto.Rows[rowIndex].Cells[2].Value.ToString();
            txt_Valoare_Carac.Text = dgv_Carac_Auto.Rows[rowIndex].Cells[3].Value.ToString();
        }


        //Validari
        private void Txt_Caracteristici_AutoID_KeyPress(object sender, KeyPressEventArgs e)
        {
            validare.Validare_Numar(sender, e);
        }

        //Validari
        private void Txt_Den_Carac_Auto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validare.Validare_Numar(sender, e);
        }

        //Validari
        private void Txt_Valoare_Carac_KeyPress(object sender, KeyPressEventArgs e)
        {
            validare.Validare_Caracter(sender, e);
        }

        private void Txt_Valoare_Carac_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
