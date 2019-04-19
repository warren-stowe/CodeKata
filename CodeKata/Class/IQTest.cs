using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKata.Class
{
    //Bob is preparing to pass IQ test.The most frequent task in this test is to find out which one of the given numbers differs from the others. 
    //Bob observed that one number usually differs from the others in evenness.Help Bob — to check his answers, he needs a program that among the given 
    //numbers finds one that is different in evenness, and return a position of this number.

    //Keep in mind that your task is to help Bob solve a real IQ test, which means indexes of the elements start from 1 (not 0)
    // Example: numbers = "2 3 4 6".  This should return the int 2.  3 is the only odd number, and the result wants the index of the differing number
    // starting at a 1 index rather than 0 index.

    public class IQTest
    {
        public int CheckIQ(string numbers)
        {
            // Input is a string of numbers with a space between them, split the string by " " into an array of strings.
            string[] parsedNumbers = numbers.Split(" ");

            List<int> oddNumbers = new List<int>(); // List to hold all odd numbers
            List<int> evenNumbers = new List<int>(); // list to hold all even numbers

            // loop through the array of strings.  Parse the strings to ints and determine whether they are even or odd.  Add the INDEX to the appropriate list.
            for (int i = 0; i < parsedNumbers.Length; i++)
            {
                if (int.Parse(parsedNumbers[i]) % 2 == 0)
                {
                    evenNumbers.Add(i);
                }
                else
                {
                    oddNumbers.Add(i);
                }
            }

            // Check if evenNumbers consists of only 1 number.  If yes, return the number + 1
            if (evenNumbers.Count == 1)
            {
                return evenNumbers[0] + 1;
            }

            // Otherwise, return the value in oddNumbers + 1
            return oddNumbers[0] + 1;
        }
    }
}


