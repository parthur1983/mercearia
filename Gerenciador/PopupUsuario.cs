using Nucleo.Infra;
using Nucleo.Modelo;
using Nucleo.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerceariaSantana
{
    public partial class PopupUsuario : Form
    {
        public static Usuario UsuarioSelecionado { get; set; }
        private readonly IUsuarioRepository _usuarioRepository = new UsuarioRepository();

        public PopupUsuario()
        {
            InitializeComponent();
            IniciaTela();
        }

        private void IniciaTela()
        {
            txtUsuario.Text = UsuarioSelecionado.Login;
            lblSenhaInvalida.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var usuarioSelecionado = UsuarioSelecionado;

            if ( SenhaAtualOk(usuarioSelecionado))
            {
                lblSenhaInvalida.Hide();

                usuarioSelecionado.Senha = Criptografia.ON(txtNovaSenha.Text);
                _usuarioRepository.Salvar(usuarioSelecionado);

                MessageBox.Show("Operação realizada com sucesso.");

                this.Close();
            }
            else
            {
                lblSenhaInvalida.Show();
            }


           
        }

        private bool SenhaAtualOk(Usuario usuario)
        {
             string senhaCriptografada = Criptografia.ON(txtSenha.Text);

             return senhaCriptografada == usuario.Senha;
        }
    }
}
