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

    // Complete the countApplesAndOranges function below.
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
    {
        countFruit(s, t, a, apples);
        countFruit(s, t, b, oranges);
    }

    private static void countFruit(int s, int t, int b, int[] fruits)
    {
        int fruitsOnTheHouseCounter = 0;

        for (int i = 0; i < fruits.Length; i++)
        {
            int exactPositionWhereFruitFell = b + fruits[i];
            if (exactPositionWhereFruitFell >= s && exactPositionWhereFruitFell <= t)
            {
                fruitsOnTheHouseCounter++;
            }
        }
        Console.WriteLine(fruitsOnTheHouseCounter);
    }

    static void Main(string[] args)
    {
        // Input 1
        string[] st = Console.ReadLine().Split(' ');

        int s = Convert.ToInt32(st[0]); // Posição Inicio da casa

        int t = Convert.ToInt32(st[1]); // Posição Final da casa

        // Input 2
        string[] ab = Console.ReadLine().Split(' ');

        int a = Convert.ToInt32(ab[0]); // Posição árvore de maçãs

        int b = Convert.ToInt32(ab[1]); // Posição árvore de laranjas

        // Input 3
        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]); // Quantidade de maçãs

        int n = Convert.ToInt32(mn[1]);// Quantidade de laranjas

        // Input 4
        // Distância de cada maçã a partir da árvore
        int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
        ;

        // Input 5
        // Distância de cada laranja a partir da árvore
        int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
        ;
        countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
