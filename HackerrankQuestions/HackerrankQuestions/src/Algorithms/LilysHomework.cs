using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerrankQuestions.src.Algorithms
{
    public class LilysHomework
    {
        public static int lilysHomework(int[] arr1)
        {
            int[] mainasc = (int[])arr1.Clone();
            int[] maindes = (int[])arr1.Clone();
            int[] ascendingSort = (int[])arr1.Clone();
            int[] descendingSort = (int[])arr1.Clone();
            Array.Sort(ascendingSort);
            Array.Sort(descendingSort);
            Array.Reverse(descendingSort);
            Dictionary<int, int> tracker = new Dictionary<int, int>();

            for (int i = 0; i < arr1.Length; i++)
            {
                tracker.Add(arr1[i], i);
            }
            Dictionary<int, int> tracker1 = new Dictionary<int, int>(tracker);
            int counter = 0;
            for (int i = 0; i < ascendingSort.Length; i++)
            {
                if (tracker[ascendingSort[i]] != i)
                {
                    int temp = mainasc[i];
                    mainasc[i] = ascendingSort[i];
                    mainasc[tracker[ascendingSort[i]]] = temp;

                    int tempindex = tracker[ascendingSort[i]];
                    tracker[mainasc[i]] = i;
                    tracker[temp] = tempindex;

                    counter = counter + 1;



                }
            }
            int counter1 = 0;

            for (int i = 0; i < descendingSort.Length; i++)
            {
                if (tracker1[descendingSort[i]] != i)
                {
                    int temp = maindes[i];
                    maindes[i] = descendingSort[i];
                    maindes[tracker1[descendingSort[i]]] = temp;

                    int tempindex = tracker1[descendingSort[i]];
                    tracker1[maindes[i]] = i;
                    tracker1[temp] = tempindex;

                    counter1 = counter1 + 1;



                }
            }


            // Console.WriteLine(counter + " " + counter1);
            if (counter > counter1)
            {
                return counter1;
            }
            else
            {
                return counter;
            }
        }
    }
}
