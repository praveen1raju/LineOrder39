using System;
using NUnit.Framework;

namespace NUnitTestProject1
{
    [TestFixture]
    public class NUnitTest1
    {
        [Test]
        [TestFixtureSetUp]
        public void TestMethod1()
        {
            Assert.AreEqual("a", "a");            
            
        }
    }
}