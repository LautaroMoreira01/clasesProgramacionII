using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IO
{
    
    public class PuntoXml<T> : Archivo , IArchivo<T>
    {
        protected override string Extension
        {
            get { return "xml"; }
        }

        public void Guardar(string ruta, T contenido)
        {
            try
            {
                if (File.Exists(ruta))
                {
                    using (StreamWriter streamWriter = new StreamWriter(ruta))
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                        xmlSerializer.Serialize(streamWriter, contenido);
                    }

                }
            }
            catch (ArchivoIncorrectoException ex)
            {

                throw ex;

            }
        }
        public void GuardarComo(string ruta, T contenido)
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

        public T Leer<T>(string ruta) where T : class
        {
            try
            {
                if (File.Exists(ruta))
                {
                    using (StreamReader streamReader = new StreamReader(ruta))
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                        T objeto = xmlSerializer.Deserialize(streamReader) as T;
                        return objeto;
                    }
                }
                return default(T);
            }
            catch (ArchivoIncorrectoException ex)
            {

                throw ex;

            }
            
        }
    }
}
