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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            if (Conexao.getConexao("143.106.241.3", "cl201456", "cl201456", "cl*06112004"))
                Console.WriteLine("Conectado");
            else
                Console.WriteLine("Erro de conexão");

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            int tipo = Conexao.login(userTextBox.Text.ToUpper(), passTextBox.Text);

            if (tipo == 0)
            {
                MessageBox.Show("Usuário/Senha inválidos");
            }else
            {
                F_Inicio inicio = new F_Inicio();
                inicio.Show();

            }

          
            
            /*erroLogin.Text = "";
            if(userTextBox.Text == "GGWP" && passTextBox.Text == "GGWP1234"){
                F_Inicio inicio = new F_Inicio();
                inicio.Show();
            }
            else
            {
                erroLogin.Text = "Usuário ou senha incorretos.";
            }*/
        }

    }
}
