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
    public class ProdutoMap : ClassMap<Produto>
    {
        public ProdutoMap()
        {

            Id(x => x.Id)
                .GeneratedBy.Identity()
                .UnsavedValue(0)
                .Column("IdProduto")
                .Access.CamelCaseField(Prefix.Underscore);

            Map(x => x.Descricao);
            Map(x => x.Observacao);
            Map(x => x.Preco);
        }
    }
}

