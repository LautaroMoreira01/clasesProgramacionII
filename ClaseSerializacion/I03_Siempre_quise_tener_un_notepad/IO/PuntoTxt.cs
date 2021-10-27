using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class PuntoTxt : Archivo , IArchivo<string>
    {
        protected override string Extension
        {
            get { return "txt"; }
        }

        public void Guardar(string ruta, string contenido)
        {
            try
            {
                if (File.Exists(ruta))
                {
                    using (StreamWriter streamWriter = new StreamWriter(ruta))
                    {
                        streamWriter.WriteLine(contenido);
                    }

                }
            }
            catch (ArchivoIncorrectoException ex)
            {

                throw ex;

            }
        }

        public void GuardarComo(string ruta, string contenido)
        {
            try
            {
                if (ValidarExtension(ruta))
                {
                    Guardar(ruta, contenido);
                }
            }
            catch (ArchivoIncorrectoException ex)
            {
                throw ex;

            }
        }

        public string Leer(string ruta)
        {
            try
            {
                if (File.Exists(ruta))
                {
                    using (StreamReader streamReader = new StreamReader(ruta))
                    {
                        return streamReader.ReadToEnd();
                    }
                }
                return default(string);
            }
            catch (ArchivoIncorrectoException ex)
            {

                throw ex;

            }
        }
    }
}
