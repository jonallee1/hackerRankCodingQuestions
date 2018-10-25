using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.DataStructures
{
    class HeightBinaryTree
    {

        public static int height(node root)
        {
            // Write your code here.
            int leftheight = 0;
            int rightheight = 0;
            int maxheight = -1;
            if (root != null)
            {

                leftheight = height(root.Left);
                rightheight = height(root.Right);
                if (leftheight >= rightheight)
                {
                    maxheight = leftheight + 1;
                }
                else
                {
                    maxheight = rightheight + 1;
                }
            }



            return maxheight;
        }
    }
}
