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
     * Complete the 'taumBday' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER b
     *  2. INTEGER w
     *  3. INTEGER bc
     *  4. INTEGER wc
     *  5. INTEGER z
     */

    public static long taumBday(long b, long w, long bc, long wc, long z)
    {
        if (wc < bc && wc + z < bc)
        {
            return (w + b) * wc + b * z;
        }
        else if (bc < wc && bc + z < wc)
        {
            return (w + b) * bc + w * z;
        }
        else
        {
            return b * bc + w * wc;
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            long b = Convert.ToInt64(firstMultipleInput[0]);

            long w = Convert.ToInt64(firstMultipleInput[1]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            long bc = Convert.ToInt64(secondMultipleInput[0]);

            long wc = Convert.ToInt64(secondMultipleInput[1]);

            long z = Convert.ToInt64(secondMultipleInput[2]);

            long result = Result.taumBday(b, w, bc, wc, z);

            Console.WriteLine(result);
        }
    }
}
