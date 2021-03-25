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

    // Complete the designerPdfViewer function below.


    static int designerPdfViewer(int[] h, string word)
    {
        Dictionary<char, int> createCharDictionaryWithHeights = NewMethod(h);

        int biggestHeight = FindBiggestCharHeight(word, createCharDictionaryWithHeights);
        return biggestHeight * word.Length;
    }

    private static int FindBiggestCharHeight(string word, Dictionary<char, int> createCharDictionaryWithHeights)
    {
        int biggestHeight = 0;
        for (int j = 0; j < word.Length; j++)
        {
            biggestHeight = Math.Max(biggestHeight, createCharDictionaryWithHeights[word[j]]);
        }

        return biggestHeight;
    }

    private static Dictionary<char, int> NewMethod(int[] h)
    {
        var charDict = new Dictionary<char, int>();
        int i = 0;
        char c = 'a';
        for (; c <= 'z'; c++, i++)
        {
            charDict.Add(c, h[i]);
        }

        return charDict;
    }

    static void Main(string[] args)
    {

        int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp))
        ;
        string word = Console.ReadLine();

        int result = designerPdfViewer(h, word);

        Console.WriteLine(result);
    }
}
