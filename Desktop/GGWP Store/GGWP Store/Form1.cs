using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            string tipo = Conexao.login(userTextBox.Text.ToUpper(), passTextBox.Text);

            if (tipo == "")
                MessageBox.Show("Usuário/Senha inválidos");
            else
            {
                Usuario u = new Usuario();

                u.setIdUser(userTextBox.Text);
                F_Inicio inicio = new F_Inicio();
                inicio.Show();
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void btnMax_Click_1(object sender, EventArgs e)
        {

        }

        private void passTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string tipo = Conexao.login(userTextBox.Text.ToUpper(), passTextBox.Text);

                if (tipo == "")
                    MessageBox.Show("Usuário/Senha inválidos");
                else
                {
                    Usuario u = new Usuario();

                    u.setIdUser(userTextBox.Text);
                    F_Inicio inicio = new F_Inicio();
                    inicio.Show();
                    this.Hide();
                }
            }
        }
    }
}
