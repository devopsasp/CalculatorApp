using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        CalculatorApp.Calculator obj = new CalculatorApp.Calculator();
        [TestMethod]
        public void TestMethod1()
        {
            int actual = obj.add(12, 11);
            int expected = 23;
            Assert.AreEqual(expected, actual);

        }
    }
}
