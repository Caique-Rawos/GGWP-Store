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
        public static MySqlConnection con;

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

        public static string login(String usuario, String senha)
        {
            string tipo = "";

            try
            {
                con.Open();
                MySqlCommand login = new MySqlCommand("Select * from usuario_desktop_ggwp where email ='" + usuario + "' and senha ='" + senha + "'", con);
                MySqlDataReader resultado = login.ExecuteReader();
                if (resultado.Read())
                {
                    tipo = resultado["email"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return tipo;
        }
        public static void newProduct( String nome, String descricao, int preco, int quant, String cat, String usuario)
        {
                try
                {
                    con.Open();
                    MySqlCommand insere = new MySqlCommand("insert into produto_ggwp ( nome, descricao, preco, quantidade, categoria, user) values ('"+ nome + "','"+ descricao + "'," + preco + "," + quant + ",'" + cat + "','" + usuario + "')", con);
                    insere.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    con.Close();
                }    
            
        }
    }
}
