using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGWP_Store
{
    class Product
    {
        private int id;
        private string nome;
        private string desc;
        private double preco;
        private string categoria;
        //private byte foto;
        private string endereco;
        private string user;
        private int qtd;

        public double Preco { get => preco; set => preco = value; }
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Desc { get => desc; set => desc = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string User { get => user; set => user = value; }
        public int Qtd { get => qtd; set => qtd = value; }

        public Product(int id, int qtd, double preco, string nome, string categoria, string desc, string endereco, string user)
        {
            this.id = id;
            this.qtd = qtd;
            this.preco = preco;
            this.nome = nome;
            this.categoria = categoria;
            this.desc = desc;
            this.endereco = endereco;
            this.user = user;
        }
        public Product(int id)
        {
            this.id = id;
        }

        public MySqlDataReader srcProduct(int id)
        {
            MySqlDataReader resultado = null;
            try
            {
                Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM produto_ggwp WHERE id_produto = " + id + ";", Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                //Conexao.con.Close();
            }
            return resultado;
        }

        public static bool newProduct(string nome, string descricao, string preco, int quant, int cat, string usuario, string data)
        {
            bool resp = false;
            try
            {
                Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into produto_ggwp (nome, descricao, preco, quantidade, categoria, usuario, data) values ('" + nome + "','" + descricao + "'," + preco + "," + quant + "," + cat + ",'" + usuario + "', '"+ data +"');", Conexao.con);
                insere.ExecuteNonQuery();
                resp = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("insert into produto_ggwp (nome, descricao, preco, quantidade, categoria, usuario, data) values ('" + nome + "','" + descricao + "'," + preco + "," + quant + "," + cat + ",'" + usuario + "', '" + data + "');");
            }
            finally
            {
                Conexao.con.Close();
            }
            return resp;
        }
    }
}
