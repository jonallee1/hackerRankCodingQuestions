using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.DataStructures
{
   public class node
    {
        public int data;
        public node Right;
        public node Left;

       public node(int d)
        {
            this.data = d;
            Right = null;
            Left = null;
        }
    }


 
    
    class TreePostOrderTraversal
    {

        public static void postOrder(node root)
        {


            if (root!=null) {
                postOrder(root.Left);

                postOrder(root.Right);
                
                    Console.Write(root.data + " ");
                
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
