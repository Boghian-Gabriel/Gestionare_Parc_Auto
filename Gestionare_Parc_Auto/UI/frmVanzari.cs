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
    public partial class frmVanzari : Form
    {
        public frmVanzari()
        {
            InitializeComponent();
        }

        Vanzari v = new Vanzari();
        VanzariDataAcces vanzariData = new VanzariDataAcces();
        Validare validare = new Validare();

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();

        } 

        private void FrmVanzari_Load(object sender, EventArgs e)
        {
            DataTable dt = vanzariData.Select();
            dgv_Vanzari.DataSource = dt;
        }

        private void Actualizare_Clienti_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_Vanzari_ID.Text, out int id_auto))
                v.Id_vanzari = id_auto;
            // v.Id_vanzari = Convert.ToInt32(txt_Vanzari_ID.Text);

            if (int.TryParse(txt_Auto_ID.Text, out int id_auto1))
                v.Id_auto_V = id_auto1;
            // v.Id_auto_V = Convert.ToInt32(txt_Auto_ID.Text);

            if (int.TryParse(txt_Client_ID.Text, out int id_auto2))
                v.Id_clienti_v = id_auto2;
           // v.Id_clienti_v = Convert.ToInt32(txt_Client_ID.Text);
         
            v.Data_vanzare = Convert.ToDateTime(dateTimePicker_Data_V.Text);

            if(txt_Vanzari_ID.Text.Length ==0 || txt_Auto_ID.Text.Length==0 || txt_Client_ID.Text.Length==0 || dateTimePicker_Data_V.Text.Length == 0)
            {
                MessageBox.Show("Selectati inregistrarea pe care doriti sa o actualizati!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                //Updatind data into database

                bool succes = vanzariData.Update(v);

                if (succes = true)
                {
                    MessageBox.Show("Users actualizat!");

                    //Eliminare date din combi dupa adaugare
                    clear_Box();
                }
                else
                {
                    MessageBox.Show("Eroare la actualizare!");
                }
                //Refresh datatable
                DataTable dt = vanzariData.Select();
                dgv_Vanzari.DataSource = dt;
            }
 
        }
        private void clear_Box()
        {
            txt_Vanzari_ID.Text = "";
            txt_Auto_ID.Text = "";
            txt_Vanzari_ID.Text = "";
            dateTimePicker_Data_V.Text = "";
        }

        private void Adaugare_Clienti_Click(object sender, EventArgs e)
        {
            //Getting data from UI
            if (int.TryParse(txt_Auto_ID.Text, out int id_auto))
                v.Id_auto_V = id_auto;
            // v.Id_auto_V = Convert.ToInt32(txt_Auto_ID.Text);

            if (int.TryParse(txt_Client_ID.Text, out int id_auto1))
                v.Id_clienti_v = id_auto1;
            //v.Id_clienti_v = Convert.ToInt32(txt_Client_ID.Text);

            v.Data_vanzare = Convert.ToDateTime(dateTimePicker_Data_V.Text);



            //validare campuri
            if ( txt_Auto_ID.Text.Length == 0 || txt_Client_ID.Text.Length == 0 || dateTimePicker_Data_V.Text.Length == 0 )
            {
                MessageBox.Show("Completati campurile respective!", "B", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Inserting data into database
                bool succes = vanzariData.Insert(v);

                if (succes = true)
                {
                    MessageBox.Show("Inregistrarea a fost adaugata!");

                    //Eliminare date din combi dupa adaugare
                    clear_Box();

                    //Refresh datatable
                    DataTable dt = vanzariData.Select();
                    dgv_Vanzari.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Nu s-a putut finaliza inregistrarea!");

                }
            }
        }

        private void Dgv_Vanzari_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            txt_Vanzari_ID.Text = dgv_Vanzari.Rows[rowIndex].Cells[0].Value.ToString();
            txt_Auto_ID.Text = dgv_Vanzari.Rows[rowIndex].Cells[1].Value.ToString();
            txt_Client_ID.Text = dgv_Vanzari.Rows[rowIndex].Cells[2].Value.ToString();
            dateTimePicker_Data_V.Text = dgv_Vanzari.Rows[rowIndex].Cells[3].Value.ToString();
         
        }

        //Validare
        private void Txt_Auto_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            validare.Validare_Numar(sender, e);
        }

        //Validare
        private void Txt_Client_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            validare.Validare_Numar(sender, e);
        }
    }

   
}
