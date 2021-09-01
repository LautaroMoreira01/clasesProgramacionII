using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }
        public Estante(int capacidad , int ubicacioEstante) : this(capacidad)
        {
            
            this.ubicacionEstante = ubicacioEstante;
        }
        
        public Producto[] GetProductos()
        {
            return productos;
        }
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Productos en el estante: {e.productos.Length}");
            sb.AppendLine("PRODUCTOS:");

            foreach (Producto p in e.productos)
            { 
                if(p is not null)
                { 
                    sb.Append(Producto.MostrarProducto(p));
                }
            }

            return sb.ToString();
        }

        public static bool operator ==( Estante e,Producto p )
        {
            bool rta = false;

            foreach(Producto item in e.productos)
            {
                if(item is not null)
                {
                    if (item == p)
                    {
                        rta = true;
                    }
                }
                
            }
            return rta;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }
        public static bool operator +(Estante e, Producto p)
        {
            bool rta = false;

            if(e != p)
            {

                for(int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] is null)
                    {
                        rta = true;
                        e.productos[i] = p;
                        break;
                    }
                }
            }

            return rta;
        }
        public static Estante operator -(Estante e, Producto p)
        {
           
            if(e == p)
            {

                for(int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i].Equals(p) )
                    {
                        e.productos[i] = null;
                        break;
                    }
                }
            }
            return e;
        }



    }
}
