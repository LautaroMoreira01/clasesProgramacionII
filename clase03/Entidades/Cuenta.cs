using System;
using System.Text;

namespace Entidades
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular , decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return titular;
        }
        public decimal GetCantidad()
        {
            return cantidad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Titular: {titular}");
            sb.Append($"Cantidad: {cantidad}");

            return sb.ToString();
        }

        public void Ingresar(decimal cantidad)
        {
            if(cantidad > 0)
            {
                this.cantidad += cantidad;
            }
        }

        public void Retirar(decimal cantidad)
        {
            if (cantidad > 0)
            {
                this.cantidad -= cantidad;
            }
        }

    }
}
