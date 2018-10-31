using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.DataStructures
{
    class IsThisaBST
    {

        public static void InOrder(List<int> arr, node root)
        {


            if (root != null)
            {
                InOrder(arr, root.Left);
                arr.Add(root.data);
                InOrder(arr, root.Right);



            }
        }

        bool checkBST(node root)
        {
            List<int> arr = new List<int>();
            InOrder(arr, root);
            for (int i = 0; i < arr.Count - 1; i++)
            {
                if (arr[i] >= arr[i+1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
