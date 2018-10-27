using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.DataStructures
{
    class IsThisaBST
    {

        public static void InOrder(Vector<Integer> arr, Node root)
        {


            if (root != null)
            {
                InOrder(arr, root.left);
                arr.addElement(root.data);
                InOrder(arr, root.right);



            }
        }

        boolean checkBST(Node root)
        {
            Vector<Integer> arr = new Vector();
            InOrder(arr, root);
            for (int i = 0; i < arr.size() - 1; i++)
            {
                if (arr.get(i) >= arr.get(i + 1))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
