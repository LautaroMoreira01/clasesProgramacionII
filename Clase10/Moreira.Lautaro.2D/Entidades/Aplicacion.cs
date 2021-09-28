using System;
using System.Text;
using System.Collections.Generic;

namespace Entidades
{
    public abstract class Aplicacion
    {
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMb;

        public SistemaOperativo SistemaOperativo { get { return sistemaOperativo; } }
        protected abstract int Tamanio { get; }

        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMb = tamanioMb;
        }

        public virtual string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Sistema operativo: {SistemaOperativo.ToString()}");
            sb.AppendLine($"Tamanio: {Tamanio}");

            return sb.ToString();
        }

        public static implicit operator Aplicacion(List<Aplicacion> listApp)
        {

            Aplicacion aplicacionConMasTamanio = null;
            //KeyValuePair<int, int> appConMasTamanio = new KeyValuePair<int, int>();

            foreach (Aplicacion item in listApp)
            {
                if (aplicacionConMasTamanio is null || aplicacionConMasTamanio.tamanioMb < item.tamanioMb)
                {
                    aplicacionConMasTamanio = item;
                }
            }
            return aplicacionConMasTamanio;
        }
        public override string ToString()
        {
            return nombre;
        }

        public static bool operator ==(List<Aplicacion> listApp, Aplicacion app)
        {
            bool esta = false;
            foreach (Aplicacion item in listApp)
            {
                if (item.nombre == app.nombre)
                {
                    esta = true;
                }
            }
            return esta;
        }
        public static bool operator !=(List<Aplicacion> listApp, Aplicacion app)
        {
            return !(listApp == app);

        }
        public static bool operator +(List<Aplicacion> listApp, Aplicacion app)
        {
            if (listApp != app)
            {
                listApp.Add(app);
                return true;
            }
            return false;
        }

    }
}
