 using System;

namespace I04
{
    class Program
    {
        static void Main(string[] args)
        {
            double operandoUno;
            double operandoDos;
            double resultado;
            char operacion;
            char seguir;
            
            do
            {

                Console.WriteLine("Ingrese el primer operando");
                operandoUno = double.Parse(Console.ReadLine());


                Console.WriteLine("Ingrese el segundo operando");
                operandoDos = double.Parse(Console.ReadLine());
                
                Console.WriteLine("Ingrese la operacion que desea realizar: (\"+\" \"-\" \"*\" \"/\")");
                operacion = Convert.ToChar(Console.ReadLine());

                resultado = Calculadora.Calcular(operandoUno, operandoDos ,operacion );

                Console.WriteLine($"{operandoUno} {operacion} {operandoDos} = {resultado}");

                Console.WriteLine("Desea realizar otra operacion? (S / N)");
                seguir = Convert.ToChar(Console.ReadLine());


            } while (seguir == 's' || seguir == 'S');
        }
    }
}
