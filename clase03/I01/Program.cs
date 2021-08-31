using System;
using Entidades;

namespace I01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta("Sancor", 120M);
            Console.WriteLine(cuenta.Mostrar());
            cuenta.Ingresar(20M);
            Console.WriteLine(cuenta.Mostrar());
            cuenta.Retirar(40M);
            Console.WriteLine(cuenta.Mostrar());



        }
    }
}
