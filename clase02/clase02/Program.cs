using System;
using Entidades;

namespace clase02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int min = 100;
            int max = -100;
            int count = 0;
            int sum = 0;
            float promedio;

            for(int i = 0 ; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero: ");

                if (int.TryParse(Console.ReadLine(), out num))
                {
                    if (Validador.Validar(num, -100, 100))
                    {
                        if (num < min)
                        {
                            min = num;
                        }
                        if (num > max)
                        {
                            max = num;
                        }
                        sum += num;
                        count++;
                    }

                }
                else
                {
                    Console.WriteLine("Error, numero invalido!!");
                    i--;
                }

            }
            promedio =  (float)sum/count;
            Console.WriteLine($"El promedio es {promedio}");
            Console.WriteLine($"El valor minimo es {min}");
            Console.WriteLine($"El valor maximo es {max}");
            Console.ReadKey();
        }
    }
}
