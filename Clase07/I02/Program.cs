using System;
using Indexador;

namespace I02
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();
            libro[0] = "La historia de como el profe nos mato con el primer parcial....";
            libro[1] = "\nTodo comenzo un 14 de septiembre...";
            libro[2] = "\nde ahi todo fue en picada.";

            libro[1] = "\nTodo comenzo un 25 de octubre...";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(libro[i]);
            }

        }
    }
}
