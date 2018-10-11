using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class WarmUp2
{

    // Complete the compareTriplets function below.
    static List<int> compareTriplets(List<int> a, List<int> b)
    {

        List<int> output = new List<int>()
        {
            0,
            0
        };
        

        for (int i = 0; i < 3; i++)
        {
            if (a[i] < b[i]){
                output[1] = output[1] + 1;
            }
            else if (a[i] == b[i])
            {

            }
            else
            {
                output[0] = output[0] + 1;
            }
        }

        return output;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
