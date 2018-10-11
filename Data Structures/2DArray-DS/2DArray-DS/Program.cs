using System;

namespace _2DArray_DS
{
    class Program
    {
        // Complete the hourglassSum function below.
        static int hourglassSum(int[][] arr)
        {
            int max = 0;
            bool firstvalue = true;
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j<5; j++)
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

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
