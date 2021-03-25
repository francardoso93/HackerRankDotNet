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

    // Complete the lilysHomework function below.
    // Não é OPTIMAL o suficiente. Quebrou no timeout de dois testes automatizados. O(N quadrado). Ideal seria O(Log N). Ainda assim rendeu alguns pontos :)
    static int lilysHomework(int[] arr)
    {
        var sorterArray = arr.OrderByDescending(o => o).ToArray(); // Tenho aqui os locais exatos onde deveriam estar os itens
        var unsortedArray = arr;
        int temp1;
        int swap = 0;

        int arrayLength = sorterArray.Length;
        for (int i = 0; i < arrayLength; i++)
        {
            if (sorterArray[i] != unsortedArray[i]) // Se no local certo, deixa lá, se não preciso fazer swaps!
            {
                temp1 = unsortedArray[i]; 
                unsortedArray[i] = sorterArray[i]; // Coloquei o valor correto que deveria estar nesse ponto. Ou seja B -> A
                for (int j = i + 1; j < arrayLength; j++) // Aqui é pra fazer A -> B
                {
                    if (unsortedArray[j] == sorterArray[i]) // Econtrei onde está o valor A
                    {
                        unsortedArray[j] = temp1; // Coloco o valor A no lugar
                        swap++;
                        break;
                    }
                }
            }
        }

        return swap;

    }

    static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = lilysHomework(arr);

        Console.WriteLine(result);

       
    }
}
