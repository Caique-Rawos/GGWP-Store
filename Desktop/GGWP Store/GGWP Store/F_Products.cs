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
    public partial class F_Products : Form
    {
        string caminho = Directory.GetCurrentDirectory();
        public F_Products()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSrc.Text != "")
            {
                try
                {
                    Product p = new Product(Int32.Parse(txtSrc.Text));
                    MySqlDataReader r = p.srcProduct(Int32.Parse(txtSrc.Text));
                    if (r != null)
                        if (r.Read())
                        {
                            txtId.Text = r["id_produto"].ToString();
                            txtNome.Text = r["nome"].ToString();
                            txtDesc.Text = r["descricao"].ToString();
                            txtPreco.Text = r["preco"].ToString();
                            txtQuant.Text = r["quantidade"].ToString();
                            txtCat.Text = r["categoria"].ToString();
                            txtUser.Text = r["usuario"].ToString();
                            txtData.Text = r["data"].ToString();
                        }
                    Conexao.con.Close();
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    MessageBox.Show("O campo de pesquisa precisa ser um numero!");
                }
            }

            /*string src = txtSrc.Text;
            StreamReader texto;

            listBox1.Items.Clear();

            if (System.IO.File.Exists(caminho + "\\" + src + ".txt"))
            {
                texto = new StreamReader(caminho + "\\" + src + ".txt");
                listBox1.Items.Add(texto.ReadLine());
                listBox1.Items.Add("R$ " + texto.ReadLine());
                listBox1.Items.Add("Quant: " + texto.ReadLine());
                listBox1.Items.Add(texto.ReadLine());
            }*/
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            F_NewProduct p = new F_NewProduct();
            p.Show();
        }
    }
}
