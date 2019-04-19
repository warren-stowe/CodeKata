using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKata.Class
{
    public class CompareTriplets
    {
        static List<int> compareTriplets(List<int> a, List<int> b)
        {

            int herScore = 0;
            int hisScore = 0;

            int[] aliceArray = a.ToArray();
            int[] bobArray = b.ToArray();

            for (int i = 0; i < aliceArray.Length; i++)
            {
                if (aliceArray[i] > bobArray[i])
                {
                    herScore++;
                }

                if (bobArray[i] > aliceArray[i])
                {
                    hisScore++;
                }
            }

            List<int> result = new List<int>();

            result.Add(herScore);
            result.Add(hisScore);

            return result;


        }
    }
}
