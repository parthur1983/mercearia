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
    public partial class FormUsuario : Form
    {
        private readonly IUsuarioRepository _usuarioRepository = new UsuarioRepository();
        public FormUsuario()
        {
            InitializeComponent();
            dgUsuarios.DataSource = _usuarioRepository.ObterTodos();
            dgUsuarios.Columns[2].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.SelectedRows.Count == 0)
            {
               MessageBox.Show("Selecione uma linha");
            }
            else
            {
                Usuario usuarioSelecionado = dgUsuarios.SelectedRows[0].DataBoundItem as Usuario;

                PopupUsuario.UsuarioSelecionado = usuarioSelecionado;

                PopupUsuario formulario = new PopupUsuario()
                {
                    FormBorderStyle = FormBorderStyle.FixedToolWindow,
                    StartPosition = FormStartPosition.CenterScreen
                };

                

                formulario.ShowDialog(this);
            }

        }
    }
}
