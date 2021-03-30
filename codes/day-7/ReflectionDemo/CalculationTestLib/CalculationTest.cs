using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReflectionDemo.Entities;

namespace CalculationTestLib
{
    //attribute
    [TestClass]
    public class CalculationTest
    {
        //attribute
        [TestMethod]
        public void AddTest()
        {
            Calculation calculation = new Calculation();
            calculation.Add(12, 13);
            int actualRes = calculation.AddResult;
            int expectedRes = 25;
            Assert.AreEqual(expectedRes, actualRes);
        }
        [TestMethod]
        public void SubTest()
        {
           // Calculation calculation = new Calculation();
            int actualRes = Calculation.Subtract(12, 3);           
            int expectedRes = 9;
            Assert.AreEqual(expectedRes, actualRes);
        }

        public void Foo() { }
    }
}
