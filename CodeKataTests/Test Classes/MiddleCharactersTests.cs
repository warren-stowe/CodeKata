using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeKata.Class;

namespace CodeKataTests.Test_Classes
{
    [TestClass]
    public class MiddleCharactersTests
    {

        [TestMethod]
        public void GetMiddleCharactersTest()
        {
            string testEven = "Middle";
            string testOdd = "Fifth";

            string result1 = MiddleCharacters.GetMiddleCharacters(testEven);
            string result2 = MiddleCharacters.GetMiddleCharacters(testOdd);

            Assert.AreEqual("dd", result1);
            Assert.AreEqual("f", result2);
        }
    }
}
