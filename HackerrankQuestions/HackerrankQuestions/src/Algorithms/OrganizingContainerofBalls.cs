using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.Algorithms
{
    class OrganizingContainerofBalls
    {
        static string organizingContainers(int[][] container, int n)
        {
            int[] ballspercontainer = new int[n];
            int[] ballspertype = new int[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ballspercontainer[i] = ballspercontainer[i] + container[i][j];
                }
            }
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    ballspertype[j] = ballspertype[j] + container[i][j];
                }
            }
            Array.Sort(ballspercontainer);
            Array.Sort(ballspertype);

            for (int i = 0; i < n; i++)
            {
                if (ballspercontainer[i] != ballspertype[i])
                {
                    return "Impossible";
                }
            }
            return "Possible";
        }
    }
}
