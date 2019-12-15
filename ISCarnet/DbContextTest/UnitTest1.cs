using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataBaseLibrary;

namespace DbContextTest
{
    [TestClass]
    public class UnitTest1
    {
        private CandidateService cs = new CandidateService();
        [TestMethod]
        public void TestMethod1()
        {

            Assert.AreEqual(1, 1);
        }
    }
}
