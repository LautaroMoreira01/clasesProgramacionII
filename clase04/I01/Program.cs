using System;
using Entidades;

namespace I01
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador a = new Sumador();
            Sumador b = new Sumador(2);

            Console.WriteLine(a.Sumar(15, 55));
            Console.WriteLine(a.Sumar("15", "55"));
            Console.WriteLine("Cantidad sumas a");
            Console.WriteLine((int)a);
            Console.WriteLine("Cantidad sumas b");
            Console.WriteLine((int)b);

            if(a | b)
            {
                Console.WriteLine("tienen la misma cantidad de Sumas.");
            }
        }
    }
}
