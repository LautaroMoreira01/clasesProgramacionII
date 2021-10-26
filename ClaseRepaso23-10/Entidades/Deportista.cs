using System;

namespace Entidades
{
    public abstract class Deportista
    {
        private int cantidadPartidos;
        private int edad;
        private string nombreApellido;

        protected Deportista(string nombreApellido, int edad, int cantidadPartidos)
        {
            this.cantidadPartidos = cantidadPartidos;
            this.edad = edad;
            this.nombreApellido = nombreApellido;
        }

        public int CantidadPartidos 
        {
            get {return cantidadPartidos; }
            set { cantidadPartidos = value; } 
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string NombreApellido
        {
            get { return nombreApellido; }
            set { nombreApellido = value; }
        }
    }
}
