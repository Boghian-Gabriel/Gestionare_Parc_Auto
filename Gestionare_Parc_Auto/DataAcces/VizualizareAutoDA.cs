using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Gestionare_Parc_Auto.Classes;
using Gestionare_Parc_Auto.UI;

namespace Gestionare_Parc_Auto.DataAcces
{
    class VizualizareAutoDA
    {
        static string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["StringConectareBD"].ConnectionString;
        
        #region Select1 Method
        public DataTable Select()
        {
            //Static metroh connect to database
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);

            //to hold the data  from database
            DataTable dt = new DataTable();

            try
            {
                //SQL QUERY FROM DATA TO DATABASE
               // String sql = "select * from autoturisme";

                //FOR EXECUTING PROGRAM using stored procedure
                SqlCommand cmd = new SqlCommand("Vizualizare", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp3_auto";


                //GETTING DATA FROM DATABASE
                SqlDataAdapter sqlDataAdappt = new SqlDataAdapter(cmd);

                //database conn open
                conn.Open();

                //fill data in your datatable
                sqlDataAdappt.Fill(dt);

            }
            catch (Exception ex)
            {
                //throw message
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                //database conn close
                conn.Close();
            }
            //return the value in datatable
            return dt;

        }
        #endregion


        //Selectare in functie de combustibil
        #region Select2 Method
        public DataTable Select_Combustibil(string combustibil_tip)
        {
            //Static metroh connect to database
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);

            //to hold the data  from database
            DataTable dt = new DataTable();

            try
            {
                //SQL QUERY FROM DATA TO DATABASE
                 String sql = "select marca, model, combustibil from autoturisme where combustibil = '" + combustibil_tip + "' order by combustibil ";

                //FOR EXECUTING PROGRAM using stored procedure
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.CommandType = CommandType.StoredProcedure;
               // cmd.CommandText = "sp2_auto";


                //GETTING DATA FROM DATABASE
                SqlDataAdapter sqlDataAdappt = new SqlDataAdapter(cmd);

                //database conn open
                conn.Open();

                //fill data in your datatable
                sqlDataAdappt.Fill(dt);

            }
            catch (Exception ex)
            {
                //throw message
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                //database conn close
                conn.Close();
            }
            //return the value in datatable
            return dt;

        }
        #endregion

        //primeste 2 variabile ca parametru pe care le folosesc in frmVizualizareAutoturisme, ca sa introduc preturile, fiind lucrat pe OOP
        //a trebuit etc.. 
        //Selectea
        #region Select3 Method
        public DataTable Select_Pret(int pret1, int pret2)
        {
            //Static metroh connect to database
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);

            //to hold the data  from database
            DataTable dt = new DataTable();

            try
            {
                //SQL QUERY FROM DATA TO DATABASE
                 String sql = "select marca, model , pret , an_fabricatie , cai_putere from autoturisme " +
                             "where pret between '" + pret1 + "' and '" + pret2 + "' order by pret";

                //FOR EXECUTING PROGRAM using stored procedure
                SqlCommand cmd = new SqlCommand(sql, conn);
                


                //GETTING DATA FROM DATABASE
                SqlDataAdapter sqlDataAdappt = new SqlDataAdapter(cmd);

                //database conn open
                conn.Open();

                //fill data in your datatable
                sqlDataAdappt.Fill(dt);

            }
            catch (Exception ex)
            {
                //throw message
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                //database conn close
                conn.Close();
            }
            //return the value in datatable
            return dt;

        }
        #endregion

        //detalii autoturisme cu cateva caracteristici
        #region Select4 Method
        public DataTable Select_Caraceristici()
        {
            //Static metroh connect to database
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);

            //to hold the data  from database
            DataTable dt = new DataTable();

            try
            {
                //SQL QUERY FROM DATA TO DATABASE

                //FOR EXECUTING PROGRAM using stored procedure
                SqlCommand cmd = new SqlCommand("Vizualizare", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "detalii_auto2";



                //GETTING DATA FROM DATABASE
                SqlDataAdapter sqlDataAdappt = new SqlDataAdapter(cmd);

                //database conn open
                conn.Open();

                //fill data in your datatable
                sqlDataAdappt.Fill(dt);

            }
            catch (Exception ex)
            {
                //throw message
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                //database conn close
                conn.Close();
            }
            //return the value in datatable
            return dt;

        }
        #endregion
    }
}
