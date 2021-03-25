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
    // Agora entendi o FODA. Se o cara foi subornado.., ele pode subornar outro?

    // 1 2 5 3 4


    // 1 2 3 4 5 6 7 8
    // 1 2 5 3 7 8 6 4
    // 5 subornou 2
    // 7 subornou 2
    // 8 subornou 2

    // Complete the minimumBribes function below.
    static void minimumBribes(long[] q)
    {
        long totalBribes = 0;
        bool tooChaotic = false;

        int expectedFirst = 1;
        int expectedSecond = 2;
        int expectedThird = 3;

        for (int i = 0; i < q.Length; i++)
        {

            if (q[i] == expectedFirst)
            {
                expectedFirst = expectedSecond;
                expectedSecond = expectedThird;
                ++expectedThird;
            }
            else if (q[i] == expectedSecond)
            {
                ++totalBribes;
                expectedSecond = expectedThird;
                ++expectedThird;
            }
            else if (q[i] == expectedThird)
            {
                totalBribes += 2;
                ++expectedThird;
            }
            else
            {
                tooChaotic = true;
                Console.WriteLine("Too chaotic");
                break;
            }
        }

        if (!tooChaotic)
            Console.WriteLine(totalBribes);
    }


    // Pra cada item, eu vou subtrair o valor da posição atual para pegar quantos bribes existiram. Por ex: 
    // Se ninguém fez um bribe > 3, encontrar o mínimo para printar
    // Se eu encontrar um bribe > 3 já faço o break e print 'too caotic'

    // Acho que o minimum bribes que eles querem é o total que rolou de bribes

    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine()); // Number of test cases

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // Number of people

            long[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt64(qTemp)) // Final of people
            ;
            minimumBribes(q);
        }
    }
}

