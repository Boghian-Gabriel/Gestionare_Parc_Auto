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
    class ClientiDA
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
                String sql = "select * from clienti";

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
        public bool Insert(Clienti c)
        {
            bool succes = false;

            SqlConnection conn = new SqlConnection(CONNECTION_STRING);

            try
            {

                string sql = "Insert into clienti (nume, prenume, email, telefon, adresa)  values (@nume, @prenume, @email, @telefon, @adresa)";
                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@nume", c.Nume);
                cmd.Parameters.AddWithValue("@prenume", c.Prenume);
                cmd.Parameters.AddWithValue("@email", c.Email);
                cmd.Parameters.AddWithValue("@telefon", c.Telefon);
                cmd.Parameters.AddWithValue("@adresa", c.Adresa);
           
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
        public bool Update(Clienti c)
        {
            bool succes = false;
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);

            try
            {
                string sql = "Update clienti set nume= @nume, prenume= @prenume, email= @email, telefon=@telefon, adresa=@adresa WHERE id_Client= @id_Client";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nume", c.Nume);
                cmd.Parameters.AddWithValue("@prenume", c.Prenume);
                cmd.Parameters.AddWithValue("@email", c.Email);
                cmd.Parameters.AddWithValue("@telefon", c.Telefon);
                cmd.Parameters.AddWithValue("@adresa", c.Adresa);
                cmd.Parameters.AddWithValue("@id_Client", c.Id_client);

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
                String sql = "select * from clienti Where  id_Client LIKE '%" + keyWords + "%' OR  nume LIKE '%" + keyWords + "%' OR prenume LIKE '%" + keyWords + "%' ";

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
