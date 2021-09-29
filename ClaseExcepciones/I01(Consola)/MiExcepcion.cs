using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01_Consola_
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion(string message) : this(message, null) { }
        public MiExcepcion(string message, Exception inner) : base(message, inner) { }
    }
}
