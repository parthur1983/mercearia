using Nucleo.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Modelo
{
    public class ProdutoVenda
    {

        private int _id;
        public virtual int Id { get { return _id; } }
        public virtual Produto Produto { get; set; }
        public virtual Venda Venda { get; set; }
        public virtual int Qtd { get; set; }
        public virtual decimal Valor { get; set; }
        public virtual decimal TotalValor { get; set; }
        public virtual string ToString()
        {
            return  Produto.Descricao +"[" + Qtd + "] " + string.Format("{0:C}", TotalValor);
        }

    }
}
