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

    // Complete the compareTriplets function below.
    // Alice's score is in the first position, and Bob's score is in the second.
    static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int aliceScore = 0;
        int bobScore = 0;
        for (int i = 0; i < 3; i++)
        {
            if (a.ElementAt(i) > b.ElementAt(i))
            {
                aliceScore++;
            }
            else if (a.ElementAt(i) < b.ElementAt(i))
            {
                bobScore++;
            }
        }

        return new List<int> { aliceScore, bobScore };
    }

    static void Main(string[] args)
    {
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = compareTriplets(a, b);

        Console.WriteLine(String.Join(" ", result));

        // textWriter.WriteLine(String.Join(" ", result));

        // textWriter.Flush();
        // textWriter.Close();
    }
}
