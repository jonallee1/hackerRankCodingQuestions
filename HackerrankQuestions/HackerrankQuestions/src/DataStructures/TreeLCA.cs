using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.DataStructures
{
    class TreeLCA
    {
        public static node lca(node root, int v1, int v2)
        {
            node cur = root;
            int smalldata;
            int bigdata;
            if (v1 < v2)
            {
                smalldata = v1;
                bigdata = v2;
            }
            else
            {
                smalldata = v2;
                bigdata = v1;

            }
            Console.WriteLine("smalldata: " + smalldata);
            Console.WriteLine("bigdata: " + bigdata);
            Queue<node> SmallQueue = new Queue<node>();
            Queue<node> LargeQueue = new Queue<node>();
            bool test = true;
           // Console.WriteLine("--------------------------------------------------------------------");
            while (test)
            {
                if (cur != null)
                {

                    SmallQueue.Enqueue(cur);
                   
                    if (smalldata < cur.data)
                    {
                        Console.WriteLine("Smalldata: " + smalldata + " cur data: " + cur.data);
                        Console.WriteLine("Move Left");
                        cur = cur.Left;
                    }
                    else if (smalldata > cur.data)
                    {
                        cur = cur.Right;
                    }
                    else
                    {
                        test = false;
                    }

                }
                else
                {
                    test = false;
                }


            }
            test = true;
            cur = root;
            //Console.WriteLine("--------------------------------------------------------------------");
            while (test)
            {
                if (cur != null)
                {
                    LargeQueue.Enqueue(cur);
                    
                    if (bigdata < cur.data)
                    {
                        cur = cur.Left;
                    }
                    else if (bigdata > cur.data)
                    {
                        cur = cur.Right;
                    }
                    else
                    {
                        test = false;
                    }

                }
                else
                {
                    test = false;
                }


            }
            bool foundNode = false;
            cur = root;
            Console.WriteLine("--------------------------------------------------------------------");
            foreach (node i in LargeQueue)
            {
                Console.WriteLine(i.data);
            }
            Console.WriteLine("--------------------------------------------------------------------");
            foreach (node i in SmallQueue)
            {
                Console.WriteLine(i.data);
            }

            Console.WriteLine("--------------------------------------------------------------------");
            while (!foundNode)
            {
                if (LargeQueue.Peek() == SmallQueue.Peek())
                   
                {
                    
                    cur = LargeQueue.Dequeue();
                    SmallQueue.Dequeue();
                   Console.WriteLine(cur.data);
                }
                else
                {
                    return cur;
                }
            }
            return cur;
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
