using System;
using System.Linq;
using System.Collections.Generic;

namespace swap
{
    class Swap
    {
        public int CountHowManySwaps(int[] arr)
        {
            int swapCount = 0;
            var sortedArr = arr.OrderBy(a => a).ToArray();
            Dictionary<int, int> sortedDictionary = CovertSortedArrToDictionary(sortedArr);

            var visited = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!visited.Contains(sortedArr[i]))
                {
                    visited.Add(sortedArr[i]); // Adiciona do Sorted (Elemento Alvo)
                    if (sortedArr[i] == arr[i]) // Se já está no local certo
                    {
                        continue;
                    }

                    var currentValue = arr[i];
                    DoSwapCircle(arr, ref swapCount, sortedDictionary, visited, ref currentValue);
                }
            }
            return swapCount;
        }

        private static void DoSwapCircle(int[] arr, ref int swapCount, Dictionary<int, int> sortedDictionary, HashSet<int> visited, ref int currentValue)
        {
            while (!visited.Contains(currentValue)) // Os números são únicos.. então posso salvar o valor aqui mesmo, não precisa ser o indice
            {
                visited.Add(currentValue);  // Adiciona do Unsorted (Elemento Origem)
                var nextIndex = sortedDictionary[currentValue];
                currentValue = arr[nextIndex];
                swapCount++;
            }
        }

        private static Dictionary<int, int> CovertSortedArrToDictionary(int[] sortedArr)
        {
            var sortedDictionary = new Dictionary<int, int>();
            for (int i = 0; i < sortedArr.Length; i++)
            {
                sortedDictionary.Add(sortedArr[i], i);
            }

            return sortedDictionary;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var swap = new Swap();
            var arr = new int[] { 3, 1, 10, 7, 9 };
            Console.WriteLine(swap.CountHowManySwaps(arr));
        }
    }
}
