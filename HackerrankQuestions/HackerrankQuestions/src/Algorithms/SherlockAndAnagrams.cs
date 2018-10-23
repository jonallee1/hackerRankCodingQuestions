using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.Algorithms
{
    class SherlockAndAnagrams
    {

        public static int sherlockAndAnagrams(string s)
        {
            if (s.Length == 0 || s.Length == 1)
            {
                return 0;
            }
            int output = 0;
            List<String> subStrList = new List<String>();
            for (int i = 0; i < s.Length; i++)
            {
                String temp = "";
                temp = temp + s[i];
                subStrList.Add(temp);
                for (int j = i+1; j < s.Length; j++)
                {
                    temp = temp + s[j];
                    subStrList.Add(temp);
                }
            }


            for (int i = 0; i < subStrList.Count; i++)
            {
                char[] a = subStrList[i].ToCharArray();
                Array.Sort(a);
                
                subStrList[i] = new string(a);
            }
            foreach (String i in subStrList)
            {

              
                
                Console.WriteLine(i);
            }
            
            for (int i = 0; i < subStrList.Count; i++)
            {
                int count = 0;
                for (int j = i+1; j < subStrList.Count; j++)
                {
                    if (subStrList[i] == subStrList[j])
                    {
                        count = count + 1;
                        subStrList.RemoveAt(j);
                        j = j-1;
                        
                    }
                   
                    
                }
                if (count > 0)
                {
                    output = output + (count * (count + 1) / 2);
                }
            }

            Console.WriteLine("Output: " + output);
            return output;

        }
    }
}
