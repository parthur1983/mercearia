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
    public interface IProdutoVendaRepository : ICrudRepository<ProdutoVenda>
    {
    }

    public class ProdutoVendaRepository : CrudRepository<ProdutoVenda>, IProdutoVendaRepository
    {
       
    }
}
