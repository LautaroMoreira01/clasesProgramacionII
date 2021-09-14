using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion.Puesto caja;
        private Queue<Cliente> clientes;
        private string nombre;


        private Negocio() 
        {
            caja = PuestoAtencion.Puesto.Caja1;
            clientes = new Queue<Cliente>();
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }
        public Cliente Cliente 
        {
            get { return clientes.Dequeue(); }
            set { clientes.Enqueue(value) ; }
        }
        public int ClientesPendientes { get { return clientes.Count; } }
        public static bool operator +(Negocio n , Cliente c)
        {
            if(n != c)
            {
                n.Cliente = c;
                return true;
            }
            return false;

        }
        public static bool operator ==(Negocio n, Cliente c)
        {
            bool rta = false;
            foreach (Cliente item in n.clientes)
            {
                if (c == item)
                {
                    rta = true;
                }
            }
            return rta;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
        public static bool operator ~(Negocio n)
        {
            PuestoAtencion puestoAtencion = new PuestoAtencion(n.caja);

            return  puestoAtencion.Atender(n.Cliente);
            

        }

    }
}
