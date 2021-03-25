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

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr)
    {
        int arrayTotal = arr.Length;
        int positiveNumbers = 0;
        int zeros = 0;
        int negativeNumbers = 0;
        for (int a = 0; a < arrayTotal; a++)
        {
            if (arr[a] > 0)
            {
                positiveNumbers++;
            }
            else if (arr[a] == 0)
            {
                zeros++;
            }
            else
            {
                negativeNumbers++;
            }
        }
        Console.WriteLine(string.Format("{0:N6}", Decimal.Divide(positiveNumbers, arrayTotal)));
        Console.WriteLine(string.Format("{0:N6}", Decimal.Divide(negativeNumbers, arrayTotal)));
        Console.WriteLine(string.Format("{0:N6}", Decimal.Divide(zeros, arrayTotal)));      
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
