using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #region propiedades
        public float Duracion { get {return this.duracion; } }
        public string NroOrigen { get { return this.nroOrigen; } }
        public string NroDestino { get { return this.nroDestino; } }

        #endregion

        public Llamada(float duracion ,  string nroDestino , string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public static int OrdenarPorDuracion(Llamada llamada1 , Llamada llamada2)
        {
            if(llamada1.duracion > llamada2.duracion)
            {
                return 1;
            }
            else
            {
                return -1; 
            }
        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"Numero de origen {nroOrigen}");
            sb.AppendLine($"Numero de destino {nroDestino}");
            sb.Append($"Duracion {duracion}");

            return sb.ToString();
        }

        public enum TipoLlamada
        {
            Local , Provincial, Todas
        }
    }
}
