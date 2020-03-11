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
    public partial class FormUsuario : Form
    {
        private readonly IUsuarioRepository _usuarioRepository = new UsuarioRepository();
        public FormUsuario()
        {
            InitializeComponent();
            dgUsuarios.DataSource = _usuarioRepository.ObterTodos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
