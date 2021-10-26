using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Entrenador : Deportista
    {
        private bool campeonDelMundo;
        private int cantEquiposEntrenados;

        public Entrenador(string nombApe , int edad , int cantParti, int cantEquipos, bool camp) : base(nombApe , edad ,cantParti)
        {
                this.campeonDelMundo = camp;
                this.cantEquiposEntrenados = cantEquipos;
        }
                
        
        public int CantEquiposEntenados
        {
            get { return cantEquiposEntrenados; }
        }
        public bool CampeonDelMundo 
        {
            get { return campeonDelMundo; }
        }
    }
}
