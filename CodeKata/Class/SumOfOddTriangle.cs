using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKata.Class
{
    public static class SumOfOddTriangle
    {
        public static long SumOfRow(long n)
        {
            // Given a triangle as follows:
            //                        1
            //                    3       5
            //                7       9       11
            //            13      15      17      19
            //        21      23      25      27      29

            //Calculate the sum of a given row of long n.

            // The starting number is equal to n * (n-1) + 1, so create a variable at the starting number.
            // Add this number to the result variable.
            long start = (n * (n - 1)) + 1;
            long result = start;

            // There are also n number of numbers in the given row.  We have already calculated the first number,
            // so start a for loop at n - 1, iterating at i-- until it is no longer greater than 0.
            for (long i = n - 1; i > 0; i--)
            {
                // We are calculating odd numbers, so add 2 to the start variable, then add start to the result
                start += 2;
                result += start;
            }

            return result;
        }

    }
}
