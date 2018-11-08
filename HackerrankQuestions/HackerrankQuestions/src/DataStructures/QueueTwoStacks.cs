using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.DataStructures
{
    class Solution
    {
        Stack<int> stack1;
        Stack<int> stack2;

        public Solution()
        {
            stack1 = new Stack<int>();
            stack2 = new Stack<int>();
        }

        public void enqueue(int num)
        {
            stack1.Push(num);
            if (stack2.Count == 0)
            {
                if (stack1.Count > 0)
                {
                    while (stack1.Count != 0)
                    {
                        stack2.Push(stack1.Pop());
                    }
                }
            }
        }
        public void dequeue()
        {
            if (stack2.Count>1)
            {
                stack2.Pop();
            }
            else if (stack2.Count == 1)
            {
                stack2.Pop();
            }

            if (stack2.Count == 0)
            {
                if (stack1.Count > 0)
                {
                    while (stack1.Count != 0)
                    {
                        stack2.Push(stack1.Pop());
                    }
                }
            }
        }
        public int peek()
        {
            return stack2.Peek();
        }

    }
}
