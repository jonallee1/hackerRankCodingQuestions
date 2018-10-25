using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.DataStructures
{
    class TreeTopView
    {
        public static void topView(node root)
        {
            Queue<Tuple<node, int>> nodeQueue = new Queue<Tuple<node, int>>();

            Stack<int> leftstack = new Stack<int>();
            Queue<int> rightstack = new Queue<int>();
            int left = 0;
            int right = 0;
            if (root == null)
            {

            }
            else
            {
                nodeQueue.Enqueue(new Tuple<node, int>(root, 0));
                leftstack.Push(root.data);
                Tuple<node, int> nd;

                Console.WriteLine("-------------------------------------------------");
                while (nodeQueue.Count != 0)
                {
                    nd = nodeQueue.Dequeue();
                    Console.WriteLine("nd value " + nd.Item1.data + " distance from center " + nd.Item2);
                    if (nd.Item1.Left != null)
                    {
                        nodeQueue.Enqueue( new Tuple<node, int>(nd.Item1.Left, nd.Item2-1));
                      
                    }
                    if (nd.Item1.Right != null)
                    {
                        nodeQueue.Enqueue(new Tuple<node, int>(nd.Item1.Right, nd.Item2 + 1));
                      
                    }
                    if (nd.Item2 == left - 1)
                    {
                        Console.WriteLine("First left value");
                        leftstack.Push(nd.Item1.data);
                        left = left - 1;
                    }
                    if (nd.Item2 == right + 1)
                    {
                        Console.WriteLine("First right value");
                        rightstack.Enqueue(nd.Item1.data);
                        right = right + 1;
                    }
                   // Console.Write(nd.Item1.data + " ");
                    if (nodeQueue.Count != 0)
                    {
                        nd = nodeQueue.Peek();
                    }
                   

                }
                Console.WriteLine("-------------------------------------------------");
            }
            Console.WriteLine("leftstack size = " + leftstack.Count);
            Console.WriteLine("rightstack size = " + rightstack.Count);
            foreach (int i in leftstack)
            {
                Console.Write(i + " ");
            }
            foreach (int i in rightstack)
            {
                Console.Write(i + " ");
            }

            
        }


        public static node Insert(node root, int data)
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
