using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FrogRiverOne
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MissingStep()
        {
            int[] A = { 2, 3 };
            int result = RiverCrossing.CrossRiverMinTime(2, A);
            Assert.AreEqual(result, -1);
        }
        [TestMethod]
        public void CompletedStep()
        {
            int[] A = { 2, 3, 1, 5, 4, 6};
            int result = RiverCrossing.CrossRiverMinTime(4, A);
            Assert.AreEqual(result, 4);
        }
        [TestMethod]
        public void CompletedStepOneStep()
        {
            int[] A = { 2, 1 };
            int result = RiverCrossing.CrossRiverMinTime(1, A);
            Assert.AreEqual(result, 1);
        }
    }
}
