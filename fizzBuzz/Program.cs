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



class Result
{

    /*
     * Complete the 'fizzBuzz' function below.
     *
     * The function accepts INTEGER n as parameter.
     */


    public static void fizzBuzz(int n)
    {
        var watch = System.Diagnostics.Stopwatch.StartNew();
        int[] arrayWithSomeStuff = new int[] { 1, 3, 5, 7, 9 };
        List<int> ListWithSomeStuff = new List<int> { 1, 3, 5, 7, 9 };
        Console.WriteLine(ListWithSomeStuff[3]);
        var hashFromArray = arrayWithSomeStuff.ToHashSet();
        var dictionaryFromArray = arrayWithSomeStuff.ToDictionary(x => x, x => x);

        // Console.WriteLine(dictionaryFromArray[1]);
        // Console.WriteLine(hashFromArray[1]);
        // Console.WriteLine(hashFromArray.TryGetValue(1));
        // Console.WriteLine(hashFromArray.TryGetValue(2));

        for (int i = 1; i <= n; i++)
        {
            if (i % 5 == 0 && i % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }

        watch.Stop();
        var elapsedMs = watch.ElapsedMilliseconds;
        Console.WriteLine(elapsedMs);
    }


}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.fizzBuzz(n);

    }
}
