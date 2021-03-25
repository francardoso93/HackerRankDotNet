// Cut stickes into smaller sticks
// Discard shortes untilare none left


// Each Interation = what is the length of the shortest stick remaining?
// Cut that shortest value from all the other pieces.
// When they're all the same length, discard them.

// Print number of sticks at each interaction

using System.Collections.Generic;
using System.Linq;
using System;

class Solution
{

    // Complete the cutTheSticks function below.
    static List<int> cutTheSticks(List<int> arr)
    {
        var stickAmountEachInteraction = new List<int>();
        arr.Sort();
        while (arr.Count > 0)
        {
            stickAmountEachInteraction.Add(arr.Count);
            int i = 1;
            while (i < arr.Count)
            {
                arr[i] = arr[i] - arr[0];
                if (arr[i] <= 0)
                { // Acabou o gravetinho
                    arr.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
            arr.RemoveAt(0); // Remove o que estava servindo de base para os demais no momento
        }
        return stickAmountEachInteraction;
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        List<int> result = cutTheSticks(arr.ToList());

        Console.WriteLine(string.Join("\n", result));
    }
}
