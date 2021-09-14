using System;
using Indexador;

namespace I02
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();
            int i = 0;
            libro[i] = "La historia de como el profe nos mato con el primer parcial....";

            Console.WriteLine(libro[i]);
            
        }
    }
}
