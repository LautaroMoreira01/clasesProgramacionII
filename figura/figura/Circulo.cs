using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    internal class Circulo : FiguraGeometrica
    {
        double radio;

        public Circulo(double radio) : base()
        {

        }
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(radio , 2); 
        }

        public override double CalcularPerimetro()
        {
            return (Math.PI * radio * 2);
        }

    }
}
