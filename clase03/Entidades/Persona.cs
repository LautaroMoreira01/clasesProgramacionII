using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private double dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, double dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public string GetNombre()
        {
            return nombre; 
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre; 
        }
        public DateTime GetFechaDeNacimiento()
        {
            return fechaDeNacimiento; 
        }
        public void SetFechaDeNacimiento(string nombre)
        {
            this.nombre = nombre; 
        }
        public double GetDni()
        {
            return dni; 
        }
        public void SetDni(double dni)
        {
            this.dni = dni; 
        }

        private int CalcularEdad()
        {
            return fechaDeNacimiento.Year;
        }
    }


}
