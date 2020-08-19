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
    public partial class frmAchizitionare : Form
    {
        public frmAchizitionare()
        {
            InitializeComponent();
        }

        Clienti c = new Clienti();
        ClientiDA clientiDA = new ClientiDA();

        AutoturismeDataAcces autoturismeDA = new AutoturismeDataAcces();
        Validare validare = new Validare();

        //cream data table global, ca sa nu se creeze data table la fiecare click, la  evenimentul BtnAdaugare_Click
        // si pentru a adauga mai multe inregistrari in acelasi data grid view
        DataTable dt = new DataTable();

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TxtCombustibil_TextChanged(object sender, EventArgs e)
        {

        }       

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            //get the keyword  from Cautare autoturisme searchbox
            string keyword = txt_Search.Text;

            //check  if we value to txt_Search or not
            if (keyword == "")
            {
               // txt_AutoID.Text = "";
                txt_Marca.Text = "";
                txtModel.Text = "";
                txtPret.Text = "";
                txtAnFabricatie.Text = "";
               txtCombustibil.Text = "";

                return;
            }
            //Search the Autoturisme and display on respective textboxes
            Autoturisme a= autoturismeDA.GetAutoturismeForSales(keyword);

            //Set the values on  textboxes bassed  on  a  object 
          //  txt_AutoID.Text= a.Id_auto.ToString();
            txt_Marca.Text = a.Marca;
            txtModel.Text = a.Model;
            txtPret.Text = a.Pret.ToString();
            txtAnFabricatie.Text = a.An_fabricatie;
            txtCombustibil.Text = a.Combustibil;

        }

        //Adaugare inregistrare cu autoturismul pe care-l achizitionezi
        private void BtnAdaugare_Click(object sender, EventArgs e)
        {
            //Get marca model etc

            string marca = txt_Marca.Text;
            string model = txtModel.Text;
            int pret = Convert.ToInt32(txtPret.Text);
            string an_fab = txtAnFabricatie.Text;
            string combustibil = txtCombustibil.Text;

            //Check whetever the cars is selected or not
            if (marca == "")
            {
                //Display error message
                MessageBox.Show("Selecteaza marca mai intai!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                // add register to the  dara grid view
                dt.Rows.Add(marca, model, pret, an_fab, combustibil);

                //Show in data gird view
                dgv_Adaugare_Autoturisme.DataSource = dt;

                //clear the textbox
                clear_TextBox();
            }

        }

        private void clear_TextBox()
        {
            txt_Search.Text = "";
            txt_Marca.Text = "";
            txtModel.Text = "";
            txtPret.Text = "0";
            txtAnFabricatie.Text = "";
            txtCombustibil.Text = "";
        }

        //eveniment de adaugare /  load - 
        private void FrmAchizitionare_Load(object sender, EventArgs e)
        {
            //Specify columns for our DataTable  DT, names columns for dt in gridview
            dt.Columns.Add("Marca");
            dt.Columns.Add("Model");
            dt.Columns.Add("Pret");
            dt.Columns.Add("An_Fabricatie");
            dt.Columns.Add("Combustibil");

        }

        //Cumparare Autoturism completand un formular
        // dupa ce a cumparat autoturismul, clientul s-a inregistrat automat in baza de date
        // userul sau adminul trebuie sa modifice in cazul asta inregistrarile 
        //de exemplu la Stare autoturism marcandu l ca ' Vandut' TINAND COND DE INREGISTRAREA ADAUGATA IN DATAGRIDVIEW 
        // in Achiztionare, 
        private void Button1_Click(object sender, EventArgs e)
        {
            //Getting data from UI
            c.Nume = txtNumeClient.Text;
            c.Prenume = txtPrenumeClient.Text;
            c.Email = txtEmailClient.Text;

            if (int.TryParse(txtTelefonClient.Text, out int number))
                c.Telefon = number;
           // c.Telefon = Convert.ToInt32(txtTelefonClient.Text);
            c.Adresa = txtAdresaClient.Text;



            //validare campuri
            if (txtNumeClient.Text.Length == 0 || txtPrenumeClient.Text.Length == 0 || txtEmailClient.Text.Length == 0 || txtTelefonClient.Text.Length == 0 || txtAdresaClient.Text.Length == 0)
            {
                MessageBox.Show("Introdu datele in campurile respective!", "B", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Inserting data into database
                bool succes = clientiDA.Insert(c);

                if (succes = true)
                {
                    MessageBox.Show("Felicitari! Ati achizitionat un autoturism de la firma noastra. Va multumim!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Eliminare date din combi dupa adaugare
                    clear_Box_Cienti();

                    //Refresh datatable
                    DataTable dt = clientiDA.Select();
                    //dgv_Clienti.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Nu s-a putut finaliza cumpararea!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private void clear_Box_Cienti()
        {
             txtNumeClient.Text = "";
             txtPrenumeClient.Text="";
             txtEmailClient.Text="";
             txtTelefonClient.Text="";
             txtAdresaClient.Text="";
        }

        //Validare
        private void TxtNumeClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            validare.Validare_Caracter(sender, e);
        }

        //Validare
        private void TxtPrenumeClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            validare.Validare_Caracter(sender, e);
        }
        //Validare
        private void TxtTelefonClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            validare.Validare_Numar(sender, e);
        }

        private void TxtEmailClient_TextChanged(object sender, EventArgs e)
        {
            c.Email = txtEmailClient.Text;
            //sir ce contine formatul email-ului
            string validate_email = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            //verifica daca am introdus in text box  u adresa de email valabina, conform stringului de mai sus
            if (Regex.IsMatch(txtEmailClient.Text, validate_email))
            {
                //email este valid @etc.com exemplu si atunci dispare eroarea
                errorProvider1.Clear();
            }
            else
            {
                //daca formatul nu corespunde unui email apare un avertisment
                errorProvider1.SetError(this.txtEmailClient, "Introduceti o adresa de email valida.");
            }
        }

        private void TxtTelefonClient_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtTelefonClient.Text, out int number))
                c.Telefon = number;

            if(txtTelefonClient.Text.Length < 10 || txtTelefonClient.Text.Length > 10)
            {
                errorProvider2.SetError(this.txtTelefonClient, "Introduceti un numar de telefon valid");
            }
            else
            {
                errorProvider2.Clear();
            }

        }
    }
}
