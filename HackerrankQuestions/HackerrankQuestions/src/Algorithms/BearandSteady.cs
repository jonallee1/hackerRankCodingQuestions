using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.Algorithms
{
    class BearandSteady
    {
        public static int steadyGene(string gene)
        {
            int shortestSubstring = 0;
            int numOfLet = gene.Length / 4;
            int A = 0;
            int C = 0;
            int G = 0;
            int T = 0;


            for (int i = 0; i < gene.Length; i++)
            {
                if (gene[i] == 'A')
                {
                    A = A + 1;
                }
                else if (gene[i] == 'C')
                {
                    C = C + 1;
                }
                else if (gene[i] == 'G')
                {
                    G = G + 1;
                }
                else
                {
                    T = T + 1;
                }
            }

            Dictionary<char, int> tracker = new Dictionary<char, int>();
            tracker.Add('A', A );
            tracker.Add('C', C);
            tracker.Add('G', G );
            tracker.Add('T', T );
            bool validtail = true;
            bool validhead = true;
            int headind = 0;
            int tailind = 0;
           
            while (true) {
                Console.WriteLine("Tail: -------------------------------------");
                

                if (tailind == gene.Length)
                {
                    break;
                }
                if (tracker['A']>numOfLet || tracker['C'] > numOfLet || tracker['G'] > numOfLet || tracker['T'] > numOfLet)
                {
                    tracker[gene[tailind]] = tracker[gene[tailind]] - 1;
                    tailind = tailind + 1;
                    Console.WriteLine("Tailind: " + tailind + " headind: " + headind);
                    Console.WriteLine("Number of A to del: " + tracker['A'] + " Number of C to del: " + tracker['C'] + " Number of G to del: " + tracker['G'] + " Number of T to del: " + tracker['T']);

                }
                if (tracker['A'] <= numOfLet && tracker['C'] <= numOfLet && tracker['G'] <= numOfLet && tracker['T'] <= numOfLet)
                {
                    if (shortestSubstring ==0 || tailind-headind<shortestSubstring)
                    {
                        shortestSubstring = tailind - headind;
                        Console.WriteLine("ShortestSubstring: " + shortestSubstring);
                    }

                    tracker[gene[headind]] = tracker[gene[headind]] + 1;
                    headind = headind + 1;
                    Console.WriteLine("Tailind: " + tailind + " headind: " + headind);
                    Console.WriteLine("Number of A to el: " + tracker['A'] + " Number of C to del: " + tracker['C'] + " Number of G to del: " + tracker['G'] + " Number of T to del: " + tracker['T']);
                    if (tracker['A'] <= numOfLet && tracker['C'] <= numOfLet && tracker['G'] <= numOfLet && tracker['T'] <= numOfLet)
                    {
                        if (shortestSubstring == 0 || tailind - headind < shortestSubstring)
                        {
                            shortestSubstring = tailind - headind;
                            Console.WriteLine("ShortestSubstring: " + shortestSubstring);
                        }
                    }
                  
                }


            }

            /* int shortestSubstring = 0;
            int numOfLet = gene.Length / 4;
            int A = 0;
            int C = 0;
            int G = 0;
            int T = 0;


            for (int i = 0; i < gene.Length; i++)
            {
                if (gene[i] == 'A')
                {
                    A = A + 1;
                }
                else if (gene[i] == 'C')
                {
                    C = C + 1;
                }
                else if (gene[i] == 'G')
                {
                    G = G + 1;
                }
                else
                {
                    T = T + 1;
                }
            }

            Dictionary<char, int> tracker = new Dictionary<char, int>();
            tracker.Add('A', A - numOfLet);
            tracker.Add('C', C - numOfLet);
            tracker.Add('G', G - numOfLet);
            tracker.Add('T', T - numOfLet);

            Console.WriteLine("Number of A: " + A + " Number of C: " + C + " Number of G: " + G + " Number of T: " + T );
            Console.WriteLine("Number of A to el: " + tracker['A'] + " Number of C to del: " + tracker['C'] + " Number of G to del: " + tracker['G'] + " Number of T to del: " + tracker['T']);

           

            int substringlencounter = 0;

            for (int i = 0; i < gene.Length; i++)
            {
                if(tracker[gene[i]] > 0)
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Initial Character: " + gene[i]);
                    tracker[gene[i]] = tracker[gene[i]] - 1;
                    substringlencounter = substringlencounter + 1;
                  
                    for (int j = i + 1; j < gene.Length; j++)
                    {
                        Console.Write(gene[j] + " ");
                        Console.WriteLine("Number of A to el: " + tracker['A'] + " Number of C to del: " + tracker['C'] + " Number of G to del: " + tracker['G'] + " Number of T to del: " + tracker['T']);
                         substringlencounter = substringlencounter + 1;
                        if (tracker['A'] <= 0 && tracker['C'] <= 0 && tracker['G'] <= 0 && tracker['T'] <= 0)
                        {
                            break;
                        } 
                        if (tracker[gene[j]] > 0)
                        {
                            tracker[gene[j]] = tracker[gene[j]] - 1;
                           
                            Console.WriteLine(substringlencounter);
                        }
                        Console.WriteLine();
                        if (tracker['A'] <= 0 && tracker['C'] <= 0 && tracker['G'] <= 0 && tracker['T'] <= 0)
                        {
                            break;
                        }

                    }
                    if (shortestSubstring == 0 || substringlencounter<shortestSubstring)
                    {

                        if (tracker['A'] <= 0 && tracker['C'] <= 0 && tracker['G'] <= 0 && tracker['T'] <= 0)
                        {
                            shortestSubstring = substringlencounter;
                            Console.WriteLine(shortestSubstring);
                        }

                      
                    }
                    substringlencounter = 0;
                    tracker['A'] = A - numOfLet;
                    tracker['C'] = C - numOfLet;
                    tracker['G'] = G - numOfLet;
                    tracker['T'] = T - numOfLet;


                }
            }*/




            return shortestSubstring;
        }

    }
}
