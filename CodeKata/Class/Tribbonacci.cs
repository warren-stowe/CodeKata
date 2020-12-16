using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKata.Class
{
    public static class Tribbonacci
    {
        public static int GetTrib(int[] sequence, int number)
        {
            //TODO: Not sure which version of Tribbonacci this is solving.
            if (!Tribbonacci.CheckForNegatives(sequence) || number < 4)
            {
                return -1;
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(sequence[0]);
            queue.Enqueue(sequence[1]);
            queue.Enqueue(sequence[2]);

            int temp;
            int i = 4;
            int lastNumber = 0;

            Console.WriteLine(sequence[0]);
            Console.WriteLine(sequence[1]);
            Console.WriteLine(sequence[2]);

            while (i <= number)
            {
                temp = 0;

                foreach (int num in queue)
                {
                    temp += num;

                }

                Console.WriteLine(temp);
                lastNumber = temp;
                queue.Dequeue();
                queue.Enqueue(temp);
                i++;
            }

            return lastNumber;
        }

        public static bool CheckForNegatives(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
