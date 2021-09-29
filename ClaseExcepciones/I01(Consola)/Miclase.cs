using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01_Consola_
{
    public class Miclase
    {
        public Miclase(string bo)
        {
            try
            {
               Miclase clase = new Miclase();

            }
            catch (DivideByZeroException ex)
            {

                throw new UnaExcepcion(ex.Message , ex);
            }

        }
        public Miclase()
        {
            try
            {
                LanzarExcepcion();

            }
            catch (DivideByZeroException)
            {

                throw;
            }
            
        }
        public static void LanzarExcepcion()
        {
            throw new DivideByZeroException();
        }
    }
}
