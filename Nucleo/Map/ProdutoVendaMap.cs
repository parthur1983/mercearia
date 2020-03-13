using Nucleo.Modelo;
using FluentNHibernate.Mapping;
using NHibernate;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Map
{
    public class ProdutoVendaMap : ClassMap<ProdutoVenda>
    {
        public ProdutoVendaMap()
        {

            Id(x => x.Id)
                .GeneratedBy.Identity()
                .UnsavedValue(0)
                .Column("IdProdutoVenda")
                .Access.CamelCaseField(Prefix.Underscore);

            Map(x => x.Valor);
            Map(x => x.Qtd);

            References(x => x.Venda)
                    .Column("IdVenda");

            References(x => x.Produto)
                .Column("IdProduto");

        }
    }
}

