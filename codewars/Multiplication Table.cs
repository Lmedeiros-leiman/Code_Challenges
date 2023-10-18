// https://www.codewars.com/kata/534d2f5b5371ecf8d2000a08/train/csharp


using System;
using System.Linq;

namespace Solution
{
    class Solution
    {
        public static int[,] MultiplicationTable(int size)
        {

            int[,] result = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int m = 0; m < size; m++)
                {
                    result[i, m] = (i + 1) * (m + 1);
                }
            }


            return result;
        }
    }
}