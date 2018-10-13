using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerrankQuestions.src.DataStructures
{
    class EqualStacks
    {
         public int equalStacks(int[] h1, int[] h2, int[] h3)
        {
            //initalizing stacks from arrays
            
            Array.Reverse(h1);
            Array.Reverse(h2);
            Array.Reverse(h3);
            Stack<int> stack1 = new Stack<int>(h1);
            Stack<int> stack2 = new Stack<int>(h2);
            Stack<int> stack3 = new Stack<int>(h3);
            int totalblocks = stack1.Count() + stack2.Count() + stack3.Count();
            int stack1height = checkStackHeight(stack1);
            int stack2height = checkStackHeight(stack2);
            int stack3height = checkStackHeight(stack3);


            for (int i = 0; i < totalblocks; i++) //removes the top block from the tallest stack, will continue until all stacks are equal height, or there are no more blocks left
            {

                if (stack1height == stack2height && stack1height == stack3height)
                {
                    return stack1height;
                }

                else if (stack1height >= stack2height && stack1height >= stack3height )
                {
                    stack1height = stack1height - stack1.Peek();
                    stack1.Pop();                   
                }

                else if (stack2height >= stack1height && stack2height >= stack3height)
                {
                    stack2height = stack2height - stack2.Peek();
                    stack2.Pop();                    
                }

                else if (stack3height >= stack1height && stack3height >= stack2height)
                {
                    stack3height = stack3height - stack3.Peek();
                    stack3.Pop();                   
                }

            }

            return 0;

        }


        public int checkStackHeight(Stack<int> mystack)
        {
            int size = 0;
            foreach (int item in mystack)
            {
                size = size + item;
            }

            return size;

        }

       



    }
}
