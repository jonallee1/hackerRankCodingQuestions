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

class LeftRotation
{



    static void Main(string[] args)
    {
        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;


        int[] output = new int[n];
        int temp = d;

        for (int i = 0; i < n-d; i++ )
        {
            output[i] = a[temp];
            temp++;
        }
        temp = n-d;
        for (int i = 0; i < d; i++)
        {
            output[temp] = a[i];
            temp++;
        }

        foreach (var item in output)
        {
            Console.Write(item.ToString() + " ");
        }
    }
}
