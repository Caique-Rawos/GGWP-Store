
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GGWP_Store
{
    class Conexao
    {
        private static MySqlConnection con;

        

        public static Boolean getConexao(String local, String banco, String user, String senha)
        {
            Boolean retorno = false;
            try
            {
                con = new MySqlConnection("server=" + local + ";User ID=" + user + ";" + "database=" + banco + "; password=" + senha + "; SslMode = none");
                con.Open();
                retorno = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                con.Close();
            }
            finally
            {
                con.Close();
            }
            return retorno;
        }

        public static int login(String usuario, String senha)
        {

            try
            {
                con.Open();
                MySqlCommand login = new MySqlCommand("Select * from usuario_desktop_ggwp where email ='" + usuario + "' and senha ='" + senha + "'", con);
                //MySqlDataReader resultado = login.ExecuteReader();
                int valor = Convert.ToInt32(login.ExecuteScalar());
                return valor;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 0;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
