using System;

namespace Entidades
{
    public class Validador
    
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool rta = false; 
            if  (valor >= min && valor <= max)
            {
                rta = true;
            }
            return rta;
        }
    }

}
