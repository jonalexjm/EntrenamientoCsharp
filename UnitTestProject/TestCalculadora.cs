using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class TestCalculadora
    {
        [TestMethod]
        public void Test_Suma_correcta()
        {
            //Arrange: Inicializamos las variables
            int sumando1 = 2;
            int sumando2 = 5;

            //Act: ejecutamos el metodo a testear
            int resultado = CalculadoraEjemplo1.Suma(sumando1, sumando2);

            //Assert: comprobamos de los valores
            Assert.AreEqual(7, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_Excepcion()
        {
            //Arrange: Inicializamos las variables
            int dividendo = 6;
            int dividendo2 = 0;

            //Act: ejecutamos el metodo a testear
            double resultado = CalculadoraEjemplo1.Division(dividendo, dividendo2);

            //Assert: comprobamos de los valores
            Assert.AreEqual(7, resultado);
        }
    }
}
