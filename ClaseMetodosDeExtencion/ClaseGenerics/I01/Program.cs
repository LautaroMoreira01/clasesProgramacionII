using System;
using I01Entidades;

namespace I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("Torneo rempalago basquet");
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Torneo rempalago futbol");

            EquipoBasquet eBasquet1 = new EquipoBasquet("Nuggets", new DateTime(2010, 8, 12));
            EquipoBasquet eBasquet2 = new EquipoBasquet("Spurs", new DateTime(2008, 4, 30));
            EquipoBasquet eBasquet3 = new EquipoBasquet("Bulls", new DateTime(2001, 2, 15));

            EquipoFutbol eFutbol1 = new EquipoFutbol("River", new DateTime(1980, 5, 15));
            EquipoFutbol eFutbol2 = new EquipoFutbol("Boca", new DateTime(1801, 6, 15));
            EquipoFutbol eFutbol3 = new EquipoFutbol("Lanus", new DateTime(2000, 4, 7));

            torneoBasquet += eBasquet1;
            torneoBasquet += eBasquet2;
            torneoBasquet += eBasquet3;

            torneoFutbol += eFutbol1;
            torneoFutbol += eFutbol2;
            torneoFutbol += eFutbol3;
            //torneoFutbol += eBasquet1;
            Console.WriteLine($"{torneoBasquet.Mostrar()}");
            Console.WriteLine($"{torneoFutbol.Mostrar()}");
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);




        }
    }
}
