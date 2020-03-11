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

            if (txtUsuario.Text.ToUpper() == Usuario.Tipo.ADM.ToString()
                    && UsuarioESenhaEstaOK())
            {
                lblSenhaInvalida.Hide();
                this.Close();
            }
            else
            {
                lblSenhaInvalida.Show();
            }

        }

        private bool UsuarioESenhaEstaOK()
        {
            List<Usuario> listaUsuario = _usuarioRepository.ObterTodos();

            string senhaCriptografada = Criptografia.ON(txtSenha.Text);

            return listaUsuario.Where(x => x.Login.ToUpper() == txtUsuario.Text.ToUpper()
                                    && x.Senha == senhaCriptografada).ToList().Count > 0;
        }

    }
}
