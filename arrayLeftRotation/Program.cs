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
    // arrayAlreadyRotated[2 - 3] = a[2];
    // Isso significa que ele precisa ir para a posição 4
    // Total que quero andar - minha posição.
    // Fazer a subração, pegar o numero negativo e subtrair do total do lenght // É oq fiz na minha cabeça D.I.Y
    // Complete the rotLeft function below.
    static int[] rotLeft(int[] a, int d)
    {

        // 3 para a esquerda
        // Se está na posição 5, precisa ir para a 2 (subtraiu 3!) 

        int[] arrayAlreadyRotated = new int[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            // arrayAlreadyRotated[4 - 3] = a[4];
            int position = i - d; // i= 3 ; d =3; position = 0 ; // i = 1 d = 3 position = -2
            if (position < 0)
                position = (a.Length) + position; // 4 - 2 = 2
            arrayAlreadyRotated[position] = a[i];
        }

        return arrayAlreadyRotated;
    }

    static void Main(string[] args)
    {
        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        int[] result = rotLeft(a, d);

        Console.WriteLine(string.Join(" ", result));       
    }
}
