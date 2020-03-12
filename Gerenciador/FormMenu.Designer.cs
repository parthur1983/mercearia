namespace MerceariaSantana
{
    partial class FormMenu
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
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlAcoes = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnPrecos = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.panelCabecalho.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlAcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.Orange;
            this.panelCabecalho.Controls.Add(this.label1);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(1001, 41);
            this.panelCabecalho.TabIndex = 0;
            this.panelCabecalho.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCabecalho_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(717, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerenciador - Mercearia SANTANA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.pnlMenu.Controls.Add(this.button3);
            this.pnlMenu.Controls.Add(this.pnlAcoes);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 41);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(167, 598);
            this.pnlMenu.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(12, 546);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "SAIR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnlAcoes
            // 
            this.pnlAcoes.Controls.Add(this.btnUsuarios);
            this.pnlAcoes.Controls.Add(this.btnProdutos);
            this.pnlAcoes.Controls.Add(this.btnVendas);
            this.pnlAcoes.Controls.Add(this.btnPrecos);
            this.pnlAcoes.Controls.Add(this.btnBackup);
            this.pnlAcoes.Location = new System.Drawing.Point(3, 18);
            this.pnlAcoes.Name = "pnlAcoes";
            this.pnlAcoes.Size = new System.Drawing.Size(158, 522);
            this.pnlAcoes.TabIndex = 6;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(9, 174);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(135, 40);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "USUÁRIOS";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btnProdutos.ForeColor = System.Drawing.Color.White;
            this.btnProdutos.Location = new System.Drawing.Point(9, 3);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(135, 40);
            this.btnProdutos.TabIndex = 0;
            this.btnProdutos.Text = "PRODUTOS";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVendas.FlatAppearance.BorderSize = 0;
            this.btnVendas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnVendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btnVendas.ForeColor = System.Drawing.Color.White;
            this.btnVendas.Location = new System.Drawing.Point(9, 46);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(135, 40);
            this.btnVendas.TabIndex = 1;
            this.btnVendas.Text = "VENDAS";
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPrecos
            // 
            this.btnPrecos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrecos.FlatAppearance.BorderSize = 0;
            this.btnPrecos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPrecos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnPrecos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrecos.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrecos.ForeColor = System.Drawing.Color.White;
            this.btnPrecos.Location = new System.Drawing.Point(3, 92);
            this.btnPrecos.Name = "btnPrecos";
            this.btnPrecos.Size = new System.Drawing.Size(152, 30);
            this.btnPrecos.TabIndex = 2;
            this.btnPrecos.Text = "RELAT. PREÇOS";
            this.btnPrecos.UseVisualStyleBackColor = true;
            this.btnPrecos.Click += new System.EventHandler(this.btnPrecos_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Location = new System.Drawing.Point(9, 128);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(135, 40);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "BACKUP";
            this.btnBackup.UseVisualStyleBackColor = true;
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.BackColor = System.Drawing.Color.White;
            this.pnlConteudo.BackgroundImage = global::MerceariaSantana.Properties.Resources.images;
            this.pnlConteudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlConteudo.Location = new System.Drawing.Point(167, 41);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlConteudo.Size = new System.Drawing.Size(834, 598);
            this.pnlConteudo.TabIndex = 2;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 639);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador - Mercearia SANTANA";
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlAcoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.Button btnPrecos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel pnlAcoes;
    }
}

