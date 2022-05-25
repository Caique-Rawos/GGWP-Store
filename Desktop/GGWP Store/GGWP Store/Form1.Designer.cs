
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
            this.loginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.createAccLink = new System.Windows.Forms.LinkLabel();
            this.fogotPassLink = new System.Windows.Forms.LinkLabel();
            this.keepConnectCheckBox = new System.Windows.Forms.CheckBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 421);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.loginButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.createAccLink);
            this.panel2.Controls.Add(this.fogotPassLink);
            this.panel2.Controls.Add(this.keepConnectCheckBox);
            this.panel2.Controls.Add(this.passTextBox);
            this.panel2.Controls.Add(this.userTextBox);
            this.panel2.Location = new System.Drawing.Point(31, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 365);
            this.panel2.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(103, 243);
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
            this.label1.Location = new System.Drawing.Point(79, 318);
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
            this.createAccLink.Location = new System.Drawing.Point(233, 318);
            this.createAccLink.Name = "createAccLink";
            this.createAccLink.Size = new System.Drawing.Size(69, 17);
            this.createAccLink.TabIndex = 4;
            this.createAccLink.TabStop = true;
            this.createAccLink.Text = "Criar uma";
            // 
            // fogotPassLink
            // 
            this.fogotPassLink.ActiveLinkColor = System.Drawing.Color.White;
            this.fogotPassLink.AutoSize = true;
            this.fogotPassLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fogotPassLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.fogotPassLink.Location = new System.Drawing.Point(218, 185);
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
            this.keepConnectCheckBox.Location = new System.Drawing.Point(51, 184);
            this.keepConnectCheckBox.Name = "keepConnectCheckBox";
            this.keepConnectCheckBox.Size = new System.Drawing.Size(153, 21);
            this.keepConnectCheckBox.TabIndex = 2;
            this.keepConnectCheckBox.Text = "Mater-se conectado";
            this.keepConnectCheckBox.UseVisualStyleBackColor = true;
            // 
            // passTextBox
            // 
            this.passTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.passTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.passTextBox.ForeColor = System.Drawing.Color.White;
            this.passTextBox.Location = new System.Drawing.Point(42, 112);
            this.passTextBox.MaxLength = 50;
            this.passTextBox.Multiline = true;
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(310, 41);
            this.passTextBox.TabIndex = 1;
            // 
            // userTextBox
            // 
            this.userTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.userTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.userTextBox.ForeColor = System.Drawing.Color.White;
            this.userTextBox.Location = new System.Drawing.Point(42, 39);
            this.userTextBox.MaxLength = 50;
            this.userTextBox.Multiline = true;
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(310, 41);
            this.userTextBox.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    }
}

