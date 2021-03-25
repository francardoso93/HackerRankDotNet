using System.IO;
using System;
using System.Linq;

class Solution
{
    // Complete the maxSubarray function below.
    static int[] maxSubarray(int[] arr)
    {
        int best_subarray_sum = findBestSubarraySum(arr);
        int best_subsequence_sum = findBestSequenceSum(arr);
        return new int[] { best_subarray_sum, best_subsequence_sum };
    }

    private static int findBestSubarraySum(int[] arr)
    {
        int current_subarray_sum = int.MinValue;
        int best_subarray_sum = int.MinValue; // Dessa forma funciona com números negativos! (pq best_sum é iniciado com minValue, e não com zero).
        for (int i = 0; i < arr.Length; i++)
        {
            current_subarray_sum = Math.Max(0, current_subarray_sum) + arr[i];
            best_subarray_sum = Math.Max(best_subarray_sum, current_subarray_sum);
        }

        return best_subarray_sum;
    }

    private static int findBestSequenceSum(int[] arr)
    {
        int best_subsequence_sum = arr.Sum(x => x > 0 ? x : 0);
        if (best_subsequence_sum == 0) // Todos os números negativos nesse caso
            best_subsequence_sum = arr.Max();
        return best_subsequence_sum;
    }

    static void Main(string[] args)
    {
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int[] result = maxSubarray(arr);

            Console.WriteLine(string.Join(" ", result));
        }

        // textWriter.Flush();
        // textWriter.Close();
    }
}
