using Dominio.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Repository
{
    public interface IUsuarioRepository
    {
        void Salvar(Usuario usuario);
        void Excluir(Usuario usuario);
        Usuario ObterPor(int id);
        List<Usuario> ObterTodos();
    }
}
