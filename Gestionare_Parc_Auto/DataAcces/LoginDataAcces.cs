using Gestionare_Parc_Auto.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionare_Parc_Auto.DataAcces
{
    class LoginDataAcces
    {
        //Staric string to connect Database
        static string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["StringConectareBD"].ConnectionString;

        Criptografie criptografie = new Criptografie(); 

        public bool checkLogin(Login l)
        {
            bool succes = false;

            SqlConnection conn = new SqlConnection(CONNECTION_STRING);

            try
            {


                 string sql = "Select  * from table2_users where username=@username and password=@password and user_type = @user_type";

                SqlCommand cmd = new SqlCommand(sql, conn);
                
                cmd.Parameters.AddWithValue("@username", l.username);
                // cmd.Parameters.AddWithValue("@password", criptografie.PassHash(l.password));
                cmd.Parameters.AddWithValue("@password", l.password);
                cmd.Parameters.AddWithValue("@user_type", l.user_type);
                
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                sqlDataAdapter.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    //Login succes
                    succes = true;
                }
                else
                {
                    //Login failed
                    succes = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                conn.Close();
            }

            return succes;
        }



    }
}
