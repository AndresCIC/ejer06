using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejer06;
using System.Text;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            String correcto = "Texto" + 1 + 2;
            Logica sut = new Logica();
            Datos d = new Datos("Texto", 1, 2);
            String stringToTest = sut.Datos(d);

            Assert.AreEqual(correcto, stringToTest);

        }
    }
}
