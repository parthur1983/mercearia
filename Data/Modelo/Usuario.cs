using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Modelo
{
    public class Usuario
    {
        public enum Tipo
        {
            ADM,
            VENDEDOR
        }

        private int _id;
        public virtual int Id { get { return _id; } }

        public virtual string Login { get; set; }
        public virtual string Senha { get; set; }
    }
}
