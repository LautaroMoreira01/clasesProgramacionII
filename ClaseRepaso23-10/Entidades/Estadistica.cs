using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estadistica
    {
        private int empatados;
        public int Empatados{ get { return empatados; } }

        private int ganados;
        public int Ganados { get { return ganados; } }

        private int golesEnContra;
        public int GolesEnContra
        {
            get { return golesEnContra; }
        }
        
        private int golesAFavor;
        public int GolesAFavor
        {
            get { return golesAFavor; }
        }
        
        private int partJugados;
        public int PartJugados
        {
            get { return partJugados; }
        }

        private int perdidos;
        public int Perdidos
        {
            get { return perdidos; }
        }
        
        private int puntos;
        public int Puntos
        {
            get { return puntos; }
        }

        public void Actualizar(EResultado resu , int golFav , int golNeg)
        {

        }
        public Estadistica()
        {

        }



    }
}
