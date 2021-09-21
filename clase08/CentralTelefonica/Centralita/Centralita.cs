using System;
using System.Collections.Generic;
using System.Text;

namespace CentralTelefonica
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;

        protected string razonSocial;

        public float GananciasPorLocal
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Local); } 
        }
        public float GananciasPorProvincial
        { 
            get { return CalcularGanancia(Llamada.TipoLlamada.Provincial); }
        }

        public float GananciasPorTotal
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Todas); }
        }
        public List<Llamada> Llamadas { get { return this.listaDeLlamadas; } }

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string NombreEmpresa) : this()
        {
            razonSocial = NombreEmpresa;
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float costoLocal = 0;
            float costoProvincial= 0;
            //float costoTotal= 0;
            foreach(Llamada item in listaDeLlamadas)
            {
                if(item is Local)
                {
                    costoLocal += ((Local)item).CostoLlamada;
                }
                else 
                {
                    costoProvincial += ((Provincial)item).CostoLlamada;
                }
            }

            if(tipo == Llamada.TipoLlamada.Local)
            {
                return costoLocal;
            
            }else if (tipo == Llamada.TipoLlamada.Provincial)
            {
                return costoProvincial;
            }
            else
            {
                return costoProvincial + costoLocal;

            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {razonSocial}");
            sb.AppendLine($"Cantidad de llamadas: {listaDeLlamadas.Count}");
            sb.AppendLine($"Ganancia por llamadas Totales: {GananciasPorTotal}");
            sb.AppendLine($"Ganancia por llamadas locales: {GananciasPorLocal}");
            sb.AppendLine($"Ganancia por llamadas provinciales: {GananciasPorProvincial}");
            sb.AppendLine("-------------------LLAMADAS-------------------");
            
            foreach(Llamada item in listaDeLlamadas)
            {
                if (item is not null)
                {
                    sb.AppendLine("--------------------------------");
                    if (item is Local)
                    {
                        sb.AppendLine(((Local)item).Mostrar());
                    }
                    else
                    {
                        sb.AppendLine(((Provincial)item).Mostrar());
                    }
        //           sb.AppendLine("--------------------------------");

                }
            }
            sb.AppendLine("-------------------FIN LLAMADAS-------------------");

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
