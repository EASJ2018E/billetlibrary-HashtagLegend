using System;
using System.Text.RegularExpressions;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace billetLibrary.Tests
{
    [TestClass]
    public class UnitTest1
    {
        Bil b = new Bil("2222111" , DateTime.Now);
        MC m = new MC("3355222", DateTime.Now);

        [TestMethod]
        public void TestPris()
        {
            Assert.AreEqual(240, b.Pris());
        }

        [TestMethod]
        public void TestKøretøj()
        {
            Assert.AreEqual("Bil", b.Køretøjstype());
        }

        [TestMethod]
        public void TestMCPris()
        {
            Assert.AreEqual(125, m.Pris());
        }

        [TestMethod]
        public void TestKøretøjstypeMc()
        {
            Assert.AreEqual("MC", m.Køretøjstype());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestKøretøjNummerpladelængde()
        {
            var b = new Bil("AZ512252", DateTime.Now);

            b.Nummerpladelængde();

            Assert.Fail();
        }
    }
}
