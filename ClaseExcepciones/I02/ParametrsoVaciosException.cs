using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I02
{
    public class  ParametrsoVaciosException : Exception
    {
        public ParametrsoVaciosException(string mensaje , Exception inner) : base(mensaje  , inner)
        {}
        public ParametrsoVaciosException(string mensaje) : this(mensaje, null)
        {}

    }
}
