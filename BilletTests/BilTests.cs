using System;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletTests
{
    [TestClass]
    public class BilTests
    {
        [TestMethod]
        public void TestBilPris()
        {
            //arrange
            Bil b1 = new Bil("aa12345",DateTime.Now, true);

            //act
            double result = b1.Pris();

            //assert
            Assert.AreEqual(228, result);
        }

        [TestMethod]
        public void TestBilKøretøj()
        {
            //arrange
            Bil b2 = new Bil("aa12345", DateTime.Now, true);

            //act
            string result = b2.Køretøjet();

            //assert
            Assert.AreEqual("Bil", result);
        }

        [TestMethod]
        public void TestMCPris()
        {
            //arrange
            MC mc = new MC("aa12345", DateTime.Now, false);

            //act
            double result = mc.Pris();

            //assert
            Assert.AreEqual(125, result);
        }

        [TestMethod]
        public void TestMCKøretøj()
        {
            //arrange
            MC mc = new MC("aa12345", DateTime.Now, false);

            //act
            string result = mc.Køretøjet();

            //assert
            Assert.AreEqual("MC", result);
        }
    }
}
