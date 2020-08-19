using Aplicatie_Parc_Autoturisme;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        
        Login login = new Login();
        LoginDataAcces lda = new LoginDataAcces();
        Criptografie criptografie = new Criptografie();


        //static method
        public static string loggedIn;

        //Close
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Login
        private void Btn_Login_Click(object sender, EventArgs e)
        { /*
            login.username = txt_User_Login.Text.Trim();
            login.password = txt_Password_Login.Text.Trim();
            login.user_type = cmb_Login.Text.Trim();

            if (txt_User_Login.Text.Length == 0 || txt_Password_Login.Text.Length == 0 || cmb_Login.Text.Length == 0 )
            {
                MessageBox.Show("Introduceti datele corespunzatoare campurilor!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool succes = lda.checkLogin(login);

                if (succes == true)
                {
                    MessageBox.Show("Logare cu succes!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //display loggedIn
                    loggedIn = login.username;

                    // need  to open respective forms bassed on user_type
                    switch (login.user_type)
                    {
                        case "Admin":
                            {
                                //Display Admin Forms
                                frmAdmin_Initial frmAdmin_Initial = new frmAdmin_Initial();
                                frmAdmin_Initial.Show();
                                this.Hide();
                            }
                            break;
                        case "User":
                            {
                                //Display User Forms  //frmUser_Initial, am schimbat pe parcurs numele
                                frmUser frmUser = new frmUser();
                                frmUser.Show();
                                this.Hide();

                            }
                            break;
                        default:
                            {
                                //Error
                                MessageBox.Show("Invalid user type");

                            }
                            break;


                    }
                }
                else
                {
                    MessageBox.Show("Introduceti corect datele! \n Eroare la logare!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            */

            login.username = txt_User_Login.Text.Trim();
            login.password = txt_Password_Login.Text.Trim();
            login.user_type = cmb_Login.Text.Trim();

            if (txt_User_Login.Text.Length != 0)
            {
                if(txt_Password_Login.Text.Length != 0)
                {
                    if(cmb_Login.Text.Length !=0)
                    {
                        bool succes = lda.checkLogin(login);

                        if (succes == true)
                        {
                            
                            MessageBox.Show("Logare cu succes!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //display loggedIn
                            loggedIn = login.username;

                            // need  to open respective forms bassed on user_type
                            switch (login.user_type)
                            {
                                case "Admin":
                                    {
                                        //Display Admin Forms
                                        /*  frmAdmin_Initial frmAdmin_Initial = new frmAdmin_Initial();
                                          frmAdmin_Initial.Show();
                                          this.Hide();
                                          */

                                        //Design 2 pentru fereastra de Admin
                                        Form2 frmAdmin = new Form2();
                                        frmAdmin.Show();
                                        this.Hide();
                                    }
                                    break;
                                case "User":
                                    {
                                        //Display User Forms  //frmUser_Initial, am schimbat pe parcurs numele
                                        /* frmUser frmUser = new frmUser();
                                         frmUser.Show();
                                         this.Hide();
                                         */
                                          
                                        //Design 2 pentru fereastra de user
                                        Form1 frmUser = new Form1();
                                        frmUser.Show();
                                        this.Hide();

                                    }
                                    break;
                                default:
                                    {
                                        //Error
                                        MessageBox.Show("Invalid user type", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    }
                                    break;


                            }
                        }
                        else
                        {
                            MessageBox.Show("Introduceti corect datele! \n Eroare la logare!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else MessageBox.Show("Selectati tipul de user!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  
                }
               else  MessageBox.Show("Introduceti parola!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
           else MessageBox.Show("Introduceti numele!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void CheckBox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPass.Checked)
                txt_Password_Login.UseSystemPasswordChar = true;
            else
                txt_Password_Login.UseSystemPasswordChar = false;
        }

    }
}
