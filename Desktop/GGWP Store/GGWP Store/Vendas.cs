using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGWP_Store
{
    class Vendas
    {
        private int idVendas;
        private double total_prod;
        private double frete;
        private double total;
        private string comprador;

        public int IdVendas { get => idVendas; set => idVendas = value; }
        public double Total_prod { get => total_prod; set => total_prod = value; }
        public double Frete { get => frete; set => frete = value; }
        public double Total { get => total; set => total = value; }
        public string Comprador { get => comprador; set => comprador = value; }

        public Vendas(int id)
        {
            this.idVendas = id;
        }
        public DataTable srcVendas()
        {
            DataTable tabela = new DataTable();
            try
            {
                Conexao.con.Close();
                Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT v.idVendas as Codigo, v.total_prod as 'Total Prod', v.frete as Frete, v.total as Total, u.username as Comprador, v.data as Data FROM vendas_ggwp v left join usuario_ggwp u on u.email = v.comprador order by v.idVendas;", Conexao.con);
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                adaptador.SelectCommand = consulta;
                adaptador.Fill(tabela);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                //Conexao.con.Close();
            }
            return tabela;
        }

        public DataTable srcVendas2()
        {
            DataTable tabela = new DataTable();
            try
            {
                Conexao.con.Close();
                Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT v.idVendas as Codigo, v.total_prod as 'Total Prod', v.frete as Frete, v.total as Total, u.username as Comprador, v.data as Data FROM vendas_ggwp v left join usuario_ggwp u on u.email = v.comprador where v.idVendas = "+ idVendas + " order by v.idVendas;", Conexao.con);
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                adaptador.SelectCommand = consulta;
                adaptador.Fill(tabela);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("SELECT v.idVendas as Codigo, v.total_prod as 'Total Prod', v.frete as Frete, v.total as Total, u.username as Comprador, v.data as Data FROM vendas_ggwp v left join usuario_ggwp u on u.email = v.comprador where v.idVendas = " + idVendas + " ;");
            }
            finally
            {
                //Conexao.con.Close();
            }
            return tabela;
        }
        public MySqlDataReader ItemsId()
        {
            MySqlDataReader resultado = null;
            try
            {
                Conexao.con.Close();
                Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select p.nome, p.descricao, v.preco_un, v.qntd from vendas_itens_ggwp v left join produto_ggwp p on p.id_produto = v.id_produto where v.id_venda = "+ idVendas +"; ", Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
          
            return resultado;
        }

        public DataTable srcDataTableItens()
        {
            DataTable tabela = new DataTable();
            try
            {
                Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select p.nome as Produto, p.descricao as Descricao, v.preco_un as 'Valor Unitario', v.qntd as Quantidade from vendas_itens_ggwp v left join produto_ggwp p on p.id_produto = v.id_produto where v.id_venda = " + idVendas + ";", Conexao.con);
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                adaptador.SelectCommand = consulta;
                adaptador.Fill(tabela);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("select p.nome as Produto, p.descricao as Descricao, v.preco_un as 'Valor Unitario', v.qntd as Quantidade from vendas_itens_ggwp v left join produto_ggwp p on p.id_produto = v.id_produto where v.id_venda = " + idVendas + ";");
            }
            finally
            {
                //Conexao.con.Close();
            }
            return tabela;
        }

        public MySqlDataReader UsuarioId()
        {
            MySqlDataReader resultado = null;
            try
            {
                Conexao.con.Close();
                Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select u.username, total_prod as itens, frete, total from vendas_ggwp v left join usuario_ggwp u on u.email = v.comprador where v.idVendas = " + idVendas + "; ", Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return resultado;
        }

    }
}
