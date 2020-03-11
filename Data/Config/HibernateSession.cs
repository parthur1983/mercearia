
using Nucleo.Map;
using FluentNHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using StructureMap;

namespace Nucleo.Config
{
    public class HibernateSession
    {
        private static ISessionFactory _sessionFactory;

        public ISession OpenSession()
        {
            if (_sessionFactory == null)
            {
                    var cfg = Fluently.Configure().
                       Database(SQLiteConfiguration.Standard.ShowSql().UsingFile("database")).
                       Mappings(m => m.FluentMappings.AddFromAssemblyOf<UsuarioMap>());
                    _sessionFactory = cfg.BuildSessionFactory();
            }
            return _sessionFactory.OpenSession();
        }


    }


}
