using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;
        private float promedioGoles;

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles) : this(dni, nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }

        private Jugador()
        {
            dni = 0;
            partidosJugados = 0;
            promedioGoles = 0;
            totalGoles = 0;
        }

        public float GetPromedioGoles()
        {
            return (float)totalGoles / partidosJugados;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Dni: {dni}");
            sb.AppendLine($"Partidos jugados: {partidosJugados}");
            sb.AppendLine($"Goles totales: {totalGoles}");
            sb.AppendLine($"Goles promedio: {GetPromedioGoles()}");

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1 , Jugador j2)
        {
            return j1.dni == j2.dni;
        }
        public static bool operator !=(Jugador j1 , Jugador j2)
        {
            return ! (j1 == j2);
        }
    }
}
