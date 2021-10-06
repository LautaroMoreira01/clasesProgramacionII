using Microsoft.VisualStudio.TestTools.UnitTesting;
using I01Entidades;

namespace CalculadoraTests
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void Add_CuandoSeIngresanDosNumerosSeparadosPorComas_LaSumaDeEsosDosNumeros()
        {
            //Arrange
            int expected = 5;
            string numeros = "1,4";
            //Act
            int actual = calculadora.Add(numeros);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void Add_CuandoSeIngresaCantidadDeNumerosDesconocidosSeparadosPorSaltosDeLineaYComas_LaSumaDeEsosNumeros()
        {
            //Arrange
            int expected = 15;
            string numeros = "1\n4,1\n4\n5";
            //Act
            int actual = calculadora.Add(numeros);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void Add_CuandoSeIngresaCantidadDeNumerosDesconocidosSeparadosPorSaltosDeLinea_LaSumaDeEsosNumeros()
        {
            //Arrange
            int expected = 15;
            string numeros = "1\n4\n1\n4\n5";
            //Act
            int actual = calculadora.Add(numeros);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void Add_CuandoSeIngresaCantidadDeNumerosDesconocidosSeparadosPorDelimitadorPasadosEnElString_LaSumaDeEsosNumeros()
        {
            //Arrange
            int expected = 15;
            string numeros = "//;\n1;2";
            //Act
            int actual = calculadora.Add(numeros);
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
