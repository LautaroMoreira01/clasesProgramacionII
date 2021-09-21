using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public class Rectangulo : Figura
    {
        private float baseRectangulo;
        private float alturaRectangulo;

        public Rectangulo(float baseRectangulo, float alturaRectangulo)
        {
            this.baseRectangulo = baseRectangulo;
            this.alturaRectangulo = alturaRectangulo;
        }

        public override string Dibujar()
        {
            return "Dibujando rectangulo.";
        }
        public override double CalcularPerimetro()
        {
            return  (baseRectangulo + alturaRectangulo);
        }

        public override double CalcularSuperficie()
        {
            return  (baseRectangulo * alturaRectangulo) * 2;

        }
    }
}
