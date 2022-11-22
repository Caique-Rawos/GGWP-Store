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

        public DataTable srcVendas()
        {
            DataTable tabela = new DataTable();
            try
            {
                Conexao.con.Close();
                Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM vendas_ggwp", Conexao.con);
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
    }
}
