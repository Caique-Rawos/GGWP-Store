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

    public partial class F_Inicio : Form
    {
        private Form currentChildForm;

        public int a = 0, qjv = 0;
        public F_Inicio()
        {
            InitializeComponent();
            foreach (Control c in this.Controls)
                if (c is MdiClient)
                    c.BackColor = Color.FromArgb(25,25,25);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitleChildForm.Text = childForm.Text;
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*if (Application.OpenForms["F_Vendas"] == null)
            {
                F_Vendas vendas = new F_Vendas();
                vendas.Show();
            }*/
            OpenChildForm(new F_Vendas());
        }
    

        private void perfilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_UserProfile());
        }

        private void informaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_UserInfo());
        }

        private void chatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_Chat());
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_Products());
        }

        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenChildForm(new F_NewProduct());
        
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_Help());
        }

        private void F_Inicio_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        { 
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void bntMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_Vendas());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_UserProfile());
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

        private void iconButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_Products());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_Config());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_Help());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_Config());
           
        }
    }
}
