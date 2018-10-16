using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.Algorithms
{
    class Time_InWords
    {
        public string timeInWords(int h, int m)
        {
            


            String output = "";
            if (m == 0) 
            {
                output = outputString(h) + " o' clock";
            }
            else if (m <= 30)
            {
                if (m == 1)
                {
                    output = outputString(m) + " minute past " + outputString(h);
                }
                else if (m == 15)
                {
                    output = outputString(m) + " past " + outputString(h);
                }
                else if (m == 30)
                {
                    output = outputString(m) + " past " + outputString(h);
                }
                else
                {
                    output = outputString(m) + " minutes past " + outputString(h);
                }
                
            }
            else
            {
                if(h==12)
                {
                    h = 1;
                    if (m == 59)
                    {
                        output = outputString(60 - m) + " minute to " + outputString(h);
                    }
                    else if (m == 45)
                    {
                        output = outputString(60 - m) + " to " + outputString(h);
                    }
                    else
                    {
                        output = outputString(60 - m) + " minutes to " + outputString(h );
                    }
                }
                else
                {
                    if (m == 59)
                    {
                        output = outputString(60 - m) + " minute to " + outputString(h + 1);
                    }
                    else if (m == 45)
                    {
                        output = outputString(60 - m) + " to " + outputString(h + 1);
                    }
                    else
                    {
                        output = outputString(60 - m) + " minutes to " + outputString(h + 1);
                    }
                }

                
               
            }
            return output;
        }

        public string outputString(int n)
        {
            switch (n)
            {
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nice";
                case 10:
                    return "ten";
                case 11:
                    return "eleven";
                case 12:
                    return "twelve";
                case 13:
                    return "thirteen";
                case 14:
                    return "fourteen";
                case 15:
                    return "quarter";
                case 16:
                    return "sixteen";
                case 17:
                    return "seventeen";
                case 18:
                    return "eighteen";
                case 19:
                    return "nineteen";
                case 20:
                    return "twenty";
                case 21:
                    return "twenty one";
                case 22:
                    return "twenty two";
                case 23:
                    return "twenty three";
                case 24:
                    return "twenty four";
                case 25:
                    return "twenty five";
                case 26:
                    return "twenty six";
                case 27:
                    return "twenty seven";
                case 28:
                    return "twenty eight";
                case 29:
                    return "twenty nine";
                case 30:
                    return "half";
                default:
                    return "none";
              



            }
        }

    }
}
