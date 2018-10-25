using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.DataStructures
{
    class TreePreOrder
    {
        public static void preOrder(node root)
        {
            if (root != null)
            {

                Console.Write(root.data + " ");
                preOrder(root.Left);

                preOrder(root.Right);



            }
        }
    }
}
