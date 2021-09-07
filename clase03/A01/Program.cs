using System;
using Entidades;

namespace A01
{
    class Program
    {
        static void Main(string[] args)
        {
            Conductor c1 = new Conductor("Lautaro");

            c1.CargarViajesSemanal();
        }
    }
}
