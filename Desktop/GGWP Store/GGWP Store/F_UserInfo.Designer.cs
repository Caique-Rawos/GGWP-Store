
namespace GGWP_Store
{
    partial class F_UserInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_UserInfo));
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(218, 32);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 5, 50, 5);
            this.label2.Size = new System.Drawing.Size(297, 54);
            this.label2.TabIndex = 7;
            this.label2.Text = "GGWP Store";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::GGWP_Store.Properties.Resources.Star_18;
            this.panel2.Location = new System.Drawing.Point(230, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 44);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 224);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 5, 50, 5);
            this.label1.Size = new System.Drawing.Size(588, 170);
            this.label1.TabIndex = 5;
            this.label1.Text = "Informações de usuário\r\nCNPJ/CPF: 143.242.341-09\r\nE-mail Login: gerencia@ggwpstor" +
    "e.com\r\nTelefone: (+1)(425) 555-0100\r\nE-mail Suporte: suporte@ggwpstore.com";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GGWP_Store.Properties.Resources.Ellipse_20;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 200);
            this.panel1.TabIndex = 4;
            // 
            // F_UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(611, 406);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_UserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações de Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}