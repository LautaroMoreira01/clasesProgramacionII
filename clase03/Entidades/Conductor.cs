using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Conductor
    {

        private string nombre;
        private int[] dias;
        private Random random;

        private Conductor() 
        {
            dias = new int[7];
            random = new Random();
        }

        public Conductor(string nombre): this()
        {
            this.nombre = nombre;
        }
        
        public void CargarViajesSemanal()
        {
            int aux = random.Next(1, 7);

            for(int i = 0; i < 7; i++)
            {
                if(aux != i)
                {
                    dias[i] = random.Next(100 , 1000) ; 
                }
                else
                {
                    dias[i] = 0;
                }

            }
        
        }

    }
}
