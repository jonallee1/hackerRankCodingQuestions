using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.Algorithms
{
    class TheGridSearch
    {
        public static string gridSearch(string[] G, string[] P)
        {
            int LargeGridRows = G.Length;
            int LargeGridColumns = 0;
            bool output = true;

            if (LargeGridRows > 0)
            {
                LargeGridColumns = G[0].Length;
            }

            int SmallGridRows = P.Length;
            int SmallGridColumns = 0;
            if (SmallGridRows > 0)
            {
                SmallGridColumns = P[0].Length;
            }

            for (int i = 0; i < LargeGridRows; i++)
            {
                Console.WriteLine(G[i]);
            }

            Console.WriteLine("");

            for (int i = 0; i < SmallGridRows; i++)
            {
                Console.WriteLine(P[i]);
            }

            Console.WriteLine(LargeGridColumns + " " + SmallGridColumns);

            for (int i = 0; i <= LargeGridRows - SmallGridRows; i++)
            {
                for (int j = 0; j <= LargeGridColumns - SmallGridColumns; j++)
                {
                    if (G[i][j] == P[0][0])
                    {
                        for (int x = 0; x < SmallGridRows; x++)
                        {
                            for (int y = 0; y < SmallGridColumns; y++)
                            {
                                if (G[i+x][j+y] != P[x][y])
                                {
                                    output = false;
                                    break;
                                }
                                if (x == SmallGridRows - 1 && y == SmallGridColumns - 1 && output == true )
                                {
                                    return "YES";
                                }
                            }
                            if (output == false)
                            {
                                break;
                            }
                        }
                    }
                    output = true;
                }
            }
            return "NO";
        }

    }
}
