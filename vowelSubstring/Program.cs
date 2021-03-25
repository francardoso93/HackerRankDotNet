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
     * Complete the 'findSubstring' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s 
     *  2. INTEGER k -> substring size
     */

    // TODO: Voltar para tentar otimizar

    public static string findSubstring(string s, int k)
    {
        int biggestAmountOfVowels = 0;
        string biggestSubstring = "Not found!";

        for (int i = 0; i < s.Length + 1 - k; i++)
        {
            string currentSubstring = s.Substring(i, k); // Reaproveitar a mesma
            // Reaproveitar a mesma. Não redeclarar.
            int currentVowelCounter = currentSubstring.Count(character => character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u' );       
            if (currentVowelCounter > biggestAmountOfVowels)
            {
                biggestAmountOfVowels = currentVowelCounter;
                biggestSubstring = currentSubstring;
            }
        }

        return biggestSubstring;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.findSubstring(s, k);

        Console.WriteLine(result);
    }
}
