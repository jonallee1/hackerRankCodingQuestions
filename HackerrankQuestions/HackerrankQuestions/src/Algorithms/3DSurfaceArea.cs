using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.Algorithms
{
    class _3DSurfaceArea
    {
        public int surfaceArea(int[][] A, int Height, int Width)
        {
            
            int price = 0;
            int[][] newA = new int[Height+2][ ];

            for (int i = 0; i < Height + 2; i++)
            {
                newA[i] = new int[Width + 2];
            }
            for (int i = 1; i < Height + 1; i++)
            {
                for (int j = 1; j < Width + 1; j++)
                {
                    newA[i][j] = A[i - 1][j - 1];
                }
            }

            for (int i = 0; i < Height + 2; i++)
            {
                for (int j = 0; j < Width + 2; j++)
                {
                    Console.Write(string.Format("{0} ", newA[i][ j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }


       

            for (int i = 1; i < Height+1; i++)
            {
                for (int j = 1; j < Width+1; j++)
                {
                    if (newA[i][ j] == 0)
                    {

                    }
                    else
                    {
                        price = price + 2;    
                        if(newA[i][ j] > newA[i-1][ j])
                        {
                            price = price + (newA[i][ j] - newA[i - 1][ j]);
                        }
                        if (newA[i][ j] > newA[i + 1][ j])
                        {
                            price = price + (newA[i][ j] - newA[i + 1][ j]);
                        }
                        if (newA[i][ j] > newA[i ][ j - 1])
                        {
                            price = price + (newA[i][ j] - newA[i][ j - 1]);
                        }
                        if (newA[i][ j] > newA[i][ j + 1])
                        {
                            price = price + (newA[i][ j] - newA[i][ j + 1]);
                        }
                    }




                }



            }

            Console.WriteLine("price: " + price);

            return price;

        }


    }
}
