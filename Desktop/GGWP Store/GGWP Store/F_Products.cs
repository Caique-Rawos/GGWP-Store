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
            Product p = new Product(Int32.Parse(txtSrc.Text));
            MySqlDataReader r = p.srcProduct(Int32.Parse(txtSrc.Text));
            if (r.Read())
            {
                textBox1.Text = r["id"].ToString();
                textBox2.Text = r["nome"].ToString();
                textBox3.Text = r["desc"].ToString();
                textBox4.Text = r["preco"].ToString();
                textBox5.Text = r["qtd"].ToString();
                textBox6.Text = r["categoria"].ToString();
                textBox7.Text = r["user"].ToString();
            }
            Conexao.con.Close();

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
