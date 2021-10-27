using IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace IOTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidarExtensionJsonTestArchivoExiste()
        {
            //Arrange
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path = Path.Combine(path, "archivo.json");

            File.Create(path);

            bool expected = true;
            bool actual;

            PuntoJson<string> puntoJson = new PuntoJson<string>();
            //Act
            actual = puntoJson.ValidarExtension(path);
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ValidarExtensionXmlTestArchivoExiste()
        {
            //Arrange
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path = Path.Combine(path, "archivo.xml");
            
            File.Create(path);

            bool expected = true;
            bool actual;

            PuntoXml<string> puntoXml = new PuntoXml<string>();
            //Act
            actual = puntoXml.ValidarExtension(path);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidarExtensionTxt()
        {
            //Arrange
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path = Path.Combine(path, "archivo.txt");
            
            File.Create(path);

            bool expected = true;
            bool actual;

            PuntoTxt puntoTxt= new PuntoTxt();
            //Act
            actual = puntoTxt.ValidarExtension(path);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
