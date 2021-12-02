using System;

namespace EvTecnica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++)
            {
                bool es = EsPrimo(i);
                Console.WriteLine($"{i}  es primo {es}");  

            }


        }

        public static bool EsPrimo(int num)
        {
            bool esPrimo = true;
            if(num > 1)
            {
                for (int i = num - 1 ; i > 1; i--)
                {
                    if (i != 1 && num % i == 0) 
                    {
                        esPrimo = false;
                        break;
                    }
                }

            }
            else
            {
                esPrimo=false;
            }

            return esPrimo;
        }
    }
}
