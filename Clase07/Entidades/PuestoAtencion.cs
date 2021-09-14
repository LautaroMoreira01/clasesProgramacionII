using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{

    public class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1,
            Caja2
        }

        private static int numeroActual;
        private Puesto puesto;


        public static int NumeroActual
        {
            get 
            {
                numeroActual += 1;
                return numeroActual;
            } 
        }


        static PuestoAtencion()
        {
            numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        public bool Atender(Cliente cli)
        {

            if (cli is not null)
            {
                Thread.Sleep(10000);

                return true;
            }
            return false;

        }
    }
}
