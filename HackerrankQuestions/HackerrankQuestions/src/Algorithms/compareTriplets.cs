using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.Algorithms
{
    class compareTriplets
    {
        static List<int> compareTripletsFunc(List<int> a, List<int> b)//runtime O(n)
        {

            List<int> output = new List<int>()
        {
            0,
            0
        };


            for (int i = 0; i < 3; i++)
            {
                if (a[i] < b[i])
                {
                    output[1] = output[1] + 1;
                }
                else if (a[i] == b[i])
                {

                }
                else
                {
                    output[0] = output[0] + 1;
                }
            }

            return output;
        }

       


    }
}
