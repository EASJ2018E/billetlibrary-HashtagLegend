using System.Text.RegularExpressions;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace billetLibrary.Tests
{
    [TestClass]
    public class UnitTest1
    {
        Bil b = new Bil();
        MC m = new MC();

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

        [TestMethod]
        public void TestMCPris()
        {
            Assert.AreEqual(125, m.Pris());
        }

        [TestMethod]
        public void TestKøretøjMC()
        {
            Assert.AreEqual("MC", m.Køretøj());
        }
    }
}
