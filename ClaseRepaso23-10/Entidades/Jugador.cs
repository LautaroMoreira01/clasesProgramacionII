using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Deportista
    {
        private EPuesto puesto;

        public EPuesto Puesto { get { return puesto; } }

        public Jugador(string nombreApellido, int edad , int cantidadPartidos,EPuesto puesto) :base(nombreApellido, edad, cantidadPartidos)
        {
            this.puesto = puesto;   
        }


    }
}
