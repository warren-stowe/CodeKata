using CodeKata.Class;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKataTests
{
    [TestClass]
    public class SumOfOddTriangleTests
    {
        [TestMethod]
        public void SumOfRow_ValidNumbers()
        {
            long input1 = 1;
            long input2 = 5;
            long input3 = 10;

            long result1 = SumOfOddTriangle.SumOfRow(input1);
            long result2 = SumOfOddTriangle.SumOfRow(input2);
            long result3 = SumOfOddTriangle.SumOfRow(input3);

            Assert.AreEqual(1, result1);
            Assert.AreEqual(125, result2);
            Assert.AreEqual(1000, result3);
        }

    }
}
