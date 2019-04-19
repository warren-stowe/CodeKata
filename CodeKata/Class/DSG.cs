using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKata.Class
{
    public class DSG
    {
        public string solution(string S, int K)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            string[] days = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

            int difference = K % 7;
            int startDay = 0;
            int currentDay = 0;

            for (int i = 0; i < days.Length; i++)
            {

                if (days[i].Equals(S))
                {
                    startDay = i;
                    currentDay = i;
                    break;
                }
            }

            currentDay += difference;

            if (currentDay > 7)
            {
                currentDay -= 6;
            }

            return days[currentDay];
        }
    }
}
