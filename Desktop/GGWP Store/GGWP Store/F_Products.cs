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
            string src = txtSrc.Text;
            StreamReader texto;

            listBox1.Items.Clear();

            if (System.IO.File.Exists(caminho + "\\" + src + ".txt"))
            {
                texto = new StreamReader(caminho + "\\" + src + ".txt");
                listBox1.Items.Add(texto.ReadLine());
                listBox1.Items.Add("R$ " + texto.ReadLine());
                listBox1.Items.Add("Quant: " + texto.ReadLine());
                listBox1.Items.Add(texto.ReadLine());
            }
        }
    }
}
