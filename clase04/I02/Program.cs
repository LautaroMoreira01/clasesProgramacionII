using System;
using Billetes;

namespace I02
{
    class Program
    {
        static void Main(string[] args)
        {

            Dolar d1 = 10;
            Dolar d2 = 15;
            Dolar d3 = 10;

            Euro e1 = 10;
            Euro e2 = 10;

            Peso p1 = 10000;
            Peso p2 = 100;

            Console.WriteLine($"{d1.GetCantidad()} Dolares son {((Peso)d1).GetCantidad()} Pesos.");
            Console.WriteLine($"{d1.GetCantidad()} Dolares son {((Euro)d1).GetCantidad()} Euros.");
            Console.WriteLine();

            Console.WriteLine($"{e1.GetCantidad()} Euros son {((Peso)e1).GetCantidad()} Pesos.");
            Console.WriteLine($"{e1.GetCantidad()} Euros son {((Dolar)e1).GetCantidad()} Dolares.");
            Console.WriteLine();

            Console.WriteLine($"{p1.GetCantidad()} Pesos son {((Dolar)p1).GetCantidad()} Dolares.");
            Console.WriteLine($"{p1.GetCantidad()} Pesos son {((Euro)p1).GetCantidad()} Euros.");
            Console.WriteLine();


            Console.WriteLine($"{p1.GetCantidad()} Pesos + {e1.GetCantidad()} ({((Peso)e1).GetCantidad()} Pesos) = {(p1 + e1).GetCantidad()} Pesos.");
            Console.WriteLine($"{e1.GetCantidad()} Euros + {d1.GetCantidad()} ({((Euro)d1).GetCantidad()} Euros) = {(e1 + d1).GetCantidad()} Euros.");
            Console.WriteLine($"{p1.GetCantidad()} Pesos + {d1.GetCantidad()} ({((Peso)d1).GetCantidad()} Pesos) = {(p1 + d1).GetCantidad()} Pesos.");
            Console.WriteLine();

            if(d1 != d2)
            {
                Console.WriteLine($"{d1.GetCantidad()}({d1.GetType().Name}) != {d2.GetCantidad()} ({d2.GetType().Name})");
            }

            if (d1 == d3)
            {
                Console.WriteLine($"{d1.GetCantidad()}({d1.GetType().Name}) == {d3.GetCantidad()} ({d3.GetType().Name})");
            }

            if (e1 == d3)
            {
                Console.WriteLine($"{e1.GetCantidad()}({e1.GetType().Name}) == {d3.GetCantidad()} ({d3.GetType().Name})");
            }

            if (p2 == d1)
            {
                Console.WriteLine($"{p2.GetCantidad()}({p2.GetType().Name}) == {d1.GetCantidad()} ({d1.GetType().Name})");
            }

            if (e2 == e1)
            {
                Console.WriteLine($"{e2.GetCantidad()}({e2.GetType().Name}) == {e1.GetCantidad()} ({e1.GetType().Name})");
            }

        }
    }
}
