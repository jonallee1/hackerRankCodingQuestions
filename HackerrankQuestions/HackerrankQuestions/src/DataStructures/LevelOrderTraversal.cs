using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.DataStructures
{
    class LevelOrderTraversal
    {
        public static void levelOrder(node root)
        {
            Queue<node> nodeQueue = new Queue<node>();
            if (root == null)
            {

            }
            else
            {
                nodeQueue.Enqueue(root);
                node nd;
                while (nodeQueue.Count != 0)
                {
                    nd = nodeQueue.Dequeue();
                    if (nd.Left != null)
                    {
                        nodeQueue.Enqueue(nd.Left);
                    }
                    if (nd.Right != null)
                    {
                        nodeQueue.Enqueue(nd.Right);
                    }
                    Console.Write(nd.data + " ");
                    nd = nodeQueue.Peek();

                }
            }


        }
    }
}
