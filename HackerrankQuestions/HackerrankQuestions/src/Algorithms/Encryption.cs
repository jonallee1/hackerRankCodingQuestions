using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.Algorithms
{
    class Encryption
    {
        public string encryption(string s)
        {
            String enc = "";
            int L;
            foreach (char c in s)
            {
                if (c == ' ')
                { 

                }
                else
                {
                    enc = enc + c;
                }
                

            }
            L = enc.Length;
            double rootL = Math.Sqrt(L);
            double ceiling = Math.Ceiling(rootL);
            double floor = Math.Floor(rootL);

            Console.WriteLine("Root of L: " + rootL + "Ceiling: " + ceiling + "Floor: " + floor);

            int column = 0;
            int row = 0;

            if (L > ceiling * floor )
            {
                column = Convert.ToInt32(ceiling);
                row = Convert.ToInt32(ceiling);
            }
            else if (L > floor * floor && L <= floor * ceiling)
            {
                column = Convert.ToInt32(ceiling);
                row = Convert.ToInt32(floor);
            }
            else
            {
                column = Convert.ToInt32(floor);
                row = Convert.ToInt32(floor);
            }

            String output = "";
            int count = 0;
            int index = 0;
            int numberreset = 0;
            
            for (int i = 0; i < row*column; i++)
            {

               
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Index: " + index);

                if (i == 0)
                {
                    output = output + enc[index];
                    index = index + column;
                }
                

                else if (index < L-1)
                {
                    output = output + enc[index];
                    index = index + column;
                }

                else if (index == L-1)
                {

                    Console.WriteLine("---------------------------------");
                    output = output + enc[index];
                    numberreset = numberreset + 1;
                    index = numberreset;
                   
                }
                else
                {
                    if (count == 0)
                    {
                        index = numberreset;
                        output = output + enc[index];
                        index = index + column;
                    }
                    
                    else 
                    {
                        output = output + " ";
                        count = -1;
                        
                        index = numberreset;
                        numberreset = numberreset + 1;
                    }
                    
                   
                }
                count++;
                Console.WriteLine("Count: " + count);



                if (count == row)
                {
                    output = output + " ";
                    count = 0;
                    numberreset = numberreset + 1;
                    Console.WriteLine("output: " + output);

                }

               
                
                 
                
            }

            Console.WriteLine("Output: " + output );
            Console.WriteLine("Columns: " + column + "rows: " + row);
            return output;

        }


    }
}
