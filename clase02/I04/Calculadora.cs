using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I04
{
    public class Calculadora
    {

        public static double Calcular(double primerOperando , double segundoOperando , char operacion)
        {
            double resultado = 0;

            switch (operacion)
            {
                case '+':
                    resultado = primerOperando + segundoOperando;
                    break;
                case '-':
                    resultado = primerOperando - segundoOperando;
                    break;
                case '*':
                    resultado  = primerOperando * segundoOperando;
                    break;
                case '/':
                    if (Validar(segundoOperando))
                    {
                        resultado = primerOperando / segundoOperando;
                    }
                    resultado= 0;
                    break;

            }

            return resultado;


        }

        private static bool Validar(double operando)
        {
            if(operando != 0)
            {
                return true;
            }
            return false;
        }

    }
}
