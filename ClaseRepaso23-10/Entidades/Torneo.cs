using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Torneo
    {
        private static Equipo campeon;
        private static List<Fecha> fixture;
        private static List<Equipo> listaEquipos;
        private static string nombreTorneo;

        static Torneo()
        {

        }

        public static List<Equipo> ListaEquipos { get { return listaEquipos; } set { listaEquipos = value; } }
        public static void JugarPartido(int nroFecha)
        {

        }

        public static void CargarEquipos()
        {

        }
        public static void CargarPartidos()
        {

        }

    }
}
