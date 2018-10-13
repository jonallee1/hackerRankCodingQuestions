using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.DataStructures
{
    class LeftRotation
    {

        public static void arrLeftRotation()
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;


            int[] output = new int[n];
            int temp = d;

            //Concept d-amount of left side shifted to right side


            for (int i = 0; i < n - d; i++)  //setting n-d right handed values to the left side of array
            {
                output[i] = a[temp];
                temp++;
            }
            temp = n - d;
            for (int i = 0; i < d; i++)     //setting d left handed values to the right side of the array
            {
                output[temp] = a[i];
                temp++;
            }

            foreach (var item in output)
            {
                Console.Write(item.ToString() + " ");
            }
        }
    }
}
