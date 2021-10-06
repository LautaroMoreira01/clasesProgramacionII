using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClaseMetodosDeExtencion;

namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void FizzBuzz_CuandoNumeroEsDivisiblePorTresYCinco_DeberiaRetornarFizzBuzz()
        {
            //Arrange
            int numero = 30;
            string expected = "FizzBuzz";
            //Act

            string acutal = numero.FizzBuzz();
            
            //Assert

            Assert.AreEqual(expected, acutal);
        }
        [TestMethod]
        public void FizzBuzz_CuandoNumeroEsDivisiblePorTres_DeberiaRetornarFizz()
        {
            //Arrange
            int numero = 6;
            string expected = "Fizz";
            //Act

            string acutal = numero.FizzBuzz();
            
            //Assert

            Assert.AreEqual(expected, acutal);
        }
        public void FizzBuzz_CuandoNumeroEsDivisiblePorCinco_DeberiaRetornarBuzz()
        {
            //Arrange
            int numero = 15;
            string expected = "Buzz";
            //Act

            string acutal = numero.FizzBuzz();
            
            //Assert

            Assert.AreEqual(expected, acutal);
        }
        public void FizzBuzz_CuandoNumeroNoEsDivisiblePorTresNiCinco_DeberiaElNumero()

        {
            //Arrange
            int numero = 18;
            string expected = numero.ToString();
            //Act

            string actual = numero.FizzBuzz();
            
            //Assert

            Assert.AreEqual(expected, actual);
        }
    }
}
