using DGVPrinterHelper;
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
    public partial class frmVizualizareVanzari : Form
    {
        public frmVizualizareVanzari()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        VizualizareVanzariDA vizualizareVanzariDA = new VizualizareVanzariDA();
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = vizualizareVanzariDA.Select();
            dataGridView_Viz_Vanzari.DataSource = dt;



        }

        //Printare
        private void Button2_Click(object sender, EventArgs e)
        {

            DGVPrinter printer = new DGVPrinter();

            //proprietati pentru printare
            printer.Title = "\r \n \r \n Gestionare Parc Autoturisme. \r \n \r";
            printer.SubTitle = " Vanzari Autoturisme. \r \n \r";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Nume: Boghian Marius-Gabriel \r \n Adresa: Suceava - Dumbraveni \r \n Email: boghiangabriel96@yahoo.com \r \n Telefon: 0747973542";
            
            //printer.
            printer.PrintDataGridView(dataGridView_Viz_Vanzari);
          
        }

        private void DataGridView_Viz_Vanzari_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // DataTable dt = vizualizareVanzariDA.Select();
            //dataGridView_Viz_Vanzari.DataSource = dt;
        }
    }
}
