using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AppMusical : Aplicacion

    {
        private List<string> listaCanciones;

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial, List<string> listaCanciones)
            : base(nombre, sistemaOperativo, tamanioInicial)
        {
            this.listaCanciones = listaCanciones;
        }
        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial)
            : this(nombre, sistemaOperativo, tamanioInicial , new List<string>())
        {

        }

        protected override int Tamanio
        {
            get
            {
                return this.tamanioMb + (listaCanciones.Count * 2);
            }
        }
        public override string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ObtenerInformacion());
            sb.AppendLine("--------------------------------------------------------");
            foreach (string item in listaCanciones)
            {
                sb.AppendLine(item);
            }

            return sb.ToString();
        }
    }
}
