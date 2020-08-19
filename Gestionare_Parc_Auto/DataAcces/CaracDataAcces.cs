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
    class CaracDataAcces
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
                String sql = "select * from caracteristici";

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
        public bool Insert(Caracteristici c)
        {
            bool succes = false;

            SqlConnection conn = new SqlConnection(CONNECTION_STRING);

            try
            {

                string sql = "Insert into caracteristici (denumire)  values (@denumire)";
                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@denumire", c.Denumire_caracteristici);

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
        public bool Update(Caracteristici c)
        {
            bool succes = false;
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);

            try
            {
                string sql = "Update caracteristici set denumire= @denumire  WHERE id_Caracteristici= @id_Caracteristici";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@denumire", c.Denumire_caracteristici);
                cmd.Parameters.AddWithValue("@id_Caracteristici", c.Id_caracteristici);

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

        #region Delete Method
        public bool Delete(Caracteristici c)
        {
            bool succes = false;

            SqlConnection conn = new SqlConnection(CONNECTION_STRING);

            try
            {
                string sql = "Delete from caracteristici WHERE id_Caracteristici = @id_Caracteristici";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id_Caracteristici", c.Id_caracteristici);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    succes = true;
                }
                else
                {
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
                String sql = "select * from caracteristici Where  id_Caracteristici LIKE '%" + keyWords + "%' OR  denumire LIKE '%" + keyWords + "%'";

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
