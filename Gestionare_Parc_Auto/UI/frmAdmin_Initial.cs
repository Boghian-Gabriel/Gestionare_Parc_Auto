using Gestionare_Parc_Auto.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionare_Parc_Auto
{
    public partial class frmAdmin_Initial : Form
    {
        public frmAdmin_Initial()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void UtilizatoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers fu = new frmUsers();
            fu.Show();
        }

        //Exit form Admin  and  show form Login

        private void FrmAdmin_Initial_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void FrmAdmin_Initial_Load(object sender, EventArgs e)
        {
            //name label - username login
            lbl_Logged_Admin.Text = frmLogin.loggedIn;
        }

        private void AutoturismeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutoturisme autoturisme = new frmAutoturisme();
            autoturisme.Show();
        }

        private void CacarteristiciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaracteristici caracteristici = new frmCaracteristici();
            caracteristici.Show();
        }

        private void CaracteristiciAutoturismeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaracteristici_Autoturisme caracteristici_Autoturisme = new frmCaracteristici_Autoturisme();
            caracteristici_Autoturisme.Show();
        }

        private void ImportAutoturismeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImport_Auto import_Auto = new frmImport_Auto();
            import_Auto.Show();
        }

        private void ClientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienti clienti = new frmClienti();
            clienti.Show();
        }

        private void VanzariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVanzari frmVanzari = new frmVanzari();
            frmVanzari.Show();
        }

        private void VizualizareVanzariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVizualizareVanzari frmVizualizareVanzari = new frmVizualizareVanzari();
            frmVizualizareVanzari.Show();
        }
    }
}
