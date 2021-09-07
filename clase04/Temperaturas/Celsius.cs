using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    public class Celsius
    {
        private double grados;

        public Celsius(double grados)
        {
            this.grados = grados;
        }

        public double GetGrados()
        {
            return grados;
        }


        public static implicit operator Celsius( double grados)
        {
            return new Celsius(grados);
        }


        public static Celsius FahrenheitACelsius(Fahrenheit f)
        {
            return new Celsius((f.GetGrados() - 32 ) * (5/9));
        }

        public static Celsius KelvinACelsius(Kelvin k)
        {

            return  FahrenheitACelsius(Fahrenheit.KelvinAFahrenheit(k));
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            return FahrenheitACelsius(f);
        }
        public static explicit operator Celsius(Kelvin k)
        {
            return KelvinACelsius(k);
        }

    }
}
