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
    public partial class F_Vendas : Form
    {
        public F_Vendas()
        {
            InitializeComponent();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            /*if (Application.OpenForms["F_Resumo"] == null)
            {
                F_Resumo f_resumo = new F_Resumo();
                f_resumo.Show();
            }*/

            if (Application.OpenForms.OfType<F_Resumo>().Count() == 0)
            {
                F_Resumo vendaLink = new F_Resumo();
                vendaLink.Show();
            }
        }
    }
}
