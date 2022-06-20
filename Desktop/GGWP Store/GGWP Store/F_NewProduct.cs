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

        string caminho = Directory.GetCurrentDirectory();

        public F_NewProduct()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtSucess.Text = "";
            StreamWriter arquivo;
            if(txtName.Text != ""){
                String name = txtName.Text;
                erroNome.Text = "";
                double valor = 0;
                try{
                    valor = double.Parse(txtValue.Text);
                }catch (Exception){
                    erroValor.Text = "Digite um valor possitivo!";
                }
                    if(valor > 0){
                        double Value = double.Parse(txtValue.Text);
                        erroValor.Text = "";
                        int quant = 0;
                        try{
                            quant = int.Parse(txtQtd.Text);
                        }catch (Exception){
                            erroQtd.Text = "Digite um valor maior que zero!";
                        }
                        if(quant > 0){
                            erroQtd.Text = "";
                            String nome_arq = txtName.Text;
                            if (System.IO.File.Exists(caminho + "\\" + nome_arq + ".txt"))
                            File.Delete(caminho + "\\" + nome_arq + ".txt");
                            arquivo = new StreamWriter(caminho + "\\" + nome_arq + ".txt");
                            arquivo.WriteLine(txtName.Text);
                            arquivo.WriteLine(valor);
                            arquivo.WriteLine(quant);
                            arquivo.WriteLine(txtDesc.Text);
                            arquivo.Close();

                            txtName.Text = "";
                            txtValue.Text = "";
                            txtQtd.Text = "";
                            txtDesc.Text = "";
                            txtSucess.Text = "Produto cadastrado com sucesso.";
                        }else
                        erroQtd.Text = "Digite um valor maior que zero!";
                    }else
                    erroValor.Text = "Digite um valor possitivo!";
            }else
                erroNome.Text = "Digite o nome do produto";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtValue.Text = "";
            txtQtd.Text = "";
            txtDesc.Text = "";
            txtSucess.Text = "";
            erroNome.Text = "";
            erroValor.Text = "";
            erroQtd.Text = "";
        }
    }
}
