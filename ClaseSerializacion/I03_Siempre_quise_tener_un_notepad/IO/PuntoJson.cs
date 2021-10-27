using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IO
{

    public class PuntoJson<T> : Archivo , IArchivo<T>
    {
        protected override string Extension
        {
            get { return "json"; }
        } 

        public void Guardar(string ruta, T contenido)
        {
            try
            {
                if (File.Exists(ruta))
                { 
                    JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
                    jsonSerializerOptions.WriteIndented = true;
        ​
                    string objetoJson = JsonSerializer.Serialize(contenido, jsonSerializerOptions);
        ​
                    File.WriteAllText(ruta, objetoJson);
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
                    Guardar(ruta , contenido);

                }

            }
            catch (ArchivoIncorrectoException ex)
            {
                throw;

            }
        }

        public T Leer(string ruta)
        {
            try
            {
                if (File.Exists(ruta))
                {
                    string objetoJson = File.ReadAllText(ruta);
        ​
                    T objeto = JsonSerializer.Deserialize<T>(objetoJson);
        ​
                    return objeto;

                }
                return default;

            }
            catch (ArchivoIncorrectoException ex)
            {

                throw ex;
            }
        }
    }
}
