using System;
using System.Collections.Generic;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            int horizontalTotal = Convert.ToInt32(Console.ReadLine().Trim());
            int verticalTotal = Convert.ToInt32(Console.ReadLine().Trim());
            int horizontalCutsLength = Convert.ToInt32(Console.ReadLine().Trim());
            var horizontalCuts = new int[horizontalCutsLength];
            for (int i = 0; i < horizontalCutsLength; i++)
            {
                int cut = Convert.ToInt32(Console.ReadLine().Trim());
                horizontalCuts[i] = cut;
            }
            int verticalCutsLength = Convert.ToInt32(Console.ReadLine().Trim());
            var verticalCuts = new int[verticalCutsLength];
            for (int i = 0; i < verticalCutsLength; i++)
            {
                int cut = Convert.ToInt32(Console.ReadLine().Trim());
                verticalCuts[i] = cut;
            }
            // long ans = solution.storageOptimization(6, 6, new int[] { 2, 4 }, new int[] { 2 });
            long ans = solution.StorageOptimization(horizontalTotal, verticalTotal, horizontalCuts, verticalCuts);
            Console.WriteLine(ans);
        }
    }
}
