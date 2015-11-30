using System;
using NUnit.Framework;
using ConsoleApplication1;
namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestFailsIfInputIsEmpty()
        {
            Program p = new Program();
            Assert.AreEqual(p.returnOrderData(null), "input is empty");
        }
    }
}
