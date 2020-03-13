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
    public class VendaoMap : ClassMap<Venda>
    {
        public VendaoMap()
        {

            Id(x => x.Id)
                .GeneratedBy.Identity()
                .UnsavedValue(0)
                .Column("IdVenda")
                .Access.CamelCaseField(Prefix.Underscore);

            Map(x => x.TipoPagamento);
            Map(x => x.Observacao);
            Map(x => x.Data);
            References(x => x.Usuario)
                    .Column("IdUsuario")
                        .Cascade.All();

            HasMany(x => x.ProdutosVenda);
        }
    }
}

