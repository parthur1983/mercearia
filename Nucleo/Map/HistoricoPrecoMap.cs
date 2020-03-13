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
    public class HistoricoPrecoMap : ClassMap<HistoricoPreco>
    {
        public HistoricoPrecoMap()
        {

            Id(x => x.Id)
                .GeneratedBy.Identity()
                .UnsavedValue(0)
                .Column("IdHistorico")
                .Access.CamelCaseField(Prefix.Underscore);

            Map(x => x.IdProduto);
            Map(x => x.Data);
            Map(x => x.Preco);
        }
    }
}

