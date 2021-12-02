using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    public class Cuadrado : FiguraGeometrica
    {

        double bas;
        double altura;

        public Cuadrado(double bas , double altura) : base()
        {

        }

        public override double CalcularArea()
        {
            return bas * altura;
        }

        public override double CalcularPerimetro()
        {
            return (bas * 2) + (altura * 2);
        }
    }
}
