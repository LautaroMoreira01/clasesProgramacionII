using System;

namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        static double cotzRespectoDolar;

        static Peso()
        {
            cotzRespectoDolar = 102.65;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizacion = cotzRespectoDolar;
        }

        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.cantidad / cotzRespectoDolar);
        }
        public static explicit operator Euro( Peso p)
        {

            return new Euro((((Dolar)p).GetCantidad()) / 1.17) ;
        }

        public double GetCantidad()
        {
            return cantidad;
        }
        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }

        public static Peso operator +(Peso p , Euro e)
        {
            return new Peso(((Peso)e).GetCantidad() + p.cantidad);

        }

        public static Peso operator +(Peso p , Dolar d)
        {
            return new Peso(((Peso)d).GetCantidad() + p.cantidad);

        }
        public static Peso operator -(Peso p , Euro e)
        {
            return new Peso(((Peso)e).GetCantidad() - p.cantidad);

        }

        public static Peso operator -(Peso p , Dolar d)
        {
            return new Peso(((Peso)d).GetCantidad() - p.cantidad);
        }
        public static bool operator ==(Peso p , Euro e)
        {
            if (p.GetCantidad() == ((Peso)e).GetCantidad())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=( Peso p , Euro e)
        {
            return !(p == e);
        }

        public static bool operator ==( Peso p , Dolar d)
        {
            if (p.GetCantidad() == ((Peso)d).GetCantidad())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(  Peso p  , Dolar d)
        {
            return !( d == p);
        }
        public static bool operator ==(Peso p1, Peso p2)
        {
            if (p1.GetCantidad() == p2.GetCantidad())
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }

    }
}
