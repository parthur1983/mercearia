using Dominio.Modelo;
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
    public class UsuarioMap : ClassMap<Usuario>
    {
        public UsuarioMap()
        {

            Id(x => x.Id)
                .GeneratedBy.Identity()
                .UnsavedValue(0)
                .Column("IdUsuario")
                .Access.CamelCaseField(Prefix.Underscore);

            Map(x => x.Login);
            Map(x => x.Senha);
        }
    }
}

