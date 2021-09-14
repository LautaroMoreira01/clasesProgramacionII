using System;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(string nombre, int numero) : this(numero)
        { 
            this.nombre = nombre;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Numero { get; }

        public static bool operator ==(Cliente c1 , Cliente c2)
        {
            if (c1 is not null && c2 is not null && (c1.numero == c2.numero))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

    }
}
