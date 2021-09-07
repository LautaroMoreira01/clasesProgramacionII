using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I06
{
    public class CalculadoraDeAreas
    {

        public static double CalcularAreaCuadrado(double longituLado)
        {

            return Math.Pow(longituLado, 2)

        }
        public static double CalcularAreaTriangulo(double baseTr ,  double altura)
        {
            return baseTr * altura;
        }
        public static double CalcularAreaCirculo(double radio) 
        {
            return (Math.PI * Math.Pow(radio , 2)); 
        }

    }
}
