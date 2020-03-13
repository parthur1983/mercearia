using Nucleo.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Modelo
{
    public class Venda
    {
        public enum Pagamento
        {
            D,
            A
        }

        private int _id;
        public virtual int Id { get { return _id; } }
        public virtual DateTime Data { get; set; }
        public virtual string TipoPagamento { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual string Observacao { get; set; }
        public virtual IList<ProdutoVenda> ProdutosVenda { get; set; }

        public virtual string TotalVenda {
            get {
                return string.Format("{0:C}", ProdutosVenda.Sum(x => x.TotalValor));
            }
        }

        public virtual string LoginUsuario
        {
            get {
                return Usuario.Login;
            }
        }

        public virtual string ProdutosToString
        {
            get
            {
                string retorno = "";
                int contador = 0;

                foreach(ProdutoVenda p in ProdutosVenda)
                {
                    contador++;

                    retorno = retorno + " " + p.ToString() ;

                }

                return retorno;
            }
        }

    }
}
