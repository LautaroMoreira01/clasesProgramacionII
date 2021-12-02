using System;

namespace Figura
{
    public abstract class FiguraGeometrica
    {
        double area;
        double perimetro;


        public abstract double CalcularArea();

        public abstract double CalcularPerimetro();
    }
}
