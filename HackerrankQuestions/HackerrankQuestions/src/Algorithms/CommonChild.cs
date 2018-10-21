using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.Algorithms
{
    class CommonChild
    {
        public static int commonChild(string s1, string s2)
        {
            

            //Cutting out non matching letters from both strings
          

            int Row = s1.Length;
            int Column = s2.Length;
            int[][] subLen = new int[Row+1][];

            //Create 2d Array
            for (int i = 0; i < Row +1 ; i++)
            {
                subLen[i] = new int[Column +1 ];
            }
         



            //Starting from bottom right corner, if 





            for (int row = Row-1; row >=0; row--)
            {
                for (int column = Column - 1; column >=0; column--)
                {
                    subLen[row][column] = subLen[row][column] + subLen[row + 1][column + 1];
                    if (s1[row] == s2[column])
                    {
                       
                        Console.WriteLine("Matching Character");
                        Console.WriteLine("s1 value: " + s1[row] +  " s2 value: " + s2[column]);
                        subLen[row][column] = subLen[row][column] + 1;
                    }
                   
                       
                    
                    
                
                        if (subLen[row][column]> subLen[row][column + 1] && subLen[row][column] > subLen[row+1][column])
                        {
                        Console.WriteLine("Current Largest Value");
                        }
                        else if(subLen[row][column] < subLen[row][column + 1] && subLen[row][column] >= subLen[row + 1][column])
                        {
                        Console.WriteLine("Rigth Largest Value");
                        subLen[row][column] = subLen[row][column + 1];
                        }
                        else if(subLen[row][column] < subLen[row + 1][column] && subLen[row][column] >= subLen[row ][column+1])
                        {
                            Console.WriteLine("Down Largest Value");
                            subLen[row][column] = subLen[row+1][column];
                        }
                        else if (subLen[row][column] < subLen[row + 1][column] && subLen[row][column] < subLen[row][column + 1])
                         {
                        if (subLen[row][column + 1] < subLen[row + 1][column])
                        {
                            subLen[row][column] = subLen[row + 1][column];
                        }
                        else if (subLen[row][column + 1] >= subLen[row + 1][column])
                        {
                            subLen[row][column] = subLen[row][column + 1];
                        }
                    }
                  
                }

            }

            Console.Write( "  ");

            for (int i = 0; i < s2.Length; i++)
            {

                Console.Write(s2[i] + "  ");
            }
            Console.WriteLine("");

            for (int i = 0; i <Row ; i++)
            {
                Console.Write(s1[i] + " ");
                for (int j= 0; j < Column; j++)
                {
                    if (subLen[i][j] <10)
                    {
                        Console.Write(subLen[i][j] + "  ");
                    }
                    else
                    {
                        Console.Write(subLen[i][j] + " ");
                    }
                   
                }
                Console.WriteLine("");
            }

            if (s1.Length>0 && s2.Length >0)
            {
                return subLen[0][0];
            }
            else
            {
                return 0;
            }
        }
    }
}
