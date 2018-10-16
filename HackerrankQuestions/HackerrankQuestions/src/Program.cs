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
            //Encryption enc = new Encryption();
            //String test= "roqfqeylxuyxjfyqterizzkhgvngapvudnztsxeprfp";
            //Console.WriteLine(enc.encryption(test));


            // _3DSurfaceArea sa = new _3DSurfaceArea();


            //int[][] array2D = new int[3][];
            //array2D[0] = new int[]{ 1, 3, 4 };
            //array2D[1] = new int[] { 2, 2, 3 };
            //array2D[2] = new int[] { 1, 2, 4 };
            //sa.surfaceArea(array2D, 3, 3);

            Time_InWords tiw = new Time_InWords();
            Console.WriteLine(tiw.timeInWords(12, 34));
            Console.WriteLine(tiw.timeInWords(1, 34));
            Console.WriteLine(tiw.timeInWords(12, 15));
            Console.WriteLine(tiw.timeInWords(5, 45));
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
