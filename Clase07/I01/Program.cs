using System;
using Entidades;

namespace I01
{
    class Program
    {
        static void Main(string[] args)
        {
            Negocio telefonica = new Negocio("Telefonica");

            Cliente c1 = new Cliente("Lautaro", 1);
            Cliente c2 = new Cliente("Mauricio", 2);
            Cliente c3 = new Cliente("Lautaro", 1);
            Cliente c4 = new Cliente("Mauricio", 2);
            Cliente c5 = new Cliente("fabricio", 3);

            if(telefonica + c1)
            {
                Console.WriteLine($"Se pudo agregar a {c1.Nombre}");
            }
            if (telefonica + c2)
            {
                Console.WriteLine($"Se pudo agregar a {c2.Nombre}");
            }
            if (telefonica + c3)
            {
                Console.WriteLine($"Se pudo agregar a {c3.Nombre}");
            }
            if (telefonica + c4)
            {
                Console.WriteLine($"Se pudo agregar a {c4.Nombre}");
            }

            if(c1 == c3)
            {
                Console.WriteLine($"C1 y C3 son la misma persona");
            }
            if(c2 == c4)
            {
                Console.WriteLine($"C2 y C4 son la misma persona");
            }
            if(c2 != c1)
            {
                Console.WriteLine($"C2 y C1 son diferente misma persona");
            }

            if(telefonica == c1)
            {
                Console.WriteLine($"c1 se ya esta en la queue");
            }
            if(telefonica == c2)
            {
                Console.WriteLine($"c2 se ya esta en la queue");
            }
            if(telefonica == c3)
            {
                Console.WriteLine($"c3 se ya esta en la queue");
            }
            if(telefonica != c5)
            {
                Console.WriteLine($"c5 no se encuentra en la queue ");
            }


        }
    }
}
