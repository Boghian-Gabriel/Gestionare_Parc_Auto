using Gestionare_Parc_Auto.Classes;
using Gestionare_Parc_Auto.DataAcces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionare_Parc_Auto.UI
{
    public partial class frmAutoturisme : Form
    {
        public frmAutoturisme()
        {
            InitializeComponent();
        }

        Autoturisme a = new Autoturisme();
        AutoturismeDataAcces dac = new AutoturismeDataAcces();
        Validare validare = new Validare(); 


        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Display dataBase to dataGridView
        private void FrmAutoturisme_Load(object sender, EventArgs e)
        {
            DataTable dt = dac.Select();
            dgv_Autoturisme.DataSource = dt;
        }

        //Adaugare Autoturism
        private void Adaugare_Autoturism_Click(object sender, EventArgs e)
        {
            //Getting data from UI
            a.Marca = txt_Marca.Text;
            a.Model = txt_Model.Text;

            // "out" e un tip mai specific de "ref" in c#  
            //permite functiei aia de conversie  sa modifice variabila din interiorul functiei si sa se reflecte infara
            //keyword-ul 'ref' din c# care specifica ca sa transmita prin referinta nu prin valoare
            if (int.TryParse(txt_Pret.Text, out int pret))
                a.Pret = pret;

            a.An_fabricatie = txt_An_Fabricatie.Text;
            a.Culoare = txt_Culoare.Text;
            a.Combustibil = text_Combustibil.Text;

            if (int.TryParse(txt_Cai_Putere.Text, out int cai_putere))
                a.Cai_putere = cai_putere;

            //a.Cai_putere = Convert.ToInt32(txt_Cai_Putere.Text); //asa da exceptie
            a.Stare_Autoturism = combo_Stare_Auto.Text;
          
          

            //validare campuri
            if (txt_Marca.Text.Length == 0 || txt_Model.Text.Length == 0 || txt_Pret.Text.Length == 0 || txt_An_Fabricatie.Text.Length == 0 || txt_Culoare.Text.Length == 0 || text_Combustibil.Text.Length == 0 || txt_Cai_Putere.Text.Length == 0 || combo_Stare_Auto.Text.Length == 0)
            {
                MessageBox.Show("Completati campurile respective!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                

                //Inserting data into database
                bool succes = dac.Insert(a);

                if (succes = true)
                {
                    MessageBox.Show("Inregistrarea a fost adaugata!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Eliminare date din combi dupa adaugare
                    clear_Box();

                    //Refresh datatable
                    DataTable dt = dac.Select();
                    dgv_Autoturisme.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Nu s-a putut finaliza inregistrarea!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                } 
            }
        }


        private void clear_Box()
        {
            txt_AutoturismID.Text = "";
            txt_Marca.Text = " " ;
            txt_Model.Text = " ";
            txt_Pret.Text = " ";
            txt_An_Fabricatie.Text = " ";
            txt_Culoare.Text = " ";
            text_Combustibil.Text = " ";
            txt_Cai_Putere.Text = " ";
            combo_Stare_Auto.Text = " ";        

        }

        //Actualizare
        private void Actualizare_Autoturism_Click(object sender, EventArgs e)
        {
            //get the values for user interface

            if (int.TryParse(txt_AutoturismID.Text, out int auto))
                a.Id_auto = auto;

           // a.Id_auto = Convert.ToInt32(txt_AutoturismID.Text);
            a.Marca = txt_Marca.Text;
            a.Model = txt_Model.Text;

            if (int.TryParse(txt_Pret.Text, out int pret))
                a.Pret = pret;
            //a.Pret = Convert.ToInt32(txt_Pret.Text);

            a.An_fabricatie = txt_An_Fabricatie.Text;
            a.Culoare = txt_Culoare.Text;
            a.Combustibil = text_Combustibil.Text;

            if (int.TryParse(txt_Cai_Putere.Text, out int cai_putere))
                a.Cai_putere = cai_putere;
            //a.Cai_putere = Convert.ToInt32(txt_Cai_Putere.Text);
            a.Stare_Autoturism = combo_Stare_Auto.Text;

            if (txt_AutoturismID.Text.Length==0 || txt_Marca.Text.Length == 0 || txt_Model.Text.Length == 0 || txt_Pret.Text.Length == 0 || txt_An_Fabricatie.Text.Length == 0 || txt_Culoare.Text.Length == 0 || text_Combustibil.Text.Length == 0 || txt_Cai_Putere.Text.Length == 0 || combo_Stare_Auto.Text.Length == 0)
            {
                MessageBox.Show("Selectati inregistrarea pe care doriti sa o actualizati!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Updatind data into database

                bool succes = dac.Update(a);

                if (succes = true)
                {
                    MessageBox.Show("Autoturismul a fost  actualizat!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Eliminare date din combi dupa adaugare
                    clear_Box();
                }
                else
                {
                    MessageBox.Show("Eroare la actualizare!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Refresh datatable
                DataTable dt = dac.Select();
                dgv_Autoturisme.DataSource = dt;
            }
                
        }

        private void Btn_Stergere_Autoturism_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_AutoturismID.Text, out int auto))
                a.Id_auto = auto;
            // a.Id_auto = Convert.ToInt32(txt_AutoturismID.Text);

            if(txt_AutoturismID.Text.Length == 0)
            {
                MessageBox.Show("Selectati inregistrarea pe care doriti sa o stergeti!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool succes = dac.Delete(a);
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
                dgv_Autoturisme.DataSource = dt;


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
                dgv_Autoturisme.DataSource = dt;
            }
            else
            {
                //show all Auto from the database
                DataTable dt = dac.Select();
                dgv_Autoturisme.DataSource = dt;
            }
        }

        private void Dgv_Users_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            txt_AutoturismID.Text = dgv_Autoturisme.Rows[rowIndex].Cells[0].Value.ToString();
            txt_Marca.Text = dgv_Autoturisme.Rows[rowIndex].Cells[1].Value.ToString();
            txt_Model.Text = dgv_Autoturisme.Rows[rowIndex].Cells[2].Value.ToString();
            txt_Pret.Text = dgv_Autoturisme.Rows[rowIndex].Cells[3].Value.ToString();
            txt_An_Fabricatie.Text = dgv_Autoturisme.Rows[rowIndex].Cells[4].Value.ToString();
            txt_Culoare.Text = dgv_Autoturisme.Rows[rowIndex].Cells[5].Value.ToString();
            text_Combustibil.Text = dgv_Autoturisme.Rows[rowIndex].Cells[6].Value.ToString();
            txt_Cai_Putere.Text = dgv_Autoturisme.Rows[rowIndex].Cells[7].Value.ToString();
            combo_Stare_Auto.Text = dgv_Autoturisme.Rows[rowIndex].Cells[8].Value.ToString();
        }


        private void Txt_Pret_KeyPress(object sender, KeyPressEventArgs e)
        {
            validare.Validare_Numar(sender, e);
        }

        private void Txt_An_Fabricatie_KeyPress(object sender, KeyPressEventArgs e)
        {
            validare.Validare_Numar(sender, e);
        }

        private void Txt_Culoare_KeyPress(object sender, KeyPressEventArgs e)
        {
            validare.Validare_Caracter(sender, e);
        }

        private void Text_Combustibil_KeyPress(object sender, KeyPressEventArgs e)
        {
            validare.Validare_Caracter(sender, e);
        }

        private void Txt_Cai_Putere_KeyPress(object sender, KeyPressEventArgs e)
        {
            validare.Validare_Numar(sender, e);
        }
    }
}
    

