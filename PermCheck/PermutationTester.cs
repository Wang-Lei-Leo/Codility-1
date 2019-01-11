using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PermCheck
{
    [TestClass]
    public class PermutationTester
    {
        [TestMethod]
        public void ZeroElements()
        {
            int[] A = { };
            int result = PermChecker.IsPermutation(A);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void OneElement()
        {
            int[] A = {1};
            int result = PermChecker.IsPermutation(A);
            Assert.AreEqual(result, 1);
            int[] B = {2};
            result = PermChecker.IsPermutation(B);
            Assert.AreEqual(result, 0);
        }
        [TestMethod]
        public void DoesNotStartWithOne()
        {
            int[] A = { 3,2 };
            int result = PermChecker.IsPermutation(A);
            Assert.AreEqual(result, 0);            
        }
        [TestMethod]
        public void RepeatedElements()
        {
            int[] A = { 10,9,8,7,7,6,5,4,3,2,1 };
            int result = PermChecker.IsPermutation(A);
            Assert.AreEqual(result, 0);
        }
    }
}
