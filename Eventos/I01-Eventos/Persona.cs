using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static I01_Eventos.Persona;

namespace I01_Eventos
{
    public delegate void DelegadoString(string msg);

    public class Persona
    {
        private string nombre;
        private string apellido;
        public DelegadoString delegadoString;
        public event DelegadoString notificarCambio;

        public string Nombre 
        { 
            get => nombre; 
        
            set
            {
                if(notificarCambio  is not null)
                {
                    notificarCambio.Invoke(value);
                }
                nombre = value;
            }
        }
        public string Apellido
        {
            get => apellido;
            set
            {
                if (notificarCambio is not null)
                {
                    notificarCambio.Invoke(value);
                }
                apellido = value;
            }
        }
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public string Mostrar()
        {
            return $"{nombre} {apellido}";
        }
    }
}
