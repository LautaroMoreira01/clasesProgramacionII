using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Partido
    {
        private Equipo equipoLocal;
        private Equipo equipoVisitante;
        private int golesLocal;
        private int golesVisitante;
        private bool partidoJugado;
        private Random random;
        private EResultado resultado;

        private Partido()
        {
            random = new Random();
        }

        public Partido(Equipo local , Equipo visitante):this()
        {
            this.equipoLocal = local;
            this.equipoVisitante = visitante;
        }

        public void SimularPartido()
        {
            random.Next(0,6);
        }


    }
}
