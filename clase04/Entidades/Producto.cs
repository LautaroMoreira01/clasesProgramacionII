using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return marca;
        }
        public float GetPrecio()
        {
            return precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Marca: {p.marca}.");
            sb.AppendLine($"Codigo de barras: {p.codigoDeBarra}.");
            sb.AppendLine($"Precio: {p.precio}.");

            return sb.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p , Producto p2)
        {
            return (string)p == (string)p2;
        }
        public static bool operator !=(Producto p , Producto p2)
        {
            return !(p == p2);
        }
        public static bool operator ==(Producto p, string marca)
        {
            return p.marca == marca;
        }
        public static bool operator !=(Producto p, string marca)
        {
            return !( p == marca);
        }
    }
}
