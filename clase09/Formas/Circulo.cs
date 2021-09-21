using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public sealed class Circulo : Figura
    {

        private float radioCirculo;

        public Circulo(float radioCirculo)
        {
            this.radioCirculo = radioCirculo;
        }

        public override double CalcularPerimetro()
        {
            return (Math.PI * radioCirculo * 2) ;
        }

        public override double CalcularSuperficie()
        {
            return (Math.PI * Math.Pow(radioCirculo,2 ));
        }

        public override string Dibujar()
        {
            return "Dibujando circulo.";
        }
    }
}
