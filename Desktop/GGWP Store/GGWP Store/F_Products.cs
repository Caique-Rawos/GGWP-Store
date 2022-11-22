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
            /*Product p = new Product(Int32.Parse(txtSrc.Text));
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
            Conexao.con.Close();*/

            Product pr = new Product(txtSrc.Text);
            dgv.DataSource = pr.srcProductByName(txtSrc.Text);
            Conexao.con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            F_NewProduct p = new F_NewProduct();
            p.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(dgv.Rows[dgv.CurrentCell.RowIndex].Cells[0].Value);
                F_NewProduct p = new F_NewProduct(id);
                p.Show();
            }
            catch (NullReferenceException ex2)
            {
                Console.WriteLine(ex2.ToString());
                MessageBox.Show("Selecione um produto da lista");
            }
            catch (Exception ex){
                Console.WriteLine(ex.ToString());
            }
            
        }

        private void F_Products_Load(object sender, EventArgs e)
        {

        }
    }
}
