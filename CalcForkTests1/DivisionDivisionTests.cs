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
    public class DivisionDivisionTests
    {
        [DataRow(10,2,5)]
        [DataRow(30,10,3)]
        [DataRow(40,10,4)]
        [TestMethod]
        public void CalDivisionDivisionTest(int num1,int num2, int resultado)
        {
            Division divisio = new Division();

            Assert.AreEqual(resultado, divisio.CalDivision(num1, num2));
        }
    }
}