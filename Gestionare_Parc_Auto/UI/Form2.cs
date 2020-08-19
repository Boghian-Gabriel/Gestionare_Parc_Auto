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

namespace Gestionare_Parc_Auto.UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Btn_Utilizatori_Click(object sender, EventArgs e)
        {
            frmUsers fu = new frmUsers();
            fu.Show();
        }

        private void Btn_Autoturisme_Click(object sender, EventArgs e)
        {
            frmAutoturisme autoturisme = new frmAutoturisme();
            autoturisme.Show();
        }

        private void Btn_Caracteristici_Auto_Click(object sender, EventArgs e)
        {
            frmCaracteristici_Autoturisme caracteristici_Autoturisme = new frmCaracteristici_Autoturisme();
            caracteristici_Autoturisme.Show();
        }

        private void Btn_Caracteristici_Click(object sender, EventArgs e)
        {
            frmCaracteristici caracteristici = new frmCaracteristici();
            caracteristici.Show();
        }

        private void Btn_VizualizareVanzari_Click(object sender, EventArgs e)
        {
            frmImport_Auto import_Auto = new frmImport_Auto();
            import_Auto.Show();
        }

        private void Btn_Vanzari_Click(object sender, EventArgs e)
        {
            frmVanzari frmVanzari = new frmVanzari();
            frmVanzari.Show();
        }

        private void BtnClienti_Click(object sender, EventArgs e)
        {
            frmClienti clienti = new frmClienti();
            clienti.Show();
        }

        private void Btn_Vizualizare_Vanzari_Click(object sender, EventArgs e)
        {
            frmVizualizareVanzari frmVizualizareVanzari = new frmVizualizareVanzari();
            frmVizualizareVanzari.Show();
        }

        //Iesire din aplicatie, inapoi la formularul de logare
        private void Button1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void Panou_Control_Paint(object sender, PaintEventArgs e)
        {
            lbl_Logged_Admin.Text = frmLogin.loggedIn;
        }

        private void Btn_Inchidere_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void BtnMaximizare_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximizare.Visible = false;
            btnRestabilire.Visible = true;
        }

        //pentru a misca fereastra
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        //panel sus, event mouse_down  name  Bara_Titlu_MouseDown
        private void Bara_Titlu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
