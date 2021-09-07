using System;
using Temperaturas;

namespace A01
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Kelvin k = 10;

            Celsius c =(Celsius) k;
            Console.WriteLine(c.GetGrados());
            Fahrenheit f = 10;



        }
    }
}
