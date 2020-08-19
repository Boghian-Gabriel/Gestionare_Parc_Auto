using Gestionare_Parc_Auto.Classes;
using Gestionare_Parc_Auto.DataAcces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionare_Parc_Auto.UI
{
    public partial class frmClienti : Form
    {
        public frmClienti()
        {
            InitializeComponent();
        }

        Clienti c = new Clienti();
        ClientiDA clientiDA = new ClientiDA();
        Validare validare = new Validare();


        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Adaugare_Clienti_Click(object sender, EventArgs e)
        {
            //Getting data from UI
            c.Nume = txt_Nume.Text;
            c.Prenume = txt_Prenume.Text;
            c.Email = txt_Email.Text;

            if (int.TryParse(txt_Nr_Tell.Text, out int number))
                c.Telefon = number;
            //c.Telefon = Convert.ToInt32(txt_Nr_Tell.Text);
            c.Adresa = txt_Adresa.Text;



            //validare campuri
            if (txt_Nume.Text.Length == 0 || txt_Prenume.Text.Length == 0 || txt_Email.Text.Length == 0 || txt_Nr_Tell.Text.Length == 0 || txt_Adresa.Text.Length == 0)
            {
                MessageBox.Show("Completati campurile respective!", "B", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Inserting data into database
                bool succes = clientiDA.Insert(c);

                if (succes = true)
                {
                    MessageBox.Show("Inregistrarea a fost adaugata!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Eliminare date din combi dupa adaugare
                    clear_Box();

                    //Refresh datatable
                    DataTable dt = clientiDA.Select();
                    dgv_Clienti.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Nu s-a putut finaliza inregistrarea!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void clear_Box()
        {
             txt_Clienti.Text = " ";
             txt_Nume.Text = " ";
             txt_Prenume.Text = " ";
             txt_Email.Text = " ";
             txt_Nr_Tell.Text = " ";
             txt_Adresa.Text= " ";
        }

        private void FrmClienti_Load(object sender, EventArgs e)
        {
            DataTable dt = clientiDA.Select();
            dgv_Clienti.DataSource = dt;
        }

        private void Actualizare_Clienti_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_Clienti.Text, out int clienti))
                c.Id_client = clienti;
            //c.Id_client = Convert.ToInt32(txt_Clienti.Text);

            c.Nume = txt_Nume.Text;
            c.Prenume = txt_Prenume.Text;
            c.Email =txt_Email.Text;

            if (int.TryParse(txt_Nr_Tell.Text, out int number))
                c.Telefon = number;
            //c.Telefon = Convert.ToInt32(txt_Nr_Tell.Text);
            c.Adresa = txt_Adresa.Text;

            if(txt_Clienti.Text.Length ==0 || txt_Nume.Text.Length == 0 || txt_Prenume.Text.Length==0 || txt_Email.Text.Length==0 || txt_Nr_Tell.Text.Length ==0 || txt_Adresa.Text.Length ==0 )
            {
                MessageBox.Show("Selectati inregistrarea pe care doriti sa o actualizati!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                //Updatind data into database

                bool succes = clientiDA.Update(c);

                if (succes = true)
                {
                    MessageBox.Show("Inregistrarea a fost actualizata!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Eliminare date din combi dupa adaugare
                    clear_Box();
                }
                else
                {
                    MessageBox.Show("Eroare la actualizare!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Refresh datatable
                DataTable dt = clientiDA.Select();
                dgv_Clienti.DataSource = dt;
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
                DataTable dt = clientiDA.Search(keyWords);
                dgv_Clienti.DataSource = dt;
            }
            else
            {
                //show all Auto from the database
                DataTable dt = clientiDA.Select();
                dgv_Clienti.DataSource = dt;
            }
        }

        private void Dgv_Clienti_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex; // selectarea randului din datra grid view
            txt_Clienti.Text = dgv_Clienti.Rows[rowIndex].Cells[0].Value.ToString();
            txt_Nume.Text = dgv_Clienti.Rows[rowIndex].Cells[1].Value.ToString();
            txt_Prenume.Text = dgv_Clienti.Rows[rowIndex].Cells[2].Value.ToString();
            txt_Email.Text = dgv_Clienti.Rows[rowIndex].Cells[3].Value.ToString();
            txt_Nr_Tell.Text = dgv_Clienti.Rows[rowIndex].Cells[4].Value.ToString();
            txt_Adresa.Text = dgv_Clienti.Rows[rowIndex].Cells[5].Value.ToString();
        }

        //Validare
        private void Txt_Nume_KeyPress(object sender, KeyPressEventArgs e)
        {
            validare.Validare_Caracter(sender, e);
        }

        //Validare
        private void Txt_Prenume_KeyPress(object sender, KeyPressEventArgs e)
        {
            validare.Validare_Caracter(sender, e);
        }

        //Validare
        private void Txt_Nr_Tell_KeyPress(object sender, KeyPressEventArgs e)
        {
            validare.Validare_Numar(sender, e);
        }

        private void Txt_Email_TextChanged(object sender, EventArgs e)
        {
            c.Email = txt_Email.Text;

            //sir ce contine formatul email-ului
            string validate_email = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            //expresie regulata regex, sir de caractere, compara daca ceea ce scriu eu in text box, adica daca emailul
            //introdus de mine este valid cu sirul de mai sus, ce reprezinta forma corecta a unei adrese de email
            if (Regex.IsMatch(txt_Email.Text, validate_email))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txt_Email, "Introduceti o adresa de email valida.");
            }
        }
    }
}

