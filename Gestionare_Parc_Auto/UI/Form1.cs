using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //pentru a misca fereastra
using Gestionare_Parc_Auto.UI;

namespace Aplicatie_Parc_Autoturisme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Inchidere_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void BtnMaximizare_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximizare.Visible = false;
            btnRestabilire.Visible = true;

        }

        private void BtnRestabilire_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestabilire.Visible = false;
            BtnMaximizare.Visible = true;
        }

        private void BtnMinimizare_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //pentru a misca fereastra
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void Bara_Titlu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        private void Panou_Control_Paint(object sender, PaintEventArgs e)
        {
           lbl_Logged_InUser.Text = frmLogin.loggedIn;

        }

        //Autoturisme
        private void Btn_Autoturisme_Click(object sender, EventArgs e)
        {
            frmVizualizareAutoturisme frmVizualizareAutoturisme = new frmVizualizareAutoturisme();
            frmVizualizareAutoturisme.Show();
        }

        //Achizitionare
        private void Btn_Achizitionare_Click(object sender, EventArgs e)
        {
            frmAchizitionare frmAchizitionare = new frmAchizitionare();

            frmAchizitionare.Show();
        }

        //Vanzari Autoturisme, dupa ce un client a cumparat un autoturism, adminul trebuie sa actualizeze baza de date
        // si sa puna autoturismul ca fiind vandut la 'Stare Autoturism'
        private void Btn_Vanzari_Click(object sender, EventArgs e)
        {
            frmVanzari frmVanzari = new frmVanzari();
            frmVanzari.Show();
        }

        //Clienti, dupa ce un client a vizualizat autoturismele si s-a decis sa cumpere unul,
        // acesta trebuie sa completeze un formular cu datele personale
        private void Btn_Clienti_Click(object sender, EventArgs e)
        {
            frmClienti clienti = new frmClienti();
            clienti.Show();
        }

        //Vizualizare vanzari
        private void Btn_VizualizareVanzari_Click(object sender, EventArgs e)
        {
            frmVizualizareVanzari frmVizualizareVanzari = new frmVizualizareVanzari();
            frmVizualizareVanzari.Show();
        }

        //Iesire din aplicatie inapoi la forma de logare, 
        private void Button1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Bara_Titlu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lbl_Logged_Users_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Meniu_Vertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FlowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lbl_User_Click(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Logged_InUser_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
