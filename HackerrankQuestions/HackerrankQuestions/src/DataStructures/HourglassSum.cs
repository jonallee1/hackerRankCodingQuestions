
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.DataStructures
{
    class HourglassSum
    {
        static int hourglassSum(int[][] arr)
        {
            int max = 0;
            bool firstvalue = true;
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    int temp = arr[i - 1][j - 1] + arr[i - 1][j] + arr[i - 1][j + 1] + arr[i][j] + arr[i + 1][j - 1] + arr[i + 1][j] + arr[i + 1][j + 1];
                    if (firstvalue)
                    {
                        max = temp;
                        firstvalue = false;
                    }
                    else
                    {
                        if (temp > max)
                        {
                            max = temp;
                        }
                    }
                }
            }
            return max;

        }


    }




}

