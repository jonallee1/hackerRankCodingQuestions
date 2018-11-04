using System;
using System.Collections.Generic;
using System.Text;
using static HackerrankQuestions.src.Algorithms.BiggerisGreater;

namespace HackerrankQuestions.src.Algorithms
{
    class BiggerisGreater
    {


     
        public static string biggerIsGreater(string w)
        {
            int[] numstring = new int[w.Length];
            for (int i = 0; i < w.Length; i++)
            {
                switch (w[i])
                {
                    case 'a':
                        numstring[i] = 1;
                        break;
                    case 'b':
                        numstring[i] = 2; break;
                    case 'c':
                        numstring[i] = 3; break;
                    case 'd':
                        numstring[i] = 4; break;
                    case 'e':
                        numstring[i] = 5; break;
                    case 'f':
                        numstring[i] = 6; break;
                    case 'g':
                        numstring[i] = 7; break;
                    case 'h':
                        numstring[i] = 8; break;
                    case 'i':
                        numstring[i] = 9; break;
                    case 'j':
                        numstring[i] = 10; break;
                    case 'k':
                        numstring[i] = 11; break;
                    case 'l':
                        numstring[i] = 12; break;
                    case 'm':
                        numstring[i] = 13; break;
                    case 'n':
                        numstring[i] = 14; break;
                    case 'o':
                        numstring[i] = 15; break;
                    case 'p':
                        numstring[i] = 16; break;
                    case 'q':
                        numstring[i] = 17; break;
                    case 'r':
                        numstring[i] = 18; break;
                    case 's':
                        numstring[i] = 19; break;
                    case 't':
                        numstring[i] = 20; break;
                    case 'u':
                        numstring[i] = 21; break;
                    case 'v':
                        numstring[i] = 22; break;
                    case 'w':
                        numstring[i] = 23; break;
                    case 'x':
                        numstring[i] = 24; break;
                    case 'y':
                        numstring[i] = 25; break;
                    case 'z':
                        numstring[i] = 26; break;
                    default:
                        break;
                }
            }


            for (int i = 0; i < numstring.Length; i++)
            {
                Console.Write(numstring[i] + " ");
            }

            Stack<int> subset = new Stack<int>();
            int indexchange = -1;
            Console.WriteLine("");
           

            bool check = false;
            Console.Write(numstring.Length - 1);
            for (int i = numstring.Length-1; i > -1; i--)
            {

                Console.WriteLine("test");
                if (subset.Count == 0)
                {
                    subset.Push(numstring[i]);
                }
                else
                {
                    Console.WriteLine("Numstring[i]: " + numstring[i] + " subset.peek(): " + subset.Peek() );
                    if (numstring[i]>=subset.Peek())
                    {
                        subset.Push(numstring[i]);
                    }
                    else
                    {
                        Console.WriteLine("found indexexchange");
                        indexchange = i;
                        check = true;
                        break;
                    }
                }
                
            }
            if (!check)
            {
                return "no answer";
            }
            else
            {
                bool alchange = false;
                int indexlarger = -1;
                int[] output = new int[numstring.Length];
                for (int i = numstring.Length - 1; i >= indexchange; i--)
                {
                    if (subset.Count == 0)
                    {
                        break;
                    }
                    if (subset.Count == 1 && i == numstring.Length - 1)
                    {
                        output[numstring.Length - 1] = numstring[indexchange];
                        output[indexchange] = numstring[numstring.Length - 1];
                        break;
                    }
                    if (alchange == false)
                    {
                        if (subset.Peek() > numstring[indexchange])
                        {
                            output[i] = subset.Pop();
                            indexlarger = i;
                            Console.WriteLine("index larger: " + indexlarger);
                            if (subset.Count == 0)
                            {
                                int temp = output[i];
                                output[i] = numstring[indexchange];
                                output[indexchange] = temp;
                            }
                        }
                        else
                        {
                            Console.WriteLine("found samller value");
                            output[i] = subset.Pop();
                            int temp = output[indexlarger];
                            output[indexlarger] = numstring[indexchange];
                            output[indexchange] = temp;
                            alchange = true;
                        }
                    }
                    else
                    {
                        output[i] = subset.Pop();
                    }
                   
                }
                for (int i = 0; i < indexchange; i++)
                {
                    output[i] = numstring[i];
                }
                string acoutput = "";
                for (int i = 0; i < output.Length; i++)
                {
                    Console.Write(output[i] + " ");
                }
                for (int i = 0; i < output.Length; i++)
                {
                    switch (output[i])
                    {
                        case 1: acoutput = acoutput + 'a'; break;
                        case 2: acoutput = acoutput + 'b'; break;
                        case 3: acoutput = acoutput + 'c'; break;
                        case 4: acoutput = acoutput + 'd'; break;
                        case 5: acoutput = acoutput + 'e'; break;
                        case 6: acoutput = acoutput + 'f'; break;
                        case 7: acoutput = acoutput + 'g'; break;
                        case 8: acoutput = acoutput + 'h'; break;
                        case 9: acoutput = acoutput + 'i'; break;
                        case 10: acoutput = acoutput + 'j'; break;
                        case 11: acoutput = acoutput + 'k'; break;
                        case 12: acoutput = acoutput + 'l'; break;
                        case 13: acoutput = acoutput + 'm'; break;
                        case 14: acoutput = acoutput + 'n'; break;
                        case 15: acoutput = acoutput + 'o'; break;
                        case 16: acoutput = acoutput + 'p'; break;
                        case 17: acoutput = acoutput + 'q'; break;
                        case 18: acoutput = acoutput + 'r'; break;
                        case 19: acoutput = acoutput + 's'; break;
                        case 20: acoutput = acoutput + 't'; break;
                        case 21: acoutput = acoutput + 'u'; break;
                        case 22: acoutput = acoutput + 'v'; break;
                        case 23: acoutput = acoutput + 'w'; break;
                        case 24: acoutput = acoutput + 'x'; break;
                        case 25: acoutput = acoutput + 'y'; break;
                        case 26: acoutput = acoutput + 'z'; break;
                      
                        


                        default: return "not valid";
                    }
                }
                return acoutput;
            }
          
        }



     



    }
}
