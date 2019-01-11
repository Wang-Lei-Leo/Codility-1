using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryGapFinder.Test
{
    [TestClass]
    public class BinaryGapFinderTester
    {
        [TestMethod]
        public void TestMethod1()
        {
            var finder = new BinaryGapFinder();
            int N = 0;
            int R = finder.GetMaxGap(N);
            Assert.IsTrue(R == 0);

            N = 9;
            R = finder.GetMaxGap(N);
            Assert.IsTrue(R == 2);

            N = 529;
            R = finder.GetMaxGap(N);
            Assert.IsTrue(R == 4);

            N = 20;
            R = finder.GetMaxGap(N);
            Assert.IsTrue(R == 1);

            N = 15;
            R = finder.GetMaxGap(N);
            Assert.IsTrue(R == 0);

            N = 32;
            R = finder.GetMaxGap(N);
            Assert.IsTrue(R == 0);

            N = 1041;
            R = finder.GetMaxGap(N);
            Assert.IsTrue(R == 5);
        }
    }
}
