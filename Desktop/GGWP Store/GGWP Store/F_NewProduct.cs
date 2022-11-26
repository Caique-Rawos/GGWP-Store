using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGWP_Store
{
    public partial class F_NewProduct : Form
    {
        int id = 0;
        int op = 0;
        string caminho = Directory.GetCurrentDirectory();
        public F_NewProduct()
        {
            InitializeComponent();
            this.Text = "Cadastrar produto";
            lblFunc.Text = "Cadastrar produto";
            op = 0;
        }
        public F_NewProduct(int id)
        {
            InitializeComponent();
            this.Text = "Atualizar produto";
            this.id = id;
            lblFunc.Text = "Atualizar produto";
            Product p = new Product(id);
            MySqlDataReader r = p.srcProductById(id);
            if (r.Read())
            {
                //textBox1.Text = r["id"].ToString();
                txtName.Text = r["nome"].ToString();
                txtDesc.Text = r["descricao"].ToString();
                txtValue.Text = r["preco"].ToString();
                txtQtd.Text = r["quantidade"].ToString();
                cmbCat.Text = r["categoria"].ToString();
                //txtUser.Text = r["user"].ToString();
            }
            Conexao.con.Close();
            op = 1;
        }
        private void clearAll()
        {
            txtName.Text = "";
            txtValue.Text = "";
            txtQtd.Text = "";
            txtDesc.Text = "";
            txtSucess.Text = "";
            cmbCat.Text = "";
            erroNome.Text = "";
            erroValor.Text = "";
            erroQtd.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {            
            if (txtName.Text == "" || txtQtd.Text == "" || txtValue.Text == "" || cmbCat.Text == "")
            {
                MessageBox.Show("PREENCHA OS CAMPOS NECESSÁRIOS");
            }
            else
            {
                Product p = new Product(id, Convert.ToInt32(txtQtd.Text), Convert.ToDouble(txtValue.Text), txtName.Text, cmbCat.Text, txtDesc.Text);
                if (op == 0){
                    p.newProduct();
                    txtSucess.Text = "Produto cadastrado";
                }
                else
                {
                    p.att(id);
                    txtSucess.Text = "Produto atualizado";
                }
            }
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void F_NewProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
