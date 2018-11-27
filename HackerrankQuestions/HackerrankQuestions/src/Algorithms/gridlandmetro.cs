using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.Algorithms
{
    class gridlandmetro
    {
        static public long gridlandMetro(long n, long m, int k, long[][] track)
        {

            Dictionary<long, List<long[]>> map = new Dictionary<long, List<long[]>>();
            for (long i = 0; i < k; i++)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Command number: " + i);
                if (map.ContainsKey((track[i][0])))
                {
                    Console.WriteLine("Contains key: " + track[i][0]);
                    bool added = false;

                    for(int j = 0; j < map[track[i][0]].Count; j++)
                    {
                        if (map[track[i][0]][j][0] > track[i][1] && map[track[i][0]][j][1] >= track[i][2] && map[track[i][0]][j][0] <= track[i][2])
                        {
                            Console.WriteLine("union add 1");
                            map[track[i][0]][j][0] = track[i][1];
                            added = true;
                            break;
                        }
                        else if (map[track[i][0]][j][1] < track[i][2] && map[track[i][0]][j][1] >= track[i][1] && map[track[i][0]][j][0] <= track[i][1])
                        {
                            Console.WriteLine("union add 2");
                            map[track[i][0]][j][1] = track[i][2];
                            added = true;
                            break;
                        }
                        else if (map[track[i][0]][j][0] >= track[i][1] && map[track[i][0]][j][1] <= track[i][2] )
                        {
                            Console.WriteLine("union add 3");
                            map[track[i][0]][j][0] = track[i][1];
                            map[track[i][0]][j][1] = track[i][2];
                            added = true;
                            break;

                        }
                        else if (map[track[i][0]][j][0] <= track[i][1] && map[track[i][0]][j][1] >= track[i][2])
                        {
                            Console.WriteLine("union add 4");
                            added = true;
                            break;
                        }
                        else
                        {

                        }
                    }
                    if (!added)
                    {
                        Console.WriteLine("not union add");
                        map[track[i][0]].Add(new long[] { track[i][1], track[i][2] });
                    }
                   
                }
                else
                {
                    Console.WriteLine("Does not contain key");
                    List<long[]> temp = new List<long[]>();
                    temp.Add(new long[] { track[i][1], track[i][2] });
                    map.Add(track[i][0], temp);
                }
            }
            long total = 0;
            foreach (KeyValuePair<long, List<long[]>> tracks in map)
            {
                Console.WriteLine("Addition for row");
                long tracktotal = 0;
                foreach (long[] t in tracks.Value)
                {
                    Console.WriteLine("start: " + t[0] + " end: " + t[1] );
                    tracktotal = tracktotal + (t[1] - t[0]) + 1;
                }
                total = total + (m - tracktotal);
                
            }
            Console.WriteLine("Empty lines: " + (n-map.Count));
            total = total + (n - map.Count)*m;
            return total;
        }


        /* int[,] gridland = new int[n,m];

         for (int i = 0; i < k; i++)
         {

             for (int j = track[i][1]-1; j < track[i][2]; j++)
             {
                 gridland[track[i][0] - 1, j] = -1;
             }
         }

         for (int i = 0; i < n; i++)
         {
             for (int j = 0; j< m; j++)
             {
                 Console.Write(gridland[i,j] + " ");
             }
             Console.WriteLine();
         }
         int total = 0;
         for (int i = 0; i < n; i++)
         {
             for (int j = 0; j < m; j++)
             {
                 total = total + checkspace(gridland, i, j);
             }
         }
         return total;*/


        public static int checkspace(int[,] gridland, int x, int y)
        {
            if (x < 0 || x >= gridland.GetLength(0) || y < 0 || y >= gridland.GetLength(1))
            {
                return 0;
            }
            if (gridland[x,y] == -1)
            {
                return 0;
            }
            gridland[x, y] = -1;
            int count = 1;

            count = count + checkspace(gridland, x, y - 1);
            count = count + checkspace(gridland, x, y + 1);
            count = count + checkspace(gridland, x + 1, y);
            count = count + checkspace(gridland, x - 1, y);

            return count;
            
        }
    }
}
