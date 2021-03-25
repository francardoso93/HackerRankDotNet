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

class Solution
{

    // Complete the miniMaxSum function below.
    static void miniMaxSum(long[] arr)
    {
        Array.Sort(arr);
        Console.Write(arr[0] + arr[1] + arr[2] + arr[3]);
        Console.Write(' ');
        Console.Write(arr[1] + arr[2] + arr[3] + arr[4]);
    }

    static void Main(string[] args)
    {
        long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt64(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
