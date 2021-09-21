using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public sealed class Cuadrado : Rectangulo
    {
        private float lado;
        public Cuadrado(float lado) : base(lado, lado)
        {
        }


    }
}
