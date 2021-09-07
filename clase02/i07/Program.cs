using System;

namespace i07
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseTr;
            double altura;
            double hipotenusa;

            Console.WriteLine("Ingrese la base del triangulo:");
            baseTr = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura dell triangulo:");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"Hipotenusa : {Math.Sqrt(Math.Pow(baseTr, 2) + (Math.Pow(altura, 2)))}");


        }
    }
}
