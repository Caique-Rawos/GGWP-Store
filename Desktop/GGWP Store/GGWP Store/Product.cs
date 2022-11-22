using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

        public Product(int id, int qtd, double preco, string nome, string categoria, string desc)
        {
            this.id = id;
            this.qtd = qtd;
            this.preco = preco;
            this.nome = nome;
            this.categoria = categoria;
            this.desc = desc;
            /*this.endereco = endereco;
            this.user = user;*/
        }
        public Product(int id)
        {
            this.id = id;
        }
        public Product(string nome)
        {
            this.nome = nome;
        }
        public MySqlDataReader srcProductById(int id)
        {
            MySqlDataReader resultado = null;
            try
            {
                Conexao.con.Close();
                Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT id_produto, nome, descricao, preco, quantidade, CASE WHEN categoria = 1 THEN 'Colecionáveis' WHEN categoria = 2 THEN 'Games' WHEN categoria = 3 THEN 'Computadores' WHEN categoria = 4 THEN 'Periféricos' WHEN categoria = 5 THEN \"HQ's\" ELSE 'Sem Categoria' END as categoria, foto, foto_endereco, usuario, data FROM produto_ggwp WHERE id_produto = " + id + ";", Conexao.con);
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

        public DataTable srcProductByName(String name)
        {
            DataTable tabela = new DataTable();
            try
            {
                Conexao.con.Close();
                Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT id_produto, nome, descricao, preco, quantidade, CASE WHEN categoria = 1 THEN 'Colecionáveis' WHEN categoria = 2 THEN 'Games' WHEN categoria = 3 THEN 'Computadores' WHEN categoria = 4 THEN 'Periféricos' WHEN categoria = 5 THEN \"HQ's\" ELSE 'Sem Categoria' END as categoria FROM produto_ggwp WHERE nome like '%" + name + "%';", Conexao.con);
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                adaptador.SelectCommand = consulta;
                adaptador.Fill(tabela);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("SELECT id_produto, nome, descricao, preco, quantidade, CASE WHEN categoria = 1 THEN 'Colecionáveis' WHEN categoria = 2 THEN 'Games' WHEN categoria = 3 THEN 'Computadores' WHEN categoria = 4 THEN 'Periféricos' WHEN categoria = 5 THEN \"HQ's\" ELSE 'Sem Categoria' END as categoria FROM produto_ggwp WHERE nome like '%" + name + "%';");
            }
            finally
            {
                //Conexao.con.Close();
            }
            return tabela;
        }

        public void newProduct()
        {

            try
            {
                int cat = 0;

                if (categoria == "Colecionáveis")
                {
                    cat = 1;
                }
                else if (categoria == "Games")
                {
                    cat = 2;
                }
                else if (categoria == "Computadores")
                {
                    cat = 3;
                }
                else if (categoria == "Periféricos")
                {
                    cat = 4;
                }
                else if (categoria == "HQ's")
                {
                    cat = 5;
                }

                string dataAt = DateTime.Now.ToString("yyyy/MM/dd");

                Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into produto_ggwp (nome, descricao, preco, quantidade, categoria, data) values ('" + nome + "','" + desc + "'," + preco.ToString().Replace(',', '.') + "," + qtd + "," + cat + ", '"+ dataAt + "')", Conexao.con);
                insere.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Conexao.con.Close();
            }

        }
        
        public void att(int id)
        {
            this.id = id;
            try
            {

                int cat = 0;

                if (categoria == "Colecionáveis")
                {
                    cat = 1;
                }
                else if (categoria == "Games")
                {
                    cat = 2;
                }
                else if (categoria == "Computadores")
                {
                    cat = 3;
                }
                else if (categoria == "Periféricos")
                {
                    cat = 4;
                }
                else if (categoria == "HQ's")
                {
                    cat = 5;
                }

                string dataAt = DateTime.Now.ToString("yyyy/MM/dd");

                Conexao.con.Open();
                //MySqlCommand insere = new MySqlCommand("update produto_ggwp set WHERE id_produto = " + id + " (nome, descricao, preco, quantidade, categoria) values ('" + nome + "','" + desc + "'," + preco + "," + qtd + ",'" + categoria + "')", Conexao.con);
                MySqlCommand insere = new MySqlCommand("update produto_ggwp set nome = '" + nome + "', descricao = '" + desc + "', preco = " + preco.ToString().Replace(',', '.') + ", quantidade = " +qtd+ ", categoria = "+cat+", data = '"+ dataAt + "' where id_produto =" + id + ";", Conexao.con);
                insere.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Conexao.con.Close();
            }
        }
    }
}
