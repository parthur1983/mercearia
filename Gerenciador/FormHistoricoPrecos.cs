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
    public partial class FormHistoricoPrecos : Form
    {
        private readonly IHistoricoPrecoRepository _historicoPrecoRepository = new HistoricoPrecoRepository();
        private readonly IProdutoRepository _produtoRepository = new ProdutoRepository();

        public FormHistoricoPrecos()
        {
            InitializeComponent();
            ddProdutos.DataSource = _produtoRepository.ObterTodos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            var isdata = DateTime.TryParse(txtData.Text, out DateTime dataPesquisa);
            Produto produto = (Produto)ddProdutos.SelectedValue;

            List<HistoricoPreco> listhistorico = _historicoPrecoRepository.ObterTodos().
                   Where(x => x.IdProduto == produto.Id
                         && (!isdata ||
                           x.Data.ToShortDateString() == dataPesquisa.ToShortDateString()
                         )
                   ).OrderByDescending(x => x.Data).ToList();

            int maximo = listhistorico.Count - 1;

            for (int i = 0; i < maximo; i++)
            {
                var n1 = listhistorico[i + 1].Preco;
                var n2 = listhistorico[i].Preco;
                var d = n2 - n1;

                decimal r = ((n2 - n1) / n1) * 100;
                listhistorico[i].Variacao = Math.Round(r, 2).ToString() + "%";
            }

            dgPrecos.DataSource = listhistorico;
            dgPrecos.Columns["IdProduto"].Visible = false;
            dgPrecos.Columns["Preco"].Visible = false;
            dgPrecos.Columns["PrecoFormatado"].HeaderText = "Preço";
        }
    }
}
