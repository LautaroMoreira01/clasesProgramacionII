using System;
using System.Collections.Generic;

namespace I01Entidades
{
    public class calculadora
    {
        public static int Add(string numeros)
        {
            int rta = 0;
            string[] arrayNumeros = new string[numeros.Length];

            List<int> listaNumeros = new List<int>();
            List<string> listaStringNumeros = new List<string>();
            
            arrayNumeros = numeros.Split('\n');

            arrayNumeros = numeros.Split(arrayNumeros[0][2]);

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                if(arrayNumeros[i] != null)
                {
                    listaStringNumeros.Add(arrayNumeros[i]);
                }

                listaNumeros.Add(int.Parse(arrayNumeros[i]));

                rta += listaNumeros[i];
            }

            return rta;
        }
    }
}
