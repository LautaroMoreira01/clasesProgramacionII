using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I03
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string binario = "";
            while(numeroEntero > 0)
            {
                binario = (numeroEntero % 2).ToString() + binario;
                numeroEntero /= 2;
            }

            return binario;

        }
        public static int ConvertirBinarioADecimal(int numeroBinario)
        {
            string numeroBinarioString = numeroBinario.ToString();
            int aux;
            int res = 0; 

            for (int i = 0 ; i < numeroBinarioString.Length; i++)
            { 
                aux = int.Parse(numeroBinarioString[i].ToString());

                res = res * 2 + aux;  
            }
            return res;
        }
    }
}
