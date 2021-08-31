using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }


        public void SetNotaPrimerParcial(int nota)
        {
            if(nota >= 0)
            {
                notaPrimerParcial = nota;
            }
        }
        public void SetNotaSegundoParcial(int nota)
        {
            if (nota >= 0)
            {
                notaSegundoParcial = nota;
            }
        }

        private float CalcularPromedio()
        {
            float promedio;

            promedio = (float)(notaPrimerParcial + notaSegundoParcial) / 2;

            return promedio;
        }
        
        public double CalcularNotaFinal()
        {
            double rta = -1;

            if(notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                rta = random.Next(6, 10);
            
            }
            return rta;
        }

        public string Mostrar()
        {
            double notaFinal;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{nombre:10} {apellido:10} {legajo:5}");
            sb.AppendLine($"Nota primer parcial: {notaPrimerParcial}");
            sb.AppendLine($"Nota segundo parcial: {notaSegundoParcial}");
            sb.AppendLine($"Nota Promedio: {CalcularPromedio()}");

            notaFinal = CalcularNotaFinal();

            if(notaFinal != -1)
            {
                sb.AppendLine($"Nota final: {notaFinal}");

            }
            else
            {
                sb.AppendLine($"Nota final: Alumno desaprobado");
            }

            return sb.ToString();

        }
    }
}
