using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private Entrenador entrenador;
        private List<Jugador> listaJugadores;
        private string nombre;
        private Estadistica estadistica;
        
        public Entrenador Entrenador
        { 
            get 
            { 
                return entrenador;
            }
            set
            {
                entrenador = value;
            }
        }
        public Estadistica Estadistica 
        { 
            get 
            { 
                return estadistica;
            }
            set
            {
                estadistica = value;
            }
        }
        public List<Jugador> ListaJugadores 
        { 
            get 
            { 
                return listaJugadores;
            }
            set
            {
                listaJugadores = value;
            }
        }
        public string NombreEquipo
        { 
            get 
            { 
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public Equipo(string nombreEquipo , Entrenador ent, List<Jugador> listJug)
        {

        }
    }
}
