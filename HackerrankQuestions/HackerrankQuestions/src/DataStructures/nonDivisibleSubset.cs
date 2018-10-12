using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.DataStructures
{
    class nonDivisibleSubset
    {

        public static string OutputIntArray(int[] arr)
        {
            string arrToString = "[ ";
            foreach (int i in arr)
            {
                arrToString += i + " ";
            }
            arrToString += "]";
            return arrToString;
        }
        public bool testFunction(int index, int k, List<int> list, int[] S)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Value to be added: " + S[index]);
                Console.WriteLine("Current Value being added " + list[i]);
                Console.WriteLine("Modulus value: " + ((S[index] + list[i]) % k));


                    if ((S[index] + list[i]) % k == 0)
                    {
                    Console.WriteLine("Value not to be added");
                        return false;
                    }
                }



            Console.WriteLine("Value to be added");
            return true;
        }
        
        public int Recursive(int maxsize, int k, int currentIndex, int[] S, List<int> list)
        {
            
            for (int i = currentIndex; i < S.Length; i++)
            {
                if (list.Count == 0 && i==0)
                {
                    list.Add(S[currentIndex]);
                    Console.WriteLine(OutputIntArray(list.ToArray()));
                
                    maxsize = Recursive(maxsize, k, currentIndex + 1, S, list);
                    
                }
                else
                {
               
                    if (!testFunction(currentIndex, k, list, S))
                        {
                        Console.WriteLine("Current Value not added");
                            maxsize = Recursive(maxsize, k, currentIndex + 1, S, list);
                        }
                        else
                        {
                            list.Add(S[currentIndex]);
                            Console.WriteLine(OutputIntArray(list.ToArray()));
                            Console.ReadLine();
                            maxsize = Recursive(maxsize, k, currentIndex + 1, S, list);
                        }
                        
                    }

                }


            
            return list;
        }


        public static int nonDivisibleSubsetFunction(int k, int[] S)
        {
            nonDivisibleSubset non = new nonDivisibleSubset(); 
            int maxsize = 0;
            List<int> temp = new List<int>();
            maxsize = non.Recursive(k, 0, S, temp);
            return 0;
        }

       


    }
}
