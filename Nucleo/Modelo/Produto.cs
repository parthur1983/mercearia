using Nucleo.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Modelo
{
    public class Produto
    {
  
        private int _id;
        public virtual int Id { get { return _id; } }

        public virtual string Descricao { get; set; }

        public virtual string Observacao { get; set; }

        public virtual decimal Preco { get; set; }

        public virtual string PrecoFormatado
        {
            get { return string.Format("{0:C}", Preco); }
        }
    }
}
