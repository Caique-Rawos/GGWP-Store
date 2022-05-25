
namespace GGWP_Store
{
    partial class F_Vendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Vendas));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_filter = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(92, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 708);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.lb_filter);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.checkBox4);
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.checkBox3);
            this.panel3.Location = new System.Drawing.Point(92, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(653, 87);
            this.panel3.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 3);
            this.textBox1.MaximumSize = new System.Drawing.Size(653, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(653, 32);
            this.textBox1.TabIndex = 2;
            // 
            // lb_filter
            // 
            this.lb_filter.AutoSize = true;
            this.lb_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lb_filter.ForeColor = System.Drawing.Color.White;
            this.lb_filter.Location = new System.Drawing.Point(53, 47);
            this.lb_filter.Name = "lb_filter";
            this.lb_filter.Size = new System.Drawing.Size(94, 24);
            this.lb_filter.TabIndex = 4;
            this.lb_filter.Text = "Filtrar por:";
            this.lb_filter.Click += new System.EventHandler(this.lb_filter_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(176, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(44, 28);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "id";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.checkBox4.ForeColor = System.Drawing.Color.White;
            this.checkBox4.Location = new System.Drawing.Point(549, 47);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(64, 28);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Text = "data";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(290, 47);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 28);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "nome";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.checkBox3.ForeColor = System.Drawing.Color.White;
            this.checkBox3.Location = new System.Drawing.Point(416, 47);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(78, 28);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "preço";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // F_Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(825, 824);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Vendas";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_filter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}