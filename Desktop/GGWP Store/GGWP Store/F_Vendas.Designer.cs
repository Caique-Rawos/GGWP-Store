﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Vendas));
            this.btnSrc = new System.Windows.Forms.Button();
            this.txtSrc = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnMaisDetalhes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSrc
            // 
            this.btnSrc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSrc.BackColor = System.Drawing.Color.Transparent;
            this.btnSrc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSrc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSrc.ForeColor = System.Drawing.Color.White;
            this.btnSrc.Location = new System.Drawing.Point(763, 12);
            this.btnSrc.Name = "btnSrc";
            this.btnSrc.Size = new System.Drawing.Size(116, 38);
            this.btnSrc.TabIndex = 8;
            this.btnSrc.Text = "Pesquisar";
            this.btnSrc.UseVisualStyleBackColor = false;
            this.btnSrc.Click += new System.EventHandler(this.btnSrc_Click);
            // 
            // txtSrc
            // 
            this.txtSrc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSrc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtSrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtSrc.ForeColor = System.Drawing.Color.White;
            this.txtSrc.Location = new System.Drawing.Point(227, 12);
            this.txtSrc.MaxLength = 11;
            this.txtSrc.Multiline = true;
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.Size = new System.Drawing.Size(530, 39);
            this.txtSrc.TabIndex = 7;
            this.txtSrc.Text = "Codigo da venda";
            this.txtSrc.TextChanged += new System.EventHandler(this.txtSrc_TextChanged);
            this.txtSrc.Enter += new System.EventHandler(this.txtSrc_Enter);
            this.txtSrc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSrc_KeyPress);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Location = new System.Drawing.Point(106, 68);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1108, 622);
            this.dgv.TabIndex = 9;
            // 
            // btnMaisDetalhes
            // 
            this.btnMaisDetalhes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMaisDetalhes.BackColor = System.Drawing.Color.Transparent;
            this.btnMaisDetalhes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMaisDetalhes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaisDetalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaisDetalhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnMaisDetalhes.ForeColor = System.Drawing.Color.White;
            this.btnMaisDetalhes.Location = new System.Drawing.Point(885, 12);
            this.btnMaisDetalhes.Name = "btnMaisDetalhes";
            this.btnMaisDetalhes.Size = new System.Drawing.Size(116, 38);
            this.btnMaisDetalhes.TabIndex = 10;
            this.btnMaisDetalhes.Text = "Detalhes";
            this.btnMaisDetalhes.UseVisualStyleBackColor = false;
            this.btnMaisDetalhes.Click += new System.EventHandler(this.btnMaisDetalhes_Click);
            // 
            // F_Vendas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1400, 742);
            this.Controls.Add(this.btnMaisDetalhes);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnSrc);
            this.Controls.Add(this.txtSrc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSrc;
        private System.Windows.Forms.TextBox txtSrc;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnMaisDetalhes;
    }
}