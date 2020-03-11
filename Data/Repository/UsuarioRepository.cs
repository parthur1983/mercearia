using Nucleo.Config;
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
    public interface IUsuarioRepository
    {
        void Salvar(Usuario usuario);
        void Excluir(Usuario usuario);
        Usuario ObterPor(int id);
        List<Usuario> ObterTodos();
    }

    public class UsuarioRepository : IUsuarioRepository
    {

       private readonly ISession _session = new HibernateSession().OpenSession();

        public void Salvar(Usuario usuario)
        {
            using (var tran = _session.BeginTransaction())
            {
                _session.SaveOrUpdate(usuario);
                tran.Commit();
            }
        }

        public void Excluir(Usuario usuario)
        {
            using (var tran = _session.BeginTransaction())
            {
                _session.Delete(usuario);
                tran.Commit();
            }
        }

        public Usuario ObterPor(int id)
        {
            return _session.Get<Usuario>(id);
        }

        public List<Usuario> ObterTodos()
        {
            return _session.Query<Usuario>().ToList();
        }
    }
}
