using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.Algorithms
{
    class SparseArrays
    {
        public static int[] matchingStrings(string[] strings, string[] queries)
        {
            Dictionary<string, int> output = new Dictionary<string, int>();
            for (int i = 0; i < strings.Length; i++)
            {
                if (output.ContainsKey(strings[i]))
                {
                    output[strings[i]] = output[strings[i]] + 1;
                }
                else
                {
                    output.Add(strings[i], 1);
                }
            }

            foreach (KeyValuePair<String, int> kvp in output)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
            int[] arrOutput = new int[queries.Length];

            for (int i = 0; i < queries.Length; i++)
            {
                if (output.ContainsKey(queries[i]))
                {
                    arrOutput[i] = output[queries[i]];
                }
            }

            return arrOutput;
        }
    }
}
