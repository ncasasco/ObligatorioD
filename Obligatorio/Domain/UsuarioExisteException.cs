using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class UsuarioExisteException : Exception
    {
        public UsuarioExisteException(string mensaje)
        {
        }
    }
}
