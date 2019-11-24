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
            cs.RegisterCandidate("Arnold", "Schartzeneger", DateTime.Today, "111111111111", "Stalone1");
            Candidate c = cs.FindCandidate("111111111111");
            cs.AddExam(DateTime.Now, 20, c);
            Assert.AreEqual(1, 1);
        }
    }
}
