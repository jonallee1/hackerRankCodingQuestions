﻿using HackerrankQuestions.src.Algorithms;
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

            //Time_InWords tiw = new Time_InWords();
            //Console.WriteLine(tiw.timeInWords(12, 34));
            //Console.WriteLine(tiw.timeInWords(1, 34));
            //Console.WriteLine(tiw.timeInWords(12, 15));
            //Console.WriteLine(tiw.timeInWords(5, 45));
            //Console.WriteLine(SherlockAndTheValidString.isValid("aabbc"));
            //Console.WriteLine(CommonChild.commonChild("WEWOUCUIDGCGTRMEZEPXZFEJWISRSBBSYXAYDFEJJDLEBVHHKS", "FDAGCXGKCTKWNECHMRXZWMLRYUCOCZHJRRJBOAJOQJZZVUYXIC"));
            // SherlockAndAnagrams.sherlockAndAnagrams("cdcd");
            //SparseArrays.matchingStrings();
            // String[] mainGrid = new String[4];
            /*node test = new node(47);

            int[] arr = new int[] { 2, 40, 20, 38, 30, 14, 28, 10, 16, 19, 44, 39, 27, 7, 9, 31, 12, 43, 21, 5, 41, 34, 49, 13, 33, 3, 4, 25, 22, 29, 15, 32, 35, 6, 24, 23, 26, 1, 11, 42, 36, 37, 17, 18, 8, 45, 48, 50, 46 };
            for (int i = 0; i < arr.Length; i++)
            {
                TreeTopView.Insert(test, arr[i]);
            }
           
            TreeTopView.topView(test);*/

            //int[][] array2D = new int[4][];
            //array2D[0] = new int[] { 1, 1, 0, 0};
            // array2D[1] = new int[] { 0, 1, 1, 0 };
            // array2D[2] = new int[] { 0, 0, 1, 0 };
            // array2D[3] = new int[] { 1, 0, 0, 0 };
            //Console.WriteLine( ConnectedCellsinaGrid.connectedCell(array2D, 4, 4));

            //int[] arr = new int[] {3,1,2};
            //Console.WriteLine( LilysHomework.lilysHomework(arr));

            //Console.WriteLine(BiggerisGreater.biggerIsGreater("zedawdvyyfumwpupuinbdbfndyehircmylb"));

            // mainGrid[0] = "123456";
            //mainGrid[1] = "567890";
            //mainGrid[2] = "234567";
            //mainGrid[3] = "194729";


            // Solution
            // String[] miniGrid = new String[2];
            //miniGrid[0] = "34";
            //  miniGrid[1] = "78";



            // Console.WriteLine(TheGridSearch.gridSearch(mainGrid, miniGrid));
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


            /*Solution queue = new Solution();
            int numqueue = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numqueue; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                if (tokens.Length==1)
                {
                    int a = int.Parse(tokens[0]);
                    if (a == 2)
                    {
                        queue.dequeue();
                    }
                    else if (a == 3)
                    {
                        Console.WriteLine(queue.peek());
                    }
                }
                else
                {
                    int a = int.Parse(tokens[0]);
                    int b = int.Parse(tokens[1]);
                    queue.enqueue(b);

                }*/
            //SimpleTextEditor t = new SimpleTextEditor();
            // int[] arr = new int[100000];
            /*for (int i = 0; i < arr.Length; i++)
            {
                if (i == 50000)
                {
                    arr[i] = 0;
                }
                else
                {
                    arr[i] = 1000000000;
                }
            }*/
            //Console.WriteLine(FindMaxIndexProduct.solve(new int[] { 0,1,0,1,2,3,4,5, 1,1,1,1,1,1 }
            // ));
            long[][] gridland = new long[4][];
            
            gridland[0] = new long[3] { 1,1,3 };
            gridland[1] = new long[3] { 2,2,2 }; 
            gridland[2] = new long[3] { 3,1,6 };
            gridland[3] = new long[3] { 3, 6, 6 };


            Console.WriteLine(gridlandmetro.gridlandMetro(3,7,4, gridland));
           Console.ReadLine();
        }
    }
}
