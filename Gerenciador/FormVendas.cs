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
    public partial class FormVendas : Form
    {
        private readonly IVendaRepository _vendaRepository = new VendaRepository();
        private readonly IProdutoRepository _produtoRepository = new ProdutoRepository();

        public FormVendas()
        {
            InitializeComponent();
            ExibeGrid();
            CarregaCombo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CarregaCombo()
        {
            List<Produto> produtos = new List<Produto>();
            produtos.Add(new Produto());
            produtos.AddRange(_produtoRepository.ObterTodos());

            ddProdutos.DataSource = produtos;
        }

        private void ExibeGrid()
        {
            Buscar();
            dgPrecos.Columns["ProdutosToString"].HeaderText = "Produtos";
            dgPrecos.Columns["Usuario"].Visible = false;
            dgPrecos.Columns["ProdutosVenda"].Visible = false;
            dgPrecos.Columns["TipoPagamento"].Visible = false;
            dgPrecos.Columns["Observacao"].Visible = false;
        }


        private void dgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            ExibeGrid();
        }

        private void Buscar()
        {
            var isdata = DateTime.TryParse(txtData.Text, out DateTime dataPesquisa);
            Produto produto = (Produto)ddProdutos.SelectedValue;

            List<Venda> listhistorico = _vendaRepository.ObterTodos().
                   Where(x =>
                          ( produto==null || 
                            produto.Id == 0 ||
                            x.ProdutosVenda.Select(y=>y.Produto.Id).Contains(produto.Id)
                          )
                         && (!isdata ||
                           x.Data.ToShortDateString() == dataPesquisa.ToShortDateString()
                         )
                   ).OrderByDescending(x => x.Data).ToList();

            dgPrecos.DataSource = listhistorico;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgPrecos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha");
            }
            else
            {

                DialogResult dr = MessageBox.Show("Deseja Excluir?", "Aviso", MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    Venda vendaSelecionada = dgPrecos.SelectedRows[0].DataBoundItem as Venda;

                    try
                    {
                        IProdutoVendaRepository _pvendaRepository = new ProdutoVendaRepository();

                        foreach(ProdutoVenda pv in vendaSelecionada.ProdutosVenda)
                        {
                            _pvendaRepository.Excluir(pv);
                        }

                        _vendaRepository.Excluir(vendaSelecionada);

                        ExibeGrid();

                        MessageBox.Show("Operação realizada com sucesso.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível excluir o produto");
                    }
                }


            }
        }
    }
}
