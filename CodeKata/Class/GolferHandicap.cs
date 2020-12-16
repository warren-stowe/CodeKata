using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKata.Class
{
    // This CodeKata receives a multi-dimensional array consisting of 2 items, a golfer's age and their handicap.  If the golfer is at least age 55
    // and has a handicap greater than 7, add "Senior" to an array variable, otherwise add "Open".  Return the array
    public class GolferHandicap
    {
        public string[] CheckHandicap(int[][] data)
        {
            string[] result = new string[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i][0] >= 55 && data[i][1] >= 7)
                {
                    result[i] = "Senior";
                }
                else
                {
                    result[i] = "Open";
                }
            }

            return result;
        }
    }
}
