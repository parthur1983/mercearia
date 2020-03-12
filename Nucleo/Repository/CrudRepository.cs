using Nucleo.Infra;
using Nucleo.Modelo;
using NHibernate;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Repository
{

    public interface ICrudRepository<T> where T : class
    {
        void Salvar(T obj);
        void Excluir(T obj);
        T ObterPor(int id);
        List<T> ObterTodos();
    }

    public class CrudRepository<T> : ICrudRepository<T> where T : class
    {

       private readonly ISession _session = new HibernateSession().OpenSession();

        public void Salvar(T obj)
        {
            using (var tran = _session.BeginTransaction())
            {
                _session.SaveOrUpdate(obj);
                tran.Commit();
            }
        }

        public void Excluir(T obj)
        {
            using (var tran = _session.BeginTransaction())
            {
                _session.Delete(obj);
                tran.Commit();
            }
        }

        public T ObterPor(int id)
        {
            return _session.Get<T>(id);
        }

        public List<T> ObterTodos()
        {
            return _session.Query<T>().ToList();
        }
    }
}
