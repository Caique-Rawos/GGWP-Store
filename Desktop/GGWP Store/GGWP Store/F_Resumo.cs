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
    public partial class F_Resumo : Form
    {
        public F_Resumo()
        {
            InitializeComponent();
        }

        private void notaFiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["F_NotaFiscal"] == null)
            {
                F_NotaFiscal f_nota = new F_NotaFiscal();
                f_nota.Show();
            }
        }
    }
}
