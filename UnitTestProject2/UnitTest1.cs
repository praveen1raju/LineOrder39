using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInputEmpty()
        {
            Program p = new Program();
            bool result;
            Assert.AreEqual(p.returnOrderData(null, out result), "input is empty");
        }

        [TestMethod]
        public void TestInputProper()
        {
            Program p = new Program();
            bool res;
            string data = p.returnOrderData("012345678901234567890123456789012345678", out res);
            Assert.AreEqual(res, true);
        }

        [TestMethod]
        public void TestInputProperGT39()
        {
            Program p = new Program();
            bool res;
            string data = p.returnOrderData("0123456789012345678901234567890123456789", out res);
            Assert.AreEqual(res, true);
        }

        [TestMethod]
        public void TestInputImProperLT39()
        {
            Program p = new Program();
            bool res;
            string data = p.returnOrderData("0123456789012345678901234567890123", out res);
            Assert.AreEqual(res, false);
        }

        [TestMethod]
        public void TestInputImProperLineNoNonInt()
        {
            Program p = new Program();
            bool res;
            string data = p.returnOrderData("012L45678901234567890123456789012345678", out res);
            Assert.AreEqual(res, false);
        }

        [TestMethod]
        public void TestInputImProperQuantoNonInt()
        {
            Program p = new Program();
            bool res;
            string data = p.returnOrderData("0123456789012345678901234567L9012345678", out res);
            Assert.AreEqual(res, false);
        }

        [TestMethod]
        public void TestInputImProperPriceNonFloat()
        {
            Program p = new Program();
            bool res;
            string data = p.returnOrderData("0123456789012345678901234567L901234567L", out res);
            Assert.AreEqual(res, false);
        }

        [TestMethod]
        public void TestInputProperCodeLength10()
        {
            Program p = new Program();
            bool res;
            string data = p.returnOrderData("012345678901234567890123456789012345678", out res);
            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            OrderObject oo1 = new OrderObject();
            OrderObject oo = null;
            oo = (OrderObject)js.Deserialize(data, oo1.GetType());
            Assert.AreEqual(oo.Category.Length, 10);
        }

        [TestMethod]
        public void TestInputProperCatLength10()
        {
            Program p = new Program();
            bool res;
            string data = p.returnOrderData("012345678901234567890123456789012345678", out res);
            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            OrderObject oo1 = new OrderObject();
            OrderObject oo = null;
            oo = (OrderObject)js.Deserialize(data, oo1.GetType());
            Assert.AreEqual(oo.Code.Length, 10);
        }

        [TestMethod]
        public void TestInputProperCodeLength9()
        {
            Program p = new Program();
            bool res;
            string data = p.returnOrderData("0123456789012 4567890123456789012345678", out res);
            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            OrderObject oo1 = new OrderObject();
            OrderObject oo = null;
            oo = (OrderObject)js.Deserialize(data, oo1.GetType());
            Assert.AreEqual(oo.Category.Length, 10);
        }

        [TestMethod]
        public void TestInputProperCatLength9()
        {
            Program p = new Program();
            bool res;
            string data = p.returnOrderData("01234567890123 567890123456789012345678", out res);
            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            OrderObject oo1 = new OrderObject();
            OrderObject oo = null;
            oo = (OrderObject)js.Deserialize(data, oo1.GetType());
            Assert.AreEqual(oo.Code.Length, 10);
        }





    }
}
