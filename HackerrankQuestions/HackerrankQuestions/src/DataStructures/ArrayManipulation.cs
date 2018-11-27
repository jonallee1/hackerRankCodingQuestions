using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.DataStructures
{
    class ArrayManipulation
    {
        static long arrayManipulation(int n, int[][] queries)
        {
            long[] arr = new long[n];

            for (int i = 0; i < queries.GetLength(0); i++)
            {
                arr[queries[i][0] - 1] = arr[queries[i][0] - 1] + queries[i][2];
                if (queries[i][1]<n)
                {
                    arr[queries[i][1]] = arr[queries[i][1]] - queries[i][2];
                }
                


            }
            long max = 0;
            long val = 0;
            for (int i = 0; i < n; i++)
            {
                val = val + arr[i];
                arr[i] = val;
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;

        }

    }
}
