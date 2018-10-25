using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.DataStructures
{
  
    class TreeInOrder
    {
        public static void InOrder(node root)
        {


            if (root != null)
            {
                InOrder(root.Left);
                Console.Write(root.data + " ");
                InOrder(root.Right);

               

            }
        }


        public node Insert(node root, int data)
        {
            if (root == null)
            {
                return new node(data);
            }
            else
            {
                if (data <= root.data)
                {
                    root.Left = Insert(root.Left, data);
                }
                else
                {
                    root.Right = Insert(root.Right, data);
                }
            }
            return root;
        }

    }
}
