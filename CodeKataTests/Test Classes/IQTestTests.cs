using CodeKata.Class;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKataTests
{
    [TestClass]
    public class IQTestTests
    {
        [TestMethod]
        public void TestCorrectAnswers()
        {
            IQTest iqTest = new IQTest();

            string input1 = "2 4 5 6 8 10";
            string input2 = "1 5 3 11 17 4 21";
            string input3 = "2 4 6 7 8";

            int result1 = iqTest.CheckIQ(input1);
            int result2 = iqTest.CheckIQ(input2);
            int result3 = iqTest.CheckIQ(input3);

            Assert.AreEqual(3, result1);
            Assert.AreEqual(6, result2);
            Assert.AreEqual(4, result3);
        }
    }
}
