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
            if (txtSrc.Text == "Codigo da venda" || txtSrc.Text == "")
            {
                Vendas v = new Vendas(0);
                dgv.DataSource = v.srcVendas();
            }else
            {
                Vendas v2 = new Vendas(int.Parse(txtSrc.Text));
                dgv.DataSource = v2.srcVendas2(); 
            }
            Conexao.con.Close();

        }

        private void btnMaisDetalhes_Click(object sender, EventArgs e)
        {
            try
            {
                //int teste = Int32.TryParse(dgv.Rows[dgv.CurrentCell.RowIndex].Cells[0].Value);
                int id = Convert.ToInt32(dgv.Rows[dgv.CurrentCell.RowIndex].Cells[0].Value);
                F_Detalhes d = new F_Detalhes(id);
                d.Show();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Selecione alguma venda!");
                Console.WriteLine(ex.ToString());
            }

            catch (Exception ex2)
            {
                Console.WriteLine(ex2.ToString());
            }
        }

        private void txtSrc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSrc_Enter(object sender, EventArgs e)
        {
            if(txtSrc.Text == "Codigo da venda")
            {
                txtSrc.Text = "";
            }
        }

        private void txtSrc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
