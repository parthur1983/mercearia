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
    public partial class FormProduto : Form
    {
        private readonly IProdutoRepository _produtoRepository = new ProdutoRepository();
        private bool sortAscending = false;

        public FormProduto()
        {
            InitializeComponent();
            dgUsuarios.DataSource = _produtoRepository.ObterTodos();
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
                Produto usuarioSelecionado = dgUsuarios.SelectedRows[0].DataBoundItem as Produto;

                PopupProduto.ProdutoSelecionado = usuarioSelecionado;

                PopupProduto formulario = new PopupProduto()
                {
                    FormBorderStyle = FormBorderStyle.FixedToolWindow,
                    StartPosition = FormStartPosition.CenterScreen
                };
             

                formulario.ShowDialog(this);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopupProduto.ProdutoSelecionado = new Produto(); 

            PopupProduto formulario = new PopupProduto()
            {
                FormBorderStyle = FormBorderStyle.FixedToolWindow,
                StartPosition = FormStartPosition.CenterScreen
            };

            formulario.FormClosed += new FormClosedEventHandler(AtualizaListagem);

            formulario.ShowDialog(this);
        }

        private void AtualizaListagem(object sender, FormClosedEventArgs e)
        {
            AtualizaListagem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha");
            }
            else
            {

                DialogResult dr = MessageBox.Show("Deseja Excluir?", "Aviso", MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    Produto produtoSelecionado = dgUsuarios.SelectedRows[0].DataBoundItem as Produto;

                    try
                    {
                        _produtoRepository.Excluir(produtoSelecionado);

                        AtualizaListagem();

                        MessageBox.Show("Operação realizada com sucesso.");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Não foi possível excluir o produto");
                    }
                }

                
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizaListagem();
        }

        private void AtualizaListagem()
        {
            if (txtPesquisa.Text == "")
            {
                dgUsuarios.DataSource = _produtoRepository.ObterTodos();
            }
            else
            {
                dgUsuarios.DataSource = _produtoRepository.ObterTodos().Where
                    ( x=> x.Descricao.ToUpper().Contains(txtPesquisa.Text.ToUpper())).ToList();
            }

            dgUsuarios.ClearSelection();

            dgUsuarios.Update();
            dgUsuarios.Refresh();
        }

        private void dgUsuarios_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //List<Produto> list = _produtoRepository.ObterTodos();

            //if (sortAscending)
            //    dgUsuarios.DataSource = list.OrderBy(x=> dgUsuarios.Columns[e.ColumnIndex].DataPropertyName).ToList();
            //else
            //    dgUsuarios.DataSource = list.OrderBy(x => dgUsuarios.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList();

            //sortAscending = !sortAscending;
        }
    }
}
