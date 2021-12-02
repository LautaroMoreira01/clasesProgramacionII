using System;

namespace Persona
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;


        public Persona(int id, string nombre, string apellido)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public Persona(string nombre, string apellido) : this ( 0 , nombre , apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }


    }
}
