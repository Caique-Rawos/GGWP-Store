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
            foreach (Control c in this.Controls)
                if (c is MdiClient)
                    c.BackColor = Color.FromArgb(25,25,25);
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*if (Application.OpenForms["F_Vendas"] == null)
            {
                F_Vendas vendas = new F_Vendas();
                vendas.Show();
            }*/
            if (Application.OpenForms.OfType<F_Vendas>().Count() == 0)
            {
                F_Vendas vendas = new F_Vendas();
                vendas.MdiParent = this;
                vendas.Show();
            }
        }
    

        private void perfilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<F_UserProfile>().Count() == 0)
            {
                F_UserProfile perfil = new F_UserProfile();
                perfil.MdiParent = this;
                perfil.Show();
            }
        }

        private void informaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<F_UserInfo>().Count() == 0)
            {
                F_UserInfo info = new F_UserInfo();
                info.MdiParent = this;
                info.Show();
            }
        }

        private void chatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<F_Chat>().Count() <= 10)
            {
                F_Chat chat = new F_Chat();
                chat.MdiParent = this;
                chat.Show();
            }
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<F_Products>().Count() == 0)
            {
                F_Products products = new F_Products();
                products.MdiParent = this;
                products.Show();
            }
        }

        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<F_NewProduct>().Count() == 0)
            {
                F_NewProduct newProduct = new F_NewProduct();
                newProduct.MdiParent = this;
                newProduct.Show();
            }
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<F_Help>().Count() == 0)
            {
                F_Help help = new F_Help();
                help.MdiParent = this;
                help.Show();
            }
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<F_Config>().Count() == 0)
            {
                F_Config config = new F_Config();
                config.Show();
            }
        }
    }
}
