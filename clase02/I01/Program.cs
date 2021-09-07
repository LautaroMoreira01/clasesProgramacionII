using System;

namespace I01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int max = int.MinValue;
            int suma = 0;
            int min = int.MaxValue;
            float promedio;

            for(int i = 0; i < 10; i++)
            {
                
                Console.WriteLine("Ingrese un numero.");
                numero = int.Parse(Console.ReadLine());
                
                if(Validador.Validar(numero , -100, 100))
                { 
                    if(numero > max)
                    {
                        max = numero;
                    }

                    if(numero < min)
                    {
                        min = numero;
                    }

                    suma += numero;
                }
            }

            promedio = (float)suma / 10;

            Console.WriteLine($"Minimo: {min}");
            Console.WriteLine($"Maximo: {max}");
            Console.WriteLine($"Promedio: {promedio}");
        
        }
    }

}
