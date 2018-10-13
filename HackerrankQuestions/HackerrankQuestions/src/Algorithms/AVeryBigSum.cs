using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.Algorithms
{
    class AVeryBigSum
    {
        // Complete the aVeryBigSum function below.
        static long aVeryBigSum(long[] ar)
        {
            long output = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                output = output + ar[i];
            }
            return output;
        }

       

    }
}
