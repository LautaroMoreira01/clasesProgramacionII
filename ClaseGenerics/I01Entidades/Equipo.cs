using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01Entidades
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public Equipo(string nombre , DateTime fecha)
        {
            this.Nombre = nombre;   
            fechaCreacion = fecha;   
        }
        public string Nombre { get { return nombre; } set { nombre = value; } }

        public static bool operator ==(Equipo e1 , Equipo e2)
        {
            bool rta = false;
            if(e1.Nombre == e2.Nombre && e1.fechaCreacion == e2.fechaCreacion)
            {
                rta = true;
            }
            return rta;
        }
        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2); 
        }

        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"[{Nombre}] fundado el [{fechaCreacion.ToShortDateString()}]");
            return sb.ToString();
        }
    }
}
