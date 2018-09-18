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
        public void TestBilK�ret�j()
        {
            //arrange
            Bil b2 = new Bil();

            //act
            string result = b2.K�ret�j();

            //assert
            Assert.AreEqual("Bil", result);
        }
    }
}
