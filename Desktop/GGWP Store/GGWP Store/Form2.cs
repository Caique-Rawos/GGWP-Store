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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 vendas = new Form3();
            vendas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 perfil = new Form4();
            perfil.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 produtos = new Form5();
            produtos.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 produtos = new Form6();
            produtos.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 produtos = new Form7();
            produtos.Show();
        }
    }
}
