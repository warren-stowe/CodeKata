using CodeKata.Class;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKataTests
{
    [TestClass]
    public class CheckForTriangleTests
    {
        [TestMethod]
        public void IsTriangleTest()
        {
            int firstSide = 4, secondSide = 5, thirdSide = 6;

            bool result1 = CheckForTriangle.IsTriangle(firstSide, secondSide, thirdSide);

            Assert.IsTrue(result1);
        }
    }
}
