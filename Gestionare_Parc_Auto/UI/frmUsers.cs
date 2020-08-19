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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        Users u = new Users();
        UserDataAcces dac = new UserDataAcces();
        Validare validare = new Validare();
        Criptografie criptografie = new Criptografie();

        //Exit
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Adaugare
        private void Button1_Click(object sender, EventArgs e)
        {

            //Getting data from UI
            u.First_name = txt_FirstName.Text;
            u.Last_name = txt_LastName.Text;
            u.Email = txt_Email.Text;
            u.Username = txt_Username.Text;
            u.Password = txt_Password.Text;
            u.Adress = txt_Adress.Text;
            u.Gender = combo_Gender.Text;
            u.User_type = combo_UserType.Text;
            u.Phone = text_Phone.Text;

            //validare campuri
            if (txt_FirstName.Text.Length == 0 || txt_LastName.Text.Length == 0 || txt_Email.Text.Length == 0 || txt_Username.Text.Length ==0 || txt_Password.Text.Length == 0 || txt_Adress.Text.Length == 0 || combo_Gender.Text.Length == 0 ||  combo_UserType.Text.Length == 0 || text_Phone.Text.Length == 0)
            {
                MessageBox.Show("Introdu datele in campurile respective!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Inserting data into database
                bool succes = dac.Insert(u);

                if (succes = true)
                {
                    MessageBox.Show("Users creat!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Eliminare date din combi dupa adaugare
                    clear_Box();
                }
                else
                {
                    MessageBox.Show("Nu s-a putut crea userul!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


                //Refresh datatable
                DataTable dt = dac.Select();
                dgv_Users.DataSource = dt;
            }
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {


            DataTable dt = dac.Select();
            dgv_Users.DataSource = dt;

            //pentru a nu mai aparea coloana id in DGV
            dgv_Users.Columns[0].Visible = false;

            //eliminare
            //dgv_Users.Columns.Remove("id_user");
        }

        private void clear_Box()
        {
            txt_UserID.Text = " ";
            txt_FirstName.Text = " ";
            txt_LastName.Text = " ";
            txt_Email.Text = " ";
            txt_Username.Text = " ";
            txt_Password.Text = " ";
            text_Phone.Text = " ";
            txt_Adress.Text = " ";
            combo_Gender.Text = " ";
            combo_UserType.Text = " ";
        }

        private void Dgv_Users_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the index of particular row
            int rowIndex = e.RowIndex;
            txt_UserID.Text = dgv_Users.Rows[rowIndex].Cells[0].Value.ToString();
            txt_FirstName.Text = dgv_Users.Rows[rowIndex].Cells[1].Value.ToString();
            txt_LastName.Text = dgv_Users.Rows[rowIndex].Cells[2].Value.ToString();
            txt_Email.Text = dgv_Users.Rows[rowIndex].Cells[3].Value.ToString();
            txt_Username.Text = dgv_Users.Rows[rowIndex].Cells[4].Value.ToString();
            txt_Password.Text = dgv_Users.Rows[rowIndex].Cells[5].Value.ToString();
            text_Phone.Text = dgv_Users.Rows[rowIndex].Cells[6].Value.ToString();
            txt_Adress.Text = dgv_Users.Rows[rowIndex].Cells[7].Value.ToString();
            combo_Gender.Text = dgv_Users.Rows[rowIndex].Cells[8].Value.ToString();
            combo_UserType.Text = dgv_Users.Rows[rowIndex].Cells[9].Value.ToString();
            
        }


        //Update
        private void Button2_Click(object sender, EventArgs e)
        {
            //get the values for user interface

            if (int.TryParse(txt_UserID.Text, out int user_id))
                u.Id_user = user_id;
           // u.Id_user = Convert.ToInt32(txt_UserID.Text);
            u.First_name = txt_FirstName.Text;
            u.Last_name = txt_LastName.Text;
            u.Email = txt_Email.Text;
            u.Username = txt_Username.Text;
            u.Password = txt_Password.Text;
            u.Adress = txt_Adress.Text;
            u.Gender = combo_Gender.Text;
            u.User_type = combo_UserType.Text;
            u.Phone = text_Phone.Text;
       

          if (txt_UserID.Text.Length ==0 || txt_FirstName.Text.Length == 0 || txt_LastName.Text.Length == 0 || txt_Email.Text.Length == 0 || txt_Username.Text.Length == 0 || txt_Password.Text.Length == 0 || txt_Adress.Text.Length == 0 || combo_Gender.Text.Length == 0 || combo_UserType.Text.Length == 0 || text_Phone.Text.Length == 0)
           {
            MessageBox.Show("Selectati inregistrarea pe care doriti sa o actualizati", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }

    
            else
            {
                //Updatind data into database

                bool succes = dac.Update(u);

                if (succes = true)
                {
                    MessageBox.Show("Users actualizat!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Eliminare date din combi dupa adaugare
                    clear_Box();
                }
                else
                {
                    MessageBox.Show("Eroare la actualizare!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Refresh datatable
                DataTable dt = dac.Select();
                dgv_Users.DataSource = dt;
            }
          
        }

        //Delete
        private void Button3_Click(object sender, EventArgs e)
        {
            //getting user id from form
            if (int.TryParse(txt_UserID.Text, out int user_id))
                u.Id_user = user_id;
            //u.Id_user = Convert.ToInt32(txt_UserID.Text);

            if(txt_UserID.Text.Length == 0 )
            {
                MessageBox.Show("Selectati inregistrarea pe care doriti sa o stergeti", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           else
           {
                bool succes = dac.Delete(u);
                if (succes = true)
                {
                    MessageBox.Show("Stergerea s-a realizat cu succes", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear_Box();
                }
                else
                {
                    MessageBox.Show("Eroare la stergere", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
           }
           
            //refresh
            DataTable dt = dac.Select();
            dgv_Users.DataSource = dt;

        }

        //Search using keyWords
        private void Text_Search_TextChanged(object sender, EventArgs e)
        {
            //get keyword from text box
            string keyWords = text_Search.Text;

            //check if the keywords has value or not
            if (keyWords != null)
            {
                //show user base on kewywords
                DataTable dt = dac.Search(keyWords);
                dgv_Users.DataSource = dt;
            }
            else
            {
                //show all users from the database
                DataTable dt = dac.Select();
                dgv_Users.DataSource = dt;
            }
        }

        //validare text box telefon pentru a introduce doar numere
        private void Text_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
           validare.Validare_Numar(sender, e);

        }

        //Validare text-boxuri ce trebuie sa contina doar numere, fara caractere
        private void Txt_FirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            validare.Validare_Caracter(sender, e);
        }

        private void Txt_LastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            validare.Validare_Caracter(sender, e);
        }

        private void Txt_Email_TextChanged(object sender, EventArgs e)
        {
            u.Email = txt_Email.Text;
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

        private void Text_Phone_TextChanged(object sender, EventArgs e)
        {
            u.Phone = text_Phone.Text;
            if (text_Phone.Text.Length < 10 || text_Phone.Text.Length > 10)
            {
                // MessageBox.Show("Eroare la introducerea numarului !", "B", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvider2.SetError(this.text_Phone, "Introduceti un numar de telefon valid.");

            }
            else
            {
                errorProvider2.Clear();
            }
        }

    }
}
