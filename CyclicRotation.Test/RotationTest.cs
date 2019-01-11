using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CyclicRotation.Test
{

    [TestClass]
    public class RotationTest
    {
        [TestMethod]
        public void TestRightRotation()
        {

            int[] A = { 3, 8, 9, 7, 6 };
            A = Rotate.RotateRight(A, 2);
            // [ 7, 6, 3, 8, 9]
            Assert.AreEqual(A[0], 7);
            Assert.AreEqual(A[1], 6);
            Assert.AreEqual(A[2], 3);
            Assert.AreEqual(A[3], 8);
            Assert.AreEqual(A[4], 9);
        }

        [TestMethod]
        public void TestRightRotationSingleElement()
        {
            int[] A = { 8 };
            A = Rotate.RotateRight(A, 2);
            // [ 7, 6, 3, 8, 9]
            Assert.AreEqual(A[0], 8);
        }

        [TestMethod]
        public void TestLeftRotation()
        {

            int[] A = { 3, 8, 9, 7, 6 };
            A = Rotate.RotateLeft(A, 2);
            // [ 9, 7, 6, 3, 8]
            Assert.AreEqual(A[0], 9);
            Assert.AreEqual(A[1], 7);
            Assert.AreEqual(A[2], 6);
            Assert.AreEqual(A[3], 3);
            Assert.AreEqual(A[4], 8);
        }
    }
}
