using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.Algorithms
{
    class SherlockAndTheValidString
    {
        public static string isValid(string s)
        {
            int[] letterCount = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'a': letterCount[0] = letterCount[0] + 1; break;
                    case 'b': letterCount[1] = letterCount[1] + 1; break;
                    case 'c': letterCount[2] = letterCount[2] + 1; break;
                    case 'd': letterCount[3] = letterCount[3] + 1; break;
                    case 'e': letterCount[4] = letterCount[4] + 1; break;
                    case 'f': letterCount[5] = letterCount[5] + 1; break;
                    case 'g': letterCount[6] = letterCount[6] + 1; break;
                    case 'h': letterCount[7] = letterCount[7] + 1; break;
                    case 'i': letterCount[8] = letterCount[8] + 1; break;
                    case 'j': letterCount[9] = letterCount[9] + 1; break;
                    case 'k': letterCount[10] = letterCount[10] + 1; break;
                    case 'l': letterCount[11] = letterCount[11] + 1; break;
                    case 'm': letterCount[12] = letterCount[12] + 1; break;
                    case 'n': letterCount[13] = letterCount[13] + 1; break;
                    case 'o': letterCount[14] = letterCount[14] + 1; break;
                    case 'p': letterCount[15] = letterCount[15] + 1; break;
                    case 'q': letterCount[16] = letterCount[16] + 1; break;
                    case 'r': letterCount[17] = letterCount[17] + 1; break;
                    case 's': letterCount[18] = letterCount[18] + 1; break;
                    case 't': letterCount[19] = letterCount[19] + 1; break;
                    case 'u': letterCount[20] = letterCount[20] + 1; break;
                    case 'v': letterCount[21] = letterCount[21] + 1; break;
                    case 'w': letterCount[22] = letterCount[22] + 1; break;
                    case 'x': letterCount[23] = letterCount[23] + 1; break;
                    case 'y': letterCount[24] = letterCount[24] + 1; break;

                    case 'z': letterCount[25] = letterCount[25] + 1; break;
                    

                    default: return "not valid";
                }
            }
            Array.Sort(letterCount);
            for (int i= 0; i < 26; i++)
            {
                Console.Write(letterCount[i] + " ");
            }
            int firstIndex = -1;
            int firstChange = -1;
            int numChange = 0;
            int currentNum = 0;
            for (int i = 0; i < 26; i++)
            {
               
                if (letterCount[i] != 0 && firstIndex == -1)
                {
                    firstIndex = i;
                    currentNum = letterCount[i];
                }
                else if(letterCount[i] != 0){
                    if (currentNum != letterCount[i])
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine(currentNum);
                        Console.WriteLine("lettercount[i]" + letterCount[i]);
                        Console.WriteLine("----------------------------------------");
                        firstChange = i;
                        numChange = numChange + 1;
                        currentNum = letterCount[i];
                    }
                }
                if (numChange > 1)
                {
                    Console.WriteLine("Return 1");
                    Console.WriteLine("numChange: " + numChange);
                    return "NO";

                }

            }

            Console.WriteLine("numChange: " + numChange);
            Console.WriteLine("firstChange: " + firstChange);
            if (numChange == 0)
            {
                Console.WriteLine("Return 2");
                return "YES";
            }    
            else if (numChange == 1)
            {
                if (firstChange-firstIndex>1 && 25-firstChange > 1)
                {
                    Console.WriteLine("Return 3");
                    return "NO";
                }
                else if (firstChange - firstIndex == 1)
                {
                    if (letterCount[firstIndex] == 1 || letterCount[firstIndex] == letterCount[firstChange] + 1)
                    {
                        Console.WriteLine("Return 4");
                        return "YES";
                    }
                    else
                    {
                        Console.WriteLine("Return 5");
                        return "NO";
                    }
                }
                else if (25-firstChange == 0)
                {
                    if (letterCount[firstChange] == 1 || letterCount[firstChange] == letterCount[firstIndex] + 1)
                    {
                        Console.WriteLine("Return 6");
                        return "YES";
                    }
                    else
                    {
                        Console.WriteLine("Return 7");
                        return "NO";
                    }
                }
            }
            Console.WriteLine("Return 8");
            return "NO";
        }


    }
}
