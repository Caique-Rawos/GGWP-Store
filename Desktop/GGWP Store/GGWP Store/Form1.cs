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
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            erroLogin.Text = "";
            if(userTextBox.Text == "GGWP" && passTextBox.Text == "GGWP1234"){
                F_Inicio inicio = new F_Inicio();
                inicio.Show();
            }
            else
            {
                erroLogin.Text = "Usuário ou senha incorretos.";
            }
        }
    }
}
