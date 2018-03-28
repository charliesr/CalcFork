using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcFork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcFork.Tests
{
    [TestClass()]
    public class CalculadoraTests
    {
        ICalculadora iCalculdora = new Calculadora();

        [TestMethod()]
        public void SumaTest()
        {
            Assert.IsFalse(iCalculdora.Suma(2, 7) == 10);
        }

        [TestMethod()]
        public void RestaTest()
        {
            Assert.IsFalse(iCalculdora.Resta(5, 4) == 5);
            Assert.IsTrue(iCalculdora.Resta(5, 5) == 0);
        }
    }
}