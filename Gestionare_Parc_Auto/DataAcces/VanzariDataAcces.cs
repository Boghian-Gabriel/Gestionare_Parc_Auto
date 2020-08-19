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

namespace Gestionare_Parc_Auto.DataAcces
{
    class VanzariDataAcces
    {
        static string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["StringConectareBD"].ConnectionString;

        #region Select Method
        public DataTable Select()
        {
            //Static metroh connect to database
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);

            //to hold the data  from database
            DataTable dt = new DataTable();

            try
            {
                //SQL QUERY FROM DATA TO DATABASE
                String sql = "select * from vanzari_autoturisme";

                //FOR EXECUTING PROGRAM
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

        #region Insert Method
        public bool Insert(Vanzari v)
        {
            bool succes = false;

            SqlConnection conn = new SqlConnection(CONNECTION_STRING);

            try
            {

                string sql = "Insert into vanzari_autoturisme (id_Auto, id_Client, date_vanzare)  values (@id_Auto, @id_Client, @date_vanzare)";
                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@id_Auto", v.Id_auto_V);
                cmd.Parameters.AddWithValue("@id_Client", v.Id_clienti_v);
                cmd.Parameters.AddWithValue("@date_vanzare", v.Data_vanzare);
               

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    //queryy succes
                    succes = true;
                }
                else
                {
                    //query failed
                    succes = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return succes;

        }
        #endregion

        #region Update Metod
        public bool Update(Vanzari v)
        {
            bool succes = false;
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);

            try
            {
                string sql = "Update vanzari_autoturisme set id_Auto= @id_Auto, id_Client= @id_Client, date_vanzare= @date_vanzare WHERE id_Vanzari= @id_Vanzari";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id_Auto", v.Id_auto_V);
                cmd.Parameters.AddWithValue("@id_Client", v.Id_clienti_v);
                cmd.Parameters.AddWithValue("@date_vanzare", v.Data_vanzare);
                cmd.Parameters.AddWithValue("@id_Vanzari", v.Id_vanzari);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    //query succes
                    succes = true;
                }
                else
                {
                    //query failed

                    succes = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return succes;
        }
        #endregion

        #region Search
        public DataTable Search(string keyWords)
        {
            //Static metroh connect to database
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);

            //to hold the data  from database
            DataTable dt = new DataTable();

            try
            {
                //SQL QUERY FROM DATA TO DATABASE
                String sql = "select * from vanzari_autoturisme Where  id_Vanzari LIKE '%" + keyWords + "%' OR  id_Auto LIKE '%" + keyWords + "%' OR id_Clienti LIKE '%" + keyWords + "%' OR date_vanzare LIKE '%" + keyWords + "%' ";

                //FOR EXECUTING PROGRAM
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
    }
}
