using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Dispositivo
    {
        private static List<Aplicacion> aplicacionesInstaladas;
        private static SistemaOperativo sistemaOperativo;

        static Dispositivo()
        {
            aplicacionesInstaladas = new List<Aplicacion>();
            sistemaOperativo = SistemaOperativo.ANDROID;
        }
        public static bool InstalarApp(Aplicacion app)
        {
            bool rta = false;
            if (app.SistemaOperativo == sistemaOperativo && aplicacionesInstaladas != app)
            {
                aplicacionesInstaladas.Add(app);
                rta = true;
            }
            return rta;
        }
        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Sistema operativo: {sistemaOperativo}");

            foreach (Aplicacion item in aplicacionesInstaladas)
            {
                sb.AppendLine(item.ObtenerInformacion());
            }
            return sb.ToString();

        }
    }
}
