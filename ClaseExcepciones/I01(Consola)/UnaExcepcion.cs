using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01_Consola_
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion(string message):this(message , null) { }
        public UnaExcepcion (string message , Exception inner):base(message  , inner) { }
    }
}
