using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Local : Llamada
    {
        protected float costo;

        public float CostoLlamada { get { return CalcularCosto(); } }

        public Local(Llamada llamada, float costo) 
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(string origen , float duracion , string destino , float costo)
            :this( new Llamada(duracion,destino, origen) , costo)
        {
        }
        private float CalcularCosto()
        {
            return duracion * costo;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.Append(CostoLlamada);
            return sb.ToString();

        }
    }
}
