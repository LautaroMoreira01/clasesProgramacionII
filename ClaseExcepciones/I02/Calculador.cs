using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I02
{
    public class Calculador
    {
        public static float Calcular(int n1 , int n2)
        {
            float res = 0;
            try
            {
                res = (float)n1 / n2;
            }
            catch (DivideByZeroException)
            {
                throw;
            }
          
            return res;
          
        }
    }
}
