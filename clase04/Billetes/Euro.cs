using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {

        private double cantidad;
        static double cotzRespectoDolar;

        static Euro()
        {
            cotzRespectoDolar = 1.17;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        
        }
        public Euro(double cantidad , double cotizacion) : this(cantidad)
        {
            cotizacion = cotzRespectoDolar;

        }

        public static explicit operator Dolar (Euro e)
        {
            return new Dolar(e.cantidad /1.17 );
        }
        public static explicit operator Peso(Euro e)
        {
            return new Peso(((Dolar)e).GetCantidad() * 102.65 );
        }

        public double GetCantidad()
        {
            return cantidad;
        }
        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        public static bool operator ==(Euro e, Peso p)
        {
            if (e.GetCantidad() == ((Euro)p).GetCantidad())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }
        
        public static bool operator ==(Euro e, Dolar d)
        {
            if (e.GetCantidad() == ((Euro)d).GetCantidad())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Euro e, Dolar d )
        {
            return !(e == d);
        }
        public static bool operator ==(Euro e1,Euro e2)
        {
            if (e1.GetCantidad() == e2.GetCantidad())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }


        public static Euro operator +(Euro e , Dolar d)
        {
            return new Euro(((Euro)d).GetCantidad() + e.cantidad);

        }

        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(((Euro)p).GetCantidad() + e.cantidad);

        }
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(((Euro)d).GetCantidad() - e.cantidad);

        }

        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(((Euro)p).GetCantidad() - e.cantidad);

        }
    }
}
