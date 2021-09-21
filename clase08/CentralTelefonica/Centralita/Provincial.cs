using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public Provincial(Franja miFranja, Llamada llamada)
            : base( llamada.Duracion , llamada.NroDestino , llamada.NroOrigen )
        {
            franjaHoraria = miFranja;
        }
        public Provincial(string origen , Franja miFranja , float duracion , string destino) 
            : this(miFranja , new Llamada(duracion, destino , origen))
        {}

        private float CalcularCosto()
        {
            if(franjaHoraria == Franja.Franja_1)
            {
                return duracion * (float)0.99;
            }
            else if (franjaHoraria == Franja.Franja_2)
            {
                return duracion * (float)1.25;
            }
            else
            {
                return duracion * (float)0.66;
            }
        }

        public float CostoLlamada { get {return CalcularCosto(); } }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.Append(CostoLlamada);
            return sb.ToString();
        }
        public enum Franja
        {
            Franja_1,Franja_2, Franja_3
        }
    }
}
