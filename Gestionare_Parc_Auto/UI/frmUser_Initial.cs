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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        //display username connect
        private void FrmUser_Load(object sender, EventArgs e)
        {
            lbl_Logged_InUser.Text = frmLogin.loggedIn;
        }

        //Exit form User  and  show form Login
        private void FrmUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void ClientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienti clienti = new frmClienti();
            clienti.Show();
        }

        private void AutoturismeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVizualizareAutoturisme frmVizualizareAutoturisme = new frmVizualizareAutoturisme();
            frmVizualizareAutoturisme.Show();
        }

        private void AchizitionareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAchizitionare frmAchizitionare = new frmAchizitionare();

            frmAchizitionare.Show();

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
