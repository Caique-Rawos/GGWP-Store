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
    public partial class F_Inicio : Form
    {
        public int a = 0, qjv = 0;
        public F_Inicio()
        {
            InitializeComponent();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Vendas vendas = new F_Vendas();
            vendas.Show();
        }

        private void perfilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_UserProfile profile = new F_UserProfile();
            profile.Show();
        }

        private void comunidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Community community = new F_Community();
            community.Show();
        }

        private void informaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_UserInfo userInfo = new F_UserInfo();
            userInfo.Show();
        }

        private void chatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Chat chat = new F_Chat();
            chat.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_Products products = new F_Products();
            products.Show();
        }

        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NewProduct newProduct = new F_NewProduct();
            newProduct.Show();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Help help = new F_Help();
            help.Show();
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["F_Config"] == null)
                {
                    F_Config config = new F_Config();
                    config.Show();
                }
                else
                {
                    MessageBox.Show("Você só pode abrir uma janela Config ao mesmo tempo.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {}
        }
    }
}
