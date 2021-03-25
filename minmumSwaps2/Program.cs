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



    // Complete the minimumSwaps function below.
    static int minimumSwaps(int[] arr)
    {
        // Um array SORTED
        // Vou fazer o for a partir do sorted e marcar todo elemento que eu ler como VISITED TRUE (Eles iniciam com false) => Vai ser útil quando vou comparar um cara que tá lá na frente com o outro de trás (pq faz parte de um swap que já foi contabilizado)
        // Dictionary para guardar cada valor do elemento como valor e index position como KEY. (No C# o hash só guarda chave e elemento com o mesmo valor)
        // Array para Element visited status


        bool[] isVisited = new bool[arr.Length + 1];
        Dictionary<Int32, Int32> dict = new Dictionary<Int32, Int32>();
        // Inicializa o Hash
        for (int i = 1; i <= arr.Length; i++) // Aqui é melhor já inicializar a partir do 1. No hash as chaves são como eu quiser
        {
            dict.Add(i, arr[i - 1]);
        }
        int swapCount = 0;
        for (int i = 1; i <= dict.Count; i++) // i é a chave exata de onde o número deveria estar! // Isso só tá fazendo sentido aqui porque os números são consecutivos. Se não fossem, aqui é o momento em que eu compararia com um array já sorted previamente
        {
            int nextItem;

            if (isVisited[i] == false)
            {
                isVisited[i] = true;
                int currentValue = dict[i];
                if (currentValue == i)  // Nesse caso já está no lugar certo. Nada a fazer.
                {
                    continue;
                }
                else
                {
                    while (!isVisited[currentValue]) // Ciclo de swaps // O valor que encontro no item, é o índice do próximo que preciso olhar. Quando o próximo que preciso olhar já foi visitado é porque fechou esse ciclo.
                    {
                        isVisited[currentValue] = true;
                        nextItem = dict[currentValue];
                        currentValue = nextItem;
                        ++swapCount;
                    }
                }
            }
        }
        return swapCount;
    }

    static void Main(string[] args)
    {
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int res = minimumSwaps(arr);
        Console.WriteLine(res);

        // textWriter.WriteLine(res);

        // textWriter.Flush();
        // textWriter.Close();
    }
}
