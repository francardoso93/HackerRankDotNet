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

    // Complete the permutationEquation function below.
    static int[] permutationEquation(int[] p, int n)
    {
        int[] yArray = new int[n];
        int [] p_inverse = new int[n];
        for (int x = 1; x <= n; x++) {
            p_inverse[p[x-1] - 1] = x;
        }

        for (int x = 0; x < n; x++) { 
            // yArray[p_inverse[x-1] - 1] = x; // Isso seria inverter a invertida, voltando ao seu estado normal! Não é o objetivo
           yArray[x] = p_inverse[p_inverse[x] - 1]; // P(P(Y))
        }
        return yArray;        
    }

    static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine());

        int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), pTemp => Convert.ToInt32(pTemp))
        ;
        int[] result = permutationEquation(p, n);

        Console.WriteLine(string.Join("\n", result));
    }
}
