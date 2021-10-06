using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseMetodosDeExtencion
{
    public static class Int32Extendida
    {

        public static string FizzBuzz(this Int32 numero)
        {
            if (numero % 3 == 0 && numero % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (numero % 3 == 0)
            {
                return "Fizz";
            }
            else if (numero % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return numero.ToString();
            }



        }

    }
}
