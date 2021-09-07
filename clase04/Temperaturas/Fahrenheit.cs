using System;

namespace Temperaturas
{
    public class Fahrenheit
    {
        private double grados;

        public Fahrenheit(double grados)
        {
            this.grados = grados;
        }

        public double GetGrados()
        {
            return grados;
        }

        public static implicit operator Fahrenheit(double grados)
        {
            return new Fahrenheit(grados);
        }

        public static Fahrenheit CelsuisAFahrenheit( Celsius c)
        {
            return new Fahrenheit(c.GetGrados() * (9 / 5) + 32) ;
        }
        public static Fahrenheit KelvinAFahrenheit( Kelvin c)
        {
            return new Fahrenheit(c.GetGrados() * (9.0/ 5.0) - 459.67) ;
        }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            return KelvinAFahrenheit(k);
        }
        public static explicit operator Fahrenheit(Celsius c)
        {
            return CelsuisAFahrenheit(c);
        }

    }
}
