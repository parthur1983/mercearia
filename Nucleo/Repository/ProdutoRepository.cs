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
    public interface IProdutoRepository : ICrudRepository<Produto>
    {
    }

    public class ProdutoRepository : CrudRepository<Produto>, IProdutoRepository
    {
       
    }
}
