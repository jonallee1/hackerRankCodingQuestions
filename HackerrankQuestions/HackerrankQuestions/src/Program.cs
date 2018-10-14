using HackerrankQuestions.src.Algorithms;
using HackerrankQuestions.src.DataStructures;
using System;

namespace HackerrankQuestions
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //int[] arr = new int[] { 19, 10, 12, 10, 24, 25, 22 };
            //int[] arr = new int[] {1,7,2,4 };
            //nonDivisibleSubset.nonDivisibleSubsetFunction(3, arr);
            Encryption enc = new Encryption();
            String test= "roqfqeylxuyxjfyqterizzkhgvngapvudnztsxeprfp";
            Console.WriteLine(enc.encryption(test));
            /*int[] arr1 = new int[]
            {
                1,1,1,1,2
            };

            int[] arr2 = new int[]
          {
                3,7
          };
            int[] arr3 = new int[]
          {
               1,3,1
          };
            EqualStacks stacks = new EqualStacks();


           Console.WriteLine(stacks.equalStacks(arr1, arr2, arr3));*/
            Console.ReadLine();
        }
    }
}
