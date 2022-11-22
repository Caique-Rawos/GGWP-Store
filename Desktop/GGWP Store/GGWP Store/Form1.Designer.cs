
namespace GGWP_Store
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.createAccLink = new System.Windows.Forms.LinkLabel();
            this.fogotPassLink = new System.Windows.Forms.LinkLabel();
            this.keepConnectCheckBox = new System.Windows.Forms.CheckBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bntMin = new FontAwesome.Sharp.IconButton();
            this.btnMax = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 394);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.loginButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.createAccLink);
            this.panel2.Controls.Add(this.fogotPassLink);
            this.panel2.Controls.Add(this.keepConnectCheckBox);
            this.panel2.Controls.Add(this.passTextBox);
            this.panel2.Controls.Add(this.userTextBox);
            this.panel2.Location = new System.Drawing.Point(20, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 347);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(28, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(28, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(93, 231);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(179, 39);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Não possui uma conta?";
            // 
            // createAccLink
            // 
            this.createAccLink.ActiveLinkColor = System.Drawing.Color.White;
            this.createAccLink.AutoSize = true;
            this.createAccLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.createAccLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.createAccLink.Location = new System.Drawing.Point(223, 289);
            this.createAccLink.Name = "createAccLink";
            this.createAccLink.Size = new System.Drawing.Size(69, 17);
            this.createAccLink.TabIndex = 4;
            this.createAccLink.TabStop = true;
            this.createAccLink.Text = "Criar uma";
            this.createAccLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            // 
            // fogotPassLink
            // 
            this.fogotPassLink.ActiveLinkColor = System.Drawing.Color.White;
            this.fogotPassLink.AutoSize = true;
            this.fogotPassLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fogotPassLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.fogotPassLink.Location = new System.Drawing.Point(208, 192);
            this.fogotPassLink.Name = "fogotPassLink";
            this.fogotPassLink.Size = new System.Drawing.Size(134, 17);
            this.fogotPassLink.TabIndex = 3;
            this.fogotPassLink.TabStop = true;
            this.fogotPassLink.Text = "Esqueceu a senha?";
            // 
            // keepConnectCheckBox
            // 
            this.keepConnectCheckBox.AutoSize = true;
            this.keepConnectCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.keepConnectCheckBox.ForeColor = System.Drawing.Color.White;
            this.keepConnectCheckBox.Location = new System.Drawing.Point(41, 191);
            this.keepConnectCheckBox.Name = "keepConnectCheckBox";
            this.keepConnectCheckBox.Size = new System.Drawing.Size(153, 21);
            this.keepConnectCheckBox.TabIndex = 2;
            this.keepConnectCheckBox.Text = "Mater-se conectado";
            this.keepConnectCheckBox.UseVisualStyleBackColor = true;
            // 
            // passTextBox
            // 
            this.passTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.passTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.passTextBox.ForeColor = System.Drawing.Color.White;
            this.passTextBox.Location = new System.Drawing.Point(32, 132);
            this.passTextBox.MaxLength = 50;
            this.passTextBox.Multiline = true;
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(310, 32);
            this.passTextBox.TabIndex = 1;
            this.passTextBox.Text = "teste123";
            this.passTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passTextBox_KeyPress);
            // 
            // userTextBox
            // 
            this.userTextBox.AccessibleDescription = "Email";
            this.userTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.userTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.userTextBox.ForeColor = System.Drawing.Color.White;
            this.userTextBox.Location = new System.Drawing.Point(32, 58);
            this.userTextBox.MaxLength = 50;
            this.userTextBox.Multiline = true;
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(310, 32);
            this.userTextBox.TabIndex = 0;
            this.userTextBox.Text = "caique.rawos@gmail.com";
            this.userTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.bntMin);
            this.panel3.Controls.Add(this.btnMax);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(417, 35);
            this.panel3.TabIndex = 1;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // bntMin
            // 
            this.bntMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntMin.BackColor = System.Drawing.Color.Transparent;
            this.bntMin.FlatAppearance.BorderSize = 0;
            this.bntMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntMin.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.bntMin.IconColor = System.Drawing.Color.White;
            this.bntMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntMin.IconSize = 25;
            this.bntMin.Location = new System.Drawing.Point(301, 2);
            this.bntMin.Name = "bntMin";
            this.bntMin.Size = new System.Drawing.Size(34, 48);
            this.bntMin.TabIndex = 7;
            this.bntMin.UseVisualStyleBackColor = false;
            this.bntMin.Click += new System.EventHandler(this.bntMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMax.Enabled = false;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMax.IconChar = FontAwesome.Sharp.IconChar.SquareFull;
            this.btnMax.IconColor = System.Drawing.Color.White;
            this.btnMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMax.IconSize = 25;
            this.btnMax.Location = new System.Drawing.Point(341, 3);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(34, 34);
            this.btnMax.TabIndex = 6;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 25;
            this.btnExit.Location = new System.Drawing.Point(381, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 45);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(417, 424);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel createAccLink;
        private System.Windows.Forms.LinkLabel fogotPassLink;
        private System.Windows.Forms.CheckBox keepConnectCheckBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton bntMin;
        private FontAwesome.Sharp.IconButton btnMax;
    }
}

