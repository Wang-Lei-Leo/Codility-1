using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FrogJump.Test
{
    [TestClass]
    public class JumpTester
    {
        [TestMethod]
        public void TestMethod1()
        {
            int numberOfJumps = Jumper.Jump(startPos: 10, endPos: 85, jumpDistance: 30);
            Assert.AreEqual(numberOfJumps, 3);
        }
    }
}
