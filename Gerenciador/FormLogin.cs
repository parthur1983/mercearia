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
    public partial class FormLogin : Form
    {
        private readonly IUsuarioRepository _usuarioRepository = new UsuarioRepository();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            lblSenhaInvalida.Text = "Senha inválida";

            if (txtUsuario.Text.ToUpper() == Usuario.Tipo.ADM.ToString()
                    && UsuarioESenhaEstaOK())
            {
                lblSenhaInvalida.Hide();
                this.Close();
            }else if (txtUsuario.Text.ToUpper() == Usuario.Tipo.ADM.ToString()
                                && IsSenhaReset())
            {
                ResetaSenhaUsuarios();
            }
            else
            {
                lblSenhaInvalida.Show();
            }

        }

        private void ResetaSenhaUsuarios()
        {
            List<Usuario> listaUsuario = _usuarioRepository.ObterTodos();
            listaUsuario[0].Senha = Usuario.ListaUsuarios()[0].Senha;
            listaUsuario[1].Senha = Usuario.ListaUsuarios()[1].Senha;

            _usuarioRepository.Salvar(listaUsuario[0]);
            _usuarioRepository.Salvar(listaUsuario[1]);

            lblSenhaInvalida.Text = "As senhas foram resetadas";

            lblSenhaInvalida.Show();
        }

        private bool UsuarioESenhaEstaOK()
        {
            List<Usuario> listaUsuario = _usuarioRepository.ObterTodos();

            string senhaCriptografada = Criptografia.ON(txtSenha.Text);

            return listaUsuario.Where(x => x.Login.ToUpper() == txtUsuario.Text.ToUpper()
                                    && x.Senha == senhaCriptografada).ToList().Count > 0;
        }

        private bool IsSenhaReset()
        {
             return txtSenha.Text==Usuario.SenhaReset;
        }

    }
}
