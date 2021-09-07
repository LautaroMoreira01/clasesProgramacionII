using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        static double cotzRespectoDolar;

        static Dolar()
        {
            cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad * 1.17);
        }
        public static explicit operator Peso(Dolar d)
        {
            return new Peso(d.cantidad * 102.65);
        }

        public double GetCantidad()
        {
            return cantidad;
        }
        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }


        public static bool operator ==(Dolar d , Euro e)
        {
            if(d.GetCantidad() == ((Dolar)e).GetCantidad())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
           return !(d == e);
        }
        public static bool operator ==(Dolar d , Peso p )
        {
            if(d.GetCantidad() == ((Dolar)p).GetCantidad())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Dolar d,Peso p)
        {
           return !(d == p);
        }
        public static bool operator ==(Dolar d1 , Dolar d2)
        {
            if(d1.GetCantidad() == d2.GetCantidad())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Dolar d1,Dolar d2)
        {
           return !(d1 == d2);
        }


        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(((Dolar)e).GetCantidad() + d.cantidad  );
           
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar(((Dolar)p).GetCantidad() + d.cantidad  );
           
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(((Dolar)e).GetCantidad() - d.cantidad  );
           
        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar(((Dolar)p).GetCantidad() - d.cantidad  );
           
        }



    }
}
