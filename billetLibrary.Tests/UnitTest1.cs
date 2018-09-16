using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace billetLibrary.Tests
{
    [TestClass]
    public class UnitTest1
    {
        Bil b = new Bil();

        [TestMethod]
        public void TestPris()
        {
            Assert.AreEqual(240, b.Pris());
        }

        [TestMethod]
        public void TestKøretøj()
        {
            Assert.AreEqual("Bil", b.Køretøj());
        }
    }
}
