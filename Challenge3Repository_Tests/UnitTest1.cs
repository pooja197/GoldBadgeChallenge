using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenge3;

namespace Challenge3Repository_Tests
{
    [TestClass]
    public class UnitTest1
    {
        private OutingsRepository _outingRepo;
        [TestMethod]
        public void TestMethod1()
        {
            Outings outings = new Outings();
            _outingRepo = new OutingsRepository();


            _outingRepo.AddProduct(outings);

            int expected = 1;
            int actual = _outingRepo.VeiwEvents().Count;

            Assert.AreEqual(expected, actual);
        }
    }
}
