using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PermMissingElem.Test
{
    [TestClass]
    public class MissingElementTester
    {
        //[2,3,4], n=4, totalSum =10, actualSum =9, diff =1
        //[1,2,3], n=4, totalSum =10, actualSum =6, diff =4
        //[2], n=2, totalSum =3, actualSum =2, diff =1
        //[1], n=2, totalSum =3, actualSum =1, diff =2          
        //[],  n =1, totalSum =1, actualSum =0, diff =1
        [TestMethod]
        public void TestFirstMissingElement()
        {
            int[] A = { 2,3,4};
            int result = MissingElementFinder.Find(A);
            Assert.AreEqual(result, 1);
        }
        [TestMethod]
        public void TestLastMissingElement()
        {
            int[] A = {1,2,3};
            int result = MissingElementFinder.Find(A);
            Assert.AreEqual(result, 4);
        }
        [TestMethod]
        public void TestMissingElementSingleElement()
        {
            int[] A = {2};
            int result = MissingElementFinder.Find(A);
            Assert.AreEqual(result, 1);

            int[] B = { 1 };
            result = MissingElementFinder.Find(B);
            Assert.AreEqual(result, 2);
        }
        
    }
}
