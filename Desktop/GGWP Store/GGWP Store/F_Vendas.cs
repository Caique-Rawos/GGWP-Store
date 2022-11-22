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

        private void btnSrc_Click(object sender, EventArgs e)
        {
                Vendas v = new Vendas();
            dgv.DataSource = v.srcVendas();
            v.srcVendas();
        }
    }
}
