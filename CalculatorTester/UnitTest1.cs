using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation cal;
        [TestInitialize]
        public void SetUp()
        {
            this.cal = new Calculation(3, -5);
        }
        [TestMethod]
        public void TestAddOperator()
        {
            Assert.AreEqual(cal.Execute("+"), -2);
        }
        [TestMethod]
        public void TestSubOperator()
        {
            Assert.AreEqual(cal.Execute("-"), 8);
        }
        [TestMethod]
        public void TestMulOperator()
        {
            Assert.AreEqual(cal.Execute("*"), -15);
        }
        [TestMethod]
        public void TestDivOperator()
        {
            Assert.AreEqual(cal.Execute("/"), 0);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            Calculation c = new Calculation(0, 0);
            c.Execute("/");
        }
    }
}
