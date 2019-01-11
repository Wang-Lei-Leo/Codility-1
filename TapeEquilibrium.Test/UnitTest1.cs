using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TapeEquilibrium.Test
{
    [TestClass]
    public class EquilizerTests
    {
        [TestMethod]
        public void DoubleSumZero()
        {
            int[] A = { -1000, 1000 };
            int result = Equilizer.FindMinDifference(A);
            Assert.AreEqual(result, 2000);
        }

        [TestMethod]
        public void ExampleOnTheSite()
        {
            int[] A = { 3, 1, 2, 4, 3 };
            int result = Equilizer.FindMinDifference(A);
            Assert.AreEqual(result, 1);
        }
    }
}
