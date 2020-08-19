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
    
    class UserDataAcces
    {

        //connect to database
        static string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["StringConectareBD"].ConnectionString;

        Criptografie criptografie = new Criptografie(); 
        

        #region Select data from Database

        public DataTable Select()
        {
            //Static metroh connect to database
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);

            //to hold the data  from database
            DataTable dt = new DataTable();

            try
            {
                //SQL QUERY FROM DATA TO DATABASE
                String sql = "select * from table2_users";

                //FOR EXECUTING PROGRAM
                SqlCommand cmd = new SqlCommand(sql, conn);

                //GETTING DATA FROM DATABASE
                SqlDataAdapter sqlDataAdappt = new SqlDataAdapter(cmd);

                //database conn open
                conn.Open();

                //fill data in your datatable
                sqlDataAdappt.Fill(dt);

            }
            catch(Exception ex)
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

        #region Insert
        public bool Insert (Users u)
        { 
            bool succes = false;

            SqlConnection conn = new SqlConnection(CONNECTION_STRING);

           
                try
                {
                    conn.Open();

                    string sql = "Insert into table2_users (first_name, last_name, email, username, password, adress,gender,  user_type, phone)  values (@first_name, @last_name, @email, @username, @password, @adress,@gender, @user_type, @phone)";
                    SqlCommand cmd = new SqlCommand(sql, conn);


                    cmd.Parameters.AddWithValue("@first_name", u.First_name);
                    cmd.Parameters.AddWithValue("@last_name", u.Last_name);
                    cmd.Parameters.AddWithValue("@email", u.Email);
                    cmd.Parameters.AddWithValue("@username", u.Username);
                    cmd.Parameters.AddWithValue("@password", criptografie.PassHash(u.Password));
                    cmd.Parameters.AddWithValue("@adress", u.Adress);
                    cmd.Parameters.AddWithValue("@gender", u.Gender);
                    cmd.Parameters.AddWithValue("@user_type", u.User_type);
                    cmd.Parameters.AddWithValue("@phone", u.Phone);

                    // conn.Open();
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

        #region Update

        public bool Update(Users u)
        {
            bool succes = false;
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);

            try
            {
                string sql = "Update table2_users set first_name= @first_name, last_name= @last_name, email= @email, username=@username, password= @password, " +
                             "adress= @adress, gender= @gender,  user_type= @user_type, phone= @phone WHERE id_user= @id_user";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@first_name", u.First_name);
                cmd.Parameters.AddWithValue("@last_name", u.Last_name);
                cmd.Parameters.AddWithValue("@email", u.Email);
                cmd.Parameters.AddWithValue("@username", u.Username);
                cmd.Parameters.AddWithValue("@password", u.Password);
                cmd.Parameters.AddWithValue("@adress", u.Adress);
                cmd.Parameters.AddWithValue("@gender", u.Gender);
                cmd.Parameters.AddWithValue("@user_type", u.User_type);
                cmd.Parameters.AddWithValue("@phone", u.Phone);
                cmd.Parameters.AddWithValue("@id_user", u.Id_user);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
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
            catch(Exception ex)
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

        #region Delete
        public bool Delete(Users u)
        {
            bool succes = false;

            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            
            try
            {
                string sql = "Delete from table2_users WHERE id_user = @id_user";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id_user", u.Id_user);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    succes = true;
                }
                else
                {
                    succes = false;
                }
            }
            catch(Exception ex)
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

        #region Search User in database using keyWords

        public DataTable Search(string keyWords)
        {
            //Static metroh connect to database
            SqlConnection conn = new SqlConnection(CONNECTION_STRING);

            //to hold the data  from database
            DataTable dt = new DataTable();

            try
            {
                //SQL QUERY FROM DATA TO DATABASE
                String sql = "select * from table2_users Where  id_user LIKE '%"+keyWords+"%' OR  first_name LIKE '%"+keyWords+"%' OR last_name LIKE '%"+keyWords+"%' OR username LIKE '%"+keyWords+"%'";

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
