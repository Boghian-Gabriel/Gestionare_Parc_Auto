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
using System.IO;

namespace Gestionare_Parc_Auto.DataAcces
{
    class AutoturismeDataAcces
    {
        //connect to database
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
                String sql = "select * from autoturisme";

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
        public bool Insert(Autoturisme a)
        {
            bool succes = false;

            SqlConnection conn = new SqlConnection(CONNECTION_STRING);

            try
            {
                

                string sql = "Insert into autoturisme (marca, model, pret, an_fabricatie, culoare, combustibil,cai_putere,  stare_autoturism)  values (@marca, @model, @pret, @an_fabricatie, @culoare, @combustibil, @cai_putere,  @stare_autoturism)";
                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@marca", a.Marca);
                cmd.Parameters.AddWithValue("@model", a.Model);
                cmd.Parameters.AddWithValue("@pret", a.Pret);
                cmd.Parameters.AddWithValue("@an_fabricatie", a.An_fabricatie);
                cmd.Parameters.AddWithValue("@culoare", a.Culoare);
                cmd.Parameters.AddWithValue("@combustibil", a.Combustibil);
                cmd.Parameters.AddWithValue("@cai_putere", a.Cai_putere);
                cmd.Parameters.AddWithValue("@stare_autoturism", a.Stare_Autoturism);
               




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
        public bool Update(Autoturisme a)
        {
            bool succes = false;
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);

            try
            {
                string sql = "Update autoturisme set marca= @marca, model= @model, pret= @pret, an_fabricatie=@an_fabricatie, culoare= @culoare, " +
                             "combustibil= @combustibil, cai_putere= @cai_putere,  stare_autoturism= @stare_autoturism WHERE id_Auto= @id_Auto";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@marca", a.Marca);
                cmd.Parameters.AddWithValue("@model", a.Model);
                cmd.Parameters.AddWithValue("@pret", a.Pret);
                cmd.Parameters.AddWithValue("@an_fabricatie", a.An_fabricatie);
                cmd.Parameters.AddWithValue("@culoare", a.Culoare);
                cmd.Parameters.AddWithValue("@combustibil", a.Combustibil);
                cmd.Parameters.AddWithValue("@cai_putere", a.Cai_putere);
                cmd.Parameters.AddWithValue("@stare_autoturism", a.Stare_Autoturism);
                cmd.Parameters.AddWithValue("@id_Auto", a.Id_auto);

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
        public bool Delete(Autoturisme a)
        {
            bool succes = false;

            SqlConnection conn = new SqlConnection(CONNECTION_STRING);

            try
            {
                string sql = "Delete from autoturisme WHERE id_Auto = @id_Auto";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id_Auto", a.Id_auto);

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
                String sql = "select * from autoturisme Where  id_Auto LIKE '%" + keyWords + "%' OR  marca LIKE '%" + keyWords + "%' OR model LIKE '%" + keyWords + "%' OR combustibil LIKE '%" + keyWords + "%' " +
                    "or culoare LIKE '%" + keyWords + "%' or an_fabricatie LIKE '%" + keyWords + "%'";

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

        #region Metoda de cautare autoturisme pentru a fi vandut
        public Autoturisme GetAutoturismeForSales(string keyWords)
        {
            //create an object for AutoturismeDataAcces and return it
            Autoturisme a = new Autoturisme();

            //SqlConnection
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);

            //Data tape to store data temporarily
            DataTable dt = new DataTable();

            try
            {
                //QUERY
                String sql = "select marca, model, pret, an_fabricatie, combustibil from autoturisme Where  id_Auto LIKE '%" + keyWords + "%' OR  marca LIKE '%" + keyWords + "%' OR model LIKE '%" + keyWords + "%' OR pret LIKE '%" + keyWords + "%' OR an_fabricatie  LIKE '%" + keyWords + "%' or combustibil LIKE '%"+keyWords+"%' ";

                //create sql data adapter to execute query
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql,conn);

                //Open DataBase
                conn.Open();

                //pass the value adapter from dt
                sqlDataAdapter.Fill(dt);

                //if we have any value on dt  then set values to AutoturismeDataAcces
                if (dt.Rows.Count > 0)
                {
                   // a.Id_auto=Convert.ToInt32(dt.Rows[0]["marca"].ToString());     
                    a.Marca = dt.Rows[0]["marca"].ToString();
                    a.Model = dt.Rows[0]["model"].ToString();
                    a.Pret = Convert.ToInt32(dt.Rows[0]["pret"].ToString());
                    a.An_fabricatie = dt.Rows[0]["an_fabricatie"].ToString();
                    a.Combustibil = dt.Rows[0]["combustibil"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();

            }

            return a;
        }
    

        #endregion

    }
}
