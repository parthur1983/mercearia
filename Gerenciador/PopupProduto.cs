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
    public partial class PopupProduto : Form
    {
        public static Produto ProdutoSelecionado { get; set; }
        private readonly IProdutoRepository _produtoRepository = new ProdutoRepository();

        public PopupProduto()
        {
            InitializeComponent();
            IniciaTela();
        }

        private void IniciaTela()
        {
            txtDescricao.Text = ProdutoSelecionado.Descricao;
            txtPreco.Text = ProdutoSelecionado.Preco.ToString();
            txtObservacao.Text = ProdutoSelecionado.Observacao;
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

            Produto p = PopupProduto.ProdutoSelecionado;
            p.Descricao = txtDescricao.Text;
            p.Preco = decimal.Parse(txtPreco.Text.Replace(".",","));
            p.Observacao = txtObservacao.Text;

            string mensagem = Validacao(p);

            if (mensagem == "")
            {
                _produtoRepository.Salvar(p);

                lblSenhaInvalida.Hide();

                MessageBox.Show("Operação realizada com sucesso.");

                this.Close();
            }
            else
            {
                lblSenhaInvalida.Text = mensagem;
                lblSenhaInvalida.Show();
            }

        }

        private string Validacao(Produto p)
        {
            if (txtDescricao.Text == "")
            {
                return "Descrição obrigatória";
            }

            if (txtPreco.Text == "" || txtPreco.Text=="0" )
            {
                return "Preço obrigatório";
            }

            List<Produto> produtoBanco = _produtoRepository.ObterTodos()
                            .Where(x => x.Id != p.Id &&
                                    x.Descricao.ToUpper() == p.Descricao.ToUpper()).ToList();

            if (produtoBanco!=null && produtoBanco.Count > 0)
            {
                return "Já existe produto com esse nome";
            }

            _produtoRepository.Clear();

            return "";
        }
    }
}
