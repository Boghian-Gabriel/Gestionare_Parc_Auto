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
    class ImportAutoDA
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
                String sql = "select * from import_autoturisme";

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
        public bool Insert(Import_Autoturisme ia)
        {
            bool succes = false;

            SqlConnection conn = new SqlConnection(CONNECTION_STRING);

            try
            {

                string sql = "Insert into import_autoturisme (id_Auto, denumire_tara)  values (@id_Auto, @denumire_tara)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id_Auto", ia.id_Auto);
                cmd.Parameters.AddWithValue("@denumire_tara", ia.Denumire_tara);
           
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
        public bool Update(Import_Autoturisme ia)
        {
            bool succes = false;
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);

            try
            {
                string sql = "Update import_autoturisme set id_Auto= @id_Auto, denumire_tara= @denumire_tara WHERE id_Import= @id_Import";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id_Auto", ia.id_Auto);
                cmd.Parameters.AddWithValue("@denumire_tara", ia.Denumire_tara);
                cmd.Parameters.AddWithValue("@id_Import", ia.Id_import);
                

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
        public bool Delete(Import_Autoturisme ia)
        {
            bool succes = false;

            SqlConnection conn = new SqlConnection(CONNECTION_STRING);

            try
            {
                string sql = "Delete from import_autoturisme WHERE id_Import = @id_Import";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id_Import", ia.Id_import);

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
                String sql = "select * from import_autoturisme Where  id_Import LIKE '%" + keyWords + "%' OR  id_Auto LIKE '%" + keyWords + "%' OR denumire_tara LIKE '%" + keyWords + "%' ";

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
