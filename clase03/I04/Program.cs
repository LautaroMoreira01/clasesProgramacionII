using System;
using Entidades;

namespace I04
{
    class Program
    {
        static void Main(string[] args)
        {

            string dibujo;

            Boligrafo b1 = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo b2 = new Boligrafo(ConsoleColor.Red , 50);

            Console.BackgroundColor = b1.GetColor(); 

            Console.WriteLine($"Boli {b1.GetColor()}");
            Console.WriteLine($"Cantidad de tinta {b1.GetTinta()}");
            b1.Pintar(50, out dibujo);
            Console.WriteLine(dibujo);
            Console.WriteLine($"Cantidad de tinta {b1.GetTinta()}");
            b1.Pintar(100 , out dibujo);
            Console.WriteLine(dibujo);
            Console.WriteLine($"Cantidad de tinta {b1.GetTinta()}");

            Console.BackgroundColor = b2.GetColor();

            Console.WriteLine($"Boli {b2.GetColor()}");
            Console.WriteLine($"Cantidad de tinta {b2.GetTinta()}");
            b2.Pintar(20, out dibujo);
            Console.WriteLine(dibujo);
            Console.WriteLine($"Cantidad de tinta {b2.GetTinta()}");
            b2.Pintar(60, out dibujo);
            Console.WriteLine(dibujo);
            Console.WriteLine($"Cantidad de tinta {b2.GetTinta()}");

            Console.BackgroundColor = ConsoleColor.Black;






        }
    }
}
