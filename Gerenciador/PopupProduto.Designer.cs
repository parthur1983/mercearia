namespace MerceariaSantana
{
    partial class PopupProduto
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
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSenhaInvalida = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDescricao.Location = new System.Drawing.Point(21, 80);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(303, 23);
            this.txtDescricao.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(17, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Preço";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogin.Location = new System.Drawing.Point(75, 273);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(81, 34);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Salvar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(177, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtObservacao.Location = new System.Drawing.Point(21, 205);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(303, 50);
            this.txtObservacao.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(17, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Observação";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSenhaInvalida
            // 
            this.lblSenhaInvalida.AutoSize = true;
            this.lblSenhaInvalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaInvalida.ForeColor = System.Drawing.Color.Red;
            this.lblSenhaInvalida.Location = new System.Drawing.Point(65, 9);
            this.lblSenhaInvalida.Name = "lblSenhaInvalida";
            this.lblSenhaInvalida.Size = new System.Drawing.Size(0, 20);
            this.lblSenhaInvalida.TabIndex = 12;
            this.lblSenhaInvalida.Visible = false;
            // 
            // txtPreco
            // 
            this.txtPreco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPreco.Location = new System.Drawing.Point(21, 143);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(303, 23);
            this.txtPreco.TabIndex = 2;
            // 
            // PopupProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 319);
            this.Controls.Add(this.lblSenhaInvalida);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin);
            this.Name = "PopupProduto";
            this.Text = "Cadastro de Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSenhaInvalida;
        private System.Windows.Forms.TextBox txtPreco;
    }
}