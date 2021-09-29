using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01_Consola_
{
    public class OtraClase
    {
        public void LlamarMiclase()
        {
            try
            {
                Miclase clase = new Miclase(" ");

            }catch (UnaExcepcion ex)
            {

                throw new MiExcepcion("" , ex);

            }
        }
    }
}
