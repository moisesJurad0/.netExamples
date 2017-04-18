using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, null);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(servicio.Class1.ejemplo2());
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(servicio.Class1.ejemplo3());
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(servicio.Class1.ejemplo4(true));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsTrue(servicio.Class1.ejemplo5(true));
        }
    }
}