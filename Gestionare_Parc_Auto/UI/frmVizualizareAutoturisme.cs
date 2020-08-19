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
    public partial class frmVizualizareAutoturisme : Form
    {
        public frmVizualizareAutoturisme()
        {
            InitializeComponent();
        }

        VizualizareAutoDA vizualizareAutoDA = new VizualizareAutoDA();

       
        //Afiseaza marcile si modelele autoturismelor din baza de date
        private void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = vizualizareAutoDA.Select();
            dataGridView_Autoturisme.DataSource = dt;
        }

      
        //In functie de combustibil
        private void Button2_Click(object sender, EventArgs e)
        {
            DataTable dt = vizualizareAutoDA.Select_Combustibil(cmbCombustibil.Text);
            dataGridView_Autoturisme.DataSource = dt;
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Afiseaza toate autoturismele intre 2 preturi specificate
        private void Button3_Click(object sender, EventArgs e)
        {
            
            DataTable dt = vizualizareAutoDA.Select_Pret(Convert.ToInt32(txtPret1.Text), Convert.ToInt32(txtPret2.Text));
            dataGridView_Autoturisme.DataSource = dt;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            DataTable dt = vizualizareAutoDA.Select_Caraceristici();
            dataGridView_Autoturisme.DataSource = dt;
        }
    }
}
