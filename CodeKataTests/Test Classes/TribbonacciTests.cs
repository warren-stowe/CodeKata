using CodeKata.Class;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;


namespace CodeKataTests
{
    [TestClass]
    public class TribbonacciTests
    {

        [TestMethod]
        public void GetTribWithPositiveNumbers()
        {
            int[] array1 = { 1, 1, 1 };
            int target1 = 7;
            int expected1 = 17;
            int result1 = Tribbonacci.GetTrib(array1, target1);

            int[] array2 = { 1, 2, 3 };
            int target2 = 5;
            int expected2 = 11;
            int result2 = Tribbonacci.GetTrib(array2, target2);

            int[] array3 = { 5, 10, 15 };
            int target3 = 6;
            int expected3 = 100;
            int result3 = Tribbonacci.GetTrib(array3, target3);

            Assert.AreEqual(expected1, result1);
            Assert.AreEqual(expected2, result2);
            Assert.AreEqual(expected3, result3);
        }

        [TestMethod]
        public void GetTribNegativeNumbers()
        {
            int[] array1 = { -1, -2, -3 };
            int result1 = Tribbonacci.GetTrib(array1, 5);

            int[] array2 = { 0, 2, -3 };
            int result2 = Tribbonacci.GetTrib(array2, 5);

            Assert.AreEqual(-1, result1);
            Assert.AreEqual(-1, result2);
        }

        [TestMethod]
        public void GetTribCheckInvalidDesiredNumber()
        {
            int[] array = { 1, 2, 3};
            int number1 = -1;
            int number2 = 0;
            int number3 = 3;

            Assert.AreEqual(-1, Tribbonacci.GetTrib(array, number1));
            Assert.AreEqual(-1, Tribbonacci.GetTrib(array, number2));
            Assert.AreEqual(-1, Tribbonacci.GetTrib(array, number3));
        }


    }
}
