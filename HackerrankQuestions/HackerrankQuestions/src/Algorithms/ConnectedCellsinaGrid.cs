using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.Algorithms
{
    class ConnectedCellsinaGrid
    {
        public static int checkSize(int[][] A, int x, int y, int maxHeight, int maxWidth)
        {

            if (x < 0 || x >= maxHeight || y < 0 || y >= maxWidth)
            {
                return 0;
            }
            if (A[x][y] != 1)
            {
                return 0;
            }
            A[x][y] = -1;
            int count = 1;
            count = count + checkSize(A, x + 1, y, maxHeight, maxWidth);
            count = count + checkSize(A, x + 1, y + 1, maxHeight, maxWidth);
            count = count + checkSize(A, x + 1, y - 1, maxHeight, maxWidth);
            count = count + checkSize(A, x, y + 1, maxHeight, maxWidth);
            count = count + checkSize(A, x, y - 1, maxHeight, maxWidth);
            count = count + checkSize(A, x - 1, y, maxHeight, maxWidth);
            count = count + checkSize(A, x - 1, y + 1, maxHeight, maxWidth);
            count = count + checkSize(A, x - 1, y - 1, maxHeight, maxWidth);


            return count;
        }
        // Complete the connectedCell function below.
        static int connectedCell(int[][] A, int Height, int Width)
        {
            int max = 0;
            int temp = 0;
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    temp = checkSize(A, i, j, Height, Width);
                    if (temp > max)
                    {
                        max = temp;
                    }

                }
            }

            return max;
        }


    }
}
