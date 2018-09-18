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
            Bil b1 = new Bil();

            //act
            double result = b1.Pris();

            //assert
            Assert.AreEqual(240, result);
        }

        [TestMethod]
        public void TestBilKøretøj()
        {
            //arrange
            Bil b2 = new Bil();

            //act
            string result = b2.Køretøj();

            //assert
            Assert.AreEqual("Bil", result);
        }
    }
}
