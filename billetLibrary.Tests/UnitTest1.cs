using System;
using System.Text.RegularExpressions;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace billetLibrary.Tests
{
    [TestClass]
    public class UnitTest1
    {
        Bil bil = new Bil("2222111" , DateTime.Now);
        MC mc = new MC("3355222", DateTime.Now);

        [TestMethod]
        public void TestPris()
        {
            Assert.AreEqual(240, bil.Pris());
        }

        [TestMethod]
        public void TestK�ret�j()
        {
            Assert.AreEqual("Bil", bil.K�ret�jstype());
        }

        [TestMethod]
        public void TestMCPris()
        {
            Assert.AreEqual(125, mc.Pris());
        }

        [TestMethod]
        public void TestK�ret�jstypeMc()
        {
            Assert.AreEqual("MC", mc.K�ret�jstype());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestK�ret�jNummerpladel�ngde()
        {
            var b = new Bil("AZ512252", DateTime.Now);

            b.Nummerpladel�ngde();

            Assert.Fail();
        }
    }
}
