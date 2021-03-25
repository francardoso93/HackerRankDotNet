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
using System.Linq;

class Solution
{

    // Complete the findDigits function below.
    static int findDigits(int n)
    {
        string digits = n.ToString();
        int divisorCount = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            int divisor = int.Parse(digits[i].ToString());
            if (divisor != 0 && n % divisor == 0)
            {
                divisorCount++;
            }
        }
        return divisorCount;
    }

    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = findDigits(n);

            Console.WriteLine(result);
        }
    }
}
