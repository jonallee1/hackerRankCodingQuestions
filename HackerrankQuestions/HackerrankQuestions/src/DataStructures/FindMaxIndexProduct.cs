using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.DataStructures
{
    class FindMaxIndexProduct
    {
        public static long solve(int[] arr)
        {
            int i = arr.Length;
            bool decreasing = false;
            Stack<int> localmin = new Stack<int>();
            for (int j = i - 1; j >= 1; j--)
            {
                if (arr[j] >= arr[j - 1])
                {
                    if (localmin.Count == 0)
                    {
                        localmin.Push(j);
                    }
                    if (arr[j] > arr[j - 1])
                    {
                        decreasing = true;
                    }
                   
                    localmin.Push(j - 1);
                   
                }
                else if (arr[j] < arr[j - 1] && decreasing == true)
                {
                    break;
                }
            }
            if (localmin.Count == 0)
            {
                Console.WriteLine("only descending");
                return 0;
            }
            if (localmin.Count == arr.Length)
            {
                Console.WriteLine("only increasing");
                return 0;
            }
            Console.WriteLine("--------------------------");
           /* foreach (int n in localmin)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("--------------------------");*/
            

            int index = localmin.Peek();

            int left = localmin.Peek() ;
            long right = localmin.Peek();
            long maxproduct = 0;
            Console.WriteLine(index);
            while (localmin.Count>0 && left >= 0 && right <arr.Length)
            {
                if (arr[index]>=arr[left] && arr[index]>=arr[right])
                {
                    left = left - 1;
                    right = right + 1;

                }
                else if (arr[index] >= arr[left] && arr[index] <arr[right])
                {
                    right = right + 1;
                }
                else if (arr[index] < arr[left] && arr[index] >= arr[right])
                {
                    left = left + 1;
                }
                else
                {
                    Console.WriteLine("found pair");
                    Console.WriteLine(left + " " + right);
                    Console.WriteLine("answer = " + left * right);
                    if ((left+1)*(right +1) > maxproduct)
                    {

                        Console.WriteLine("right" + right + " left" + left);
                        maxproduct = (left + 1) * (right + 1);
                        Console.WriteLine(maxproduct);
                        
                    }
                    index = localmin.Pop();
                }

            }
            
            return maxproduct;
        }

    }
}
