using System.Collections.Generic;

namespace exercise3
{
    public class Solution
    {
        public long StorageOptimization(int horizontalTotal, int verticalTotal, int[] horizontalCuts, int[] verticalCuts)
        {
            bool[] horizontalMissing = new bool[horizontalTotal];
            bool[] verticalMissing = new bool[verticalTotal];
            PlaceMissingSeparators(horizontalCuts, horizontalMissing);
            PlaceMissingSeparators(verticalCuts, verticalMissing);
            int longestHorizontal = CalculateLongest(horizontalTotal, horizontalMissing);
            int longestVertical = CalculateLongest(verticalTotal, verticalMissing);
            return (longestHorizontal + 1) * (longestVertical + 1);
        }

        private static void PlaceMissingSeparators(int[] cuts, bool[] missing)
        {
            for (int i = 0; i < cuts.Length; i++)
            {
                missing[cuts[i] - 1] = true;
            }
        }

        private static int CalculateLongest(int total, bool[] missing)
        {
            int longest = 0;
            int currentCounter = 0;
            for (int i = 0; i < total; i++)
            {
                if (missing[i])
                {
                    currentCounter++;
                    longest = currentCounter > longest ? currentCounter : longest;
                }
                else
                {
                    currentCounter = 0;
                }
            }
            return longest;
        }
    }
}