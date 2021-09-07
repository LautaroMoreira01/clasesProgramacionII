using System;

namespace A01
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 10;

            Console.WriteLine(Factorial(num));
            

        }

        public static double Factorial(double numero)
        {
            double factorial;
            if(numero == 0)
            {
                return 1;
            }
            else
            {
                numero = numero * Factorial(numero - 1);
            }

            return numero;

        }
    }
}
