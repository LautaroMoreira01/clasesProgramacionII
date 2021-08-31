using System;
using Entidades;


namespace I03
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante("Lautaro", "Moreira", "102031");
            Estudiante e2 = new Estudiante("Juan", "Perez", "154003");
            Estudiante e3 = new Estudiante("Ricardo", "Montaner", "420021");

            e1.SetNotaPrimerParcial(6);
            e1.SetNotaSegundoParcial(9);

            e2.SetNotaPrimerParcial(4);
            e2.SetNotaSegundoParcial(6);

            e3.SetNotaPrimerParcial(1);
            e3.SetNotaSegundoParcial(3);

            Console.WriteLine(e1.Mostrar());
            Console.WriteLine(e2.Mostrar());
            Console.WriteLine(e3.Mostrar());

            Console.ReadKey();

        }
    }
}
