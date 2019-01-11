using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OddOccurrencesInArray.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] A = { 9, 3, 9, 3, 9, 7, 9 };
            int result = OddOccurrenceFinder.Find(A);
            Assert.IsTrue(result == 7);

            A = new int[7] { 0, 1, 0, 1, 3, 2, 2 };
            result = OddOccurrenceFinder.Find(A);
            Assert.IsTrue(result == 3);

            A = new int[0] { };
            result = OddOccurrenceFinder.Find(A);
            Assert.IsTrue(result == 0);

            A = new int[1] { 5 };
            result = OddOccurrenceFinder.Find(A);
            Assert.IsTrue(result == 5);
        }
    }
}
