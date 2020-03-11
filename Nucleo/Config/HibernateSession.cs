
using Nucleo.Map;
using FluentNHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using StructureMap;
using NHibernate.Cfg;
using System;
using System.IO;
using Nucleo.Modelo;
using Nucleo.Repository;

namespace Nucleo.Config
{
    public class HibernateSession
    {
        private static ISessionFactory _sessionFactory;
        private static String nomeArquivo = "database2";

        public ISession OpenSession()
        {
            if (_sessionFactory == null)
            {
                    var cfg = Fluently.Configure().
                       Database(SQLiteConfiguration.Standard.ShowSql().UsingFile(nomeArquivo)).
                       Mappings(m => m.FluentMappings.AddFromAssemblyOf<UsuarioMap>()).
                       ExposeConfiguration(x=> BuildSchema(x));
                    _sessionFactory = cfg.BuildSessionFactory();
            }
            return _sessionFactory.OpenSession();
        }

        private void BuildSchema(Configuration config)
        {
            if (!File.Exists(nomeArquivo))
            {
                new SchemaExport(config).Create(false, true);
                this.InsereUsuarios();
            }
        }

        private void InsereUsuarios()
        {
           foreach(Usuario usuario in Usuario.ListaUsuarios())
            {
                new UsuarioRepository().Salvar(usuario);
            }
        }
    }


}
