using System;
using System.Text;

namespace I05
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;

            Console.WriteLine("Ingrese el numero que desea ver: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine(TablaDeMultiplicar(numero));
            


        }

        public static string TablaDeMultiplicar(int numero)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Tabla de multiplicar del numero {numero}:\n");
            
            for(int i = 1; i <= 10; i++)
            {
                sb.Append($"{numero} x {i} = {numero*i} \n");
            }

            return sb.ToString();



        }
    }
}
