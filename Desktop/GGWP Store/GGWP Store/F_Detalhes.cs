using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGWP_Store
{
    public partial class F_Detalhes : Form
    {
        public F_Detalhes(int id2)
        {
            InitializeComponent();
            Vendas v = new Vendas(id2);

            MySqlDataReader p = v.UsuarioId();
            if(p != null)
                if(p.Read())
                {
                    lblUsuario.Text = p["username"].ToString();
                    lblTotal.Text = p["total"].ToString();
                    lblFrete.Text = p["frete"].ToString();
                    lblItens.Text = p["itens"].ToString();
                }
            Conexao.con.Close();

            dgv.DataSource = v.srcDataTableItens();
            Conexao.con.Close();

        }

        private void F_Detalhes_Load(object sender, EventArgs e)
        {

        }
    }
}
