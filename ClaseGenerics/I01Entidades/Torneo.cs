using System;
using System.Collections.Generic;
using System.Text;

namespace I01Entidades
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;
        private Random random = new Random();

        private Torneo()
        {
            equipos = new List<T>();
        }
        public Torneo(string nombre ) : this()  
        {
            this.nombre = nombre;   
        }
        public static bool operator ==(Torneo<T> torneo ,T equipo)
        {
            bool rta = false;
            foreach(Equipo item in torneo.equipos)
            {
                if (item == equipo)
                {
                    rta = true;
                }    
            }
            return rta;
        }
        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }
        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
           
            if(torneo != equipo)
            {
                torneo.equipos.Add(equipo);
            }

            return torneo;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Cantidad de equipos: {equipos.Count}");
            sb.AppendLine("EQUIPOS");
            foreach (T item in equipos)
            {
                sb.AppendLine($"{item.Ficha()}");
            }

            return sb.ToString();  
        }
        private string CalcularPartido(T equipo1, T equipo2)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"[{equipo1.Nombre}][{random.Next(0 , 10)}] - [{random.Next(0, 10)}][{equipo2.Nombre}]");
            
            return sb.ToString();   
            
        }
        public string JugarPartido
        {
            get
            {
                T t1 = equipos[random.Next(0, equipos.Count - 1)];
                T t2 = equipos[random.Next(0, equipos.Count - 1)];
               
                while (t1 == t2)
                {
                    t2 = equipos[random.Next(0, equipos.Count - 1)];

                }

                return CalcularPartido(t1, t2);
            }
        }
         
    }
}
