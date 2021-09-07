using System;

namespace I08
{
    class Program
    {
        static void Main(string[] args)
        {

            double diasPasados;
            int anio;
            int mes;
            int dia;
            TimeSpan diff;

            Console.WriteLine("Ingrese el anio:");
            anio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el mes:");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el dia:");
            dia = int.Parse(Console.ReadLine());

            DateTime fecha = new DateTime(anio , mes , dia);

            diff = fecha.Subtract( DateTime.Now);

            Console.WriteLine(diff);

        }
    }
}
