using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.Algorithms
{
    class radiotransmitter
    {
        public static int hackerlandRadioTransmitters(int[] x, int k)
        {
            if (x.Length == 1)
            {
                return 1;
            }
            Array.Sort(x); //nlogn

            int numoftransmitter = 0;
            int lasttransmitter = -1;
            int furthesthouseleft = 0;
            int i = 1;
            bool checkingfornewtranmitter = true;
            while (i+1 <= x.Length) 
            {
                Console.WriteLine("current index: " + i);
                if (checkingfornewtranmitter)
                {
                    if(i == x.Length - 1)
                    {
                        if (x[i] - x[furthesthouseleft] > k && i == furthesthouseleft + 1)
                        {
                            numoftransmitter = numoftransmitter + 2;
                        }
                        else
                        {
                            numoftransmitter++;
                        }
                        
                        Console.WriteLine("final New transmitter at loc: " + i);
                    }
                    else if (x[i] - x[furthesthouseleft] > k)
                    {
                        lasttransmitter = i - 1;
                        Console.WriteLine("New transmitter at loc: " + lasttransmitter);
                        numoftransmitter++;
                        checkingfornewtranmitter = false;
                        if (x[i]-x[lasttransmitter] > k)
                        {
                           
                            furthesthouseleft = i;
                            Console.WriteLine("furthest left at: " + furthesthouseleft);
                            checkingfornewtranmitter = true;
                        }
                    }
                }
                else
                {
                    if (x[i] - x[lasttransmitter] > k)
                    {
                        furthesthouseleft = i;
                        Console.WriteLine("furthest left at: " + furthesthouseleft);
                        checkingfornewtranmitter = true;

                        if (i == x.Length - 1)
                        {
                            numoftransmitter++;
                        }
                    }
                }
                i++;
                
            }
            return numoftransmitter;
        }
    }
}
