using System;

namespace I06
{
    class Program
    {
        static void Main(string[] args)
        {
            double longitudLado;
            double baseTr;
            double alturaTr;
            double radio;

            Console.WriteLine("Ingrese la longitud del lado del cuadrado:");
            longitudLado = double.Parse(Console.ReadLine());

            Console.WriteLine($"Area del cuadrado: {CalculadoraDeAreas.CalcularAreaCuadrado(longitudLado)}");
            
            Console.WriteLine("Ingrese la base del triangulo:");
            baseTr = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triangulo:");
            alturaTr = double.Parse(Console.ReadLine());

            Console.WriteLine($"Area del triangulo: {CalculadoraDeAreas.CalcularAreaTriangulo(baseTr , alturaTr)}");
            
            Console.WriteLine("Ingrese el radio del circulo:");
            radio = double.Parse(Console.ReadLine());

            Console.WriteLine($"Area del triangulo: {CalculadoraDeAreas.CalcularAreaCirculo(radio)}");
            
            
        }
    }
}
