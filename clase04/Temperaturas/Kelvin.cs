using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    public class Kelvin
    {
        private double grados;

        public Kelvin(double grados)
        {
            this.grados = grados;
        }

        public double GetGrados()
        {
            return grados;
        }

        public static implicit operator Kelvin(double grados)
        {
            return new Kelvin(grados);
        }


        public static Kelvin CelsiusAKelvin(Celsius c)
        {
            return FahrenheitAKelvin(Fahrenheit.CelsuisAFahrenheit(c));

        }
        public static Kelvin FahrenheitAKelvin(Fahrenheit f)
        {
            return new Kelvin( (f.GetGrados() + 459.67 ) * 5 / 9);

        }
        public static explicit operator Kelvin(Celsius c)
        {
            return CelsiusAKelvin(c);
        }
        public static explicit operator Kelvin(Fahrenheit f)
        {
            return FahrenheitAKelvin(f);
        }

    }
}
