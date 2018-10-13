using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.DataStructures
{
    class nonDivisibleSubset
    {

        private int maxsize;

        public int getMaxsize()
        {
            return maxsize;
        }

        public void setMaxsize(int size)
        {
            maxsize = size;
        }

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
        
        public List<int> Recursive( int k, int currentIndex, int[] S, List<int> list)
        {
            for (int i = currentIndex; i < S.Length; i++)
            {

                int temp = i;
                if (list.Count == 0)
                {
                    
                    list.Add(S[i]);
                    list = Recursive( k, temp + 1, S, list);
                    Console.WriteLine("Removing: " + list[list.Count - 1]);
                    list.RemoveAt(list.Count - 1);
                }
                else
                {
                    if (testFunction(i, k, list, S))
                    {
                        list.Add(S[i]);
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine(OutputIntArray(list.ToArray()));
                        list = Recursive( k, i + 1, S, list);
                        Console.WriteLine("Removing: " + list[list.Count - 1]);
                        list.RemoveAt(list.Count - 1);
                    }
                    else
                    {
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine(OutputIntArray(list.ToArray()));
                        list = Recursive( k, i + 1, S, list);
                    }
                }

                Console.WriteLine("List size: " + list.Count);
                
            }

            if (list.Count>getMaxsize())
            {
                setMaxsize(list.Count);
            }
            

            
            return list;
        }


        public static int optimizedDivisible(int k, int[] S)
        {
            int[] modulusArr = new int[k];
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Original Array: ");
            Console.WriteLine(OutputIntArray(S));
            for (int i = 0; i < S.Length; i++)
            {
                modulusArr[(S[i]) % k] = modulusArr[(S[i]) % k] + 1;
               
            }
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Modulus Array: ");
            Console.WriteLine(OutputIntArray(modulusArr));
            Console.WriteLine("-----------------------------------");
            if (modulusArr[0]>1)
            {
                modulusArr[0] = 1;
            }
            if (k%2 == 0)
            {
                if (modulusArr[k/2] > 1)
                {
                    modulusArr[k / 2] = 1;
                }
            }

            double size = modulusArr.Length / 2;
          
            for (int i = 0; i < modulusArr.Length; i++)
            {
                if (i == 0)
                {

                }
                else if (k%2==0 && i == k/2)
                {

                }
                else if (modulusArr[i]>modulusArr[k-i])
                {
                    modulusArr[k - i] = 0;
                }
                else if (modulusArr[i]<modulusArr[k-i])
                {
                    modulusArr[i] = 0;
                }
                else if (modulusArr[i] == modulusArr[k - i])
                {
                    modulusArr[k - i] = 0;
                }
            }

            int count = 0;

            Console.WriteLine(OutputIntArray(modulusArr));

            for (int i = 0; i < modulusArr.Length; i++)
            {
                count = count + modulusArr[i];
            }

            return count;


        }




        public static int nonDivisibleSubsetFunction(int k, int[] S)
        {
            
            nonDivisibleSubset non = new nonDivisibleSubset();

            /*List<int> temp = new List<int>();
            non.setMaxsize(0);
            non.Recursive(k, 0, S, temp);*/

            Console.WriteLine(optimizedDivisible(k, S));
            return 0;
        }

       


    }
}
