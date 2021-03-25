using System.Linq;
using System;
using System.Numerics;



class Solution
{

    // Complete the arrayManipulation function below.
    static BigInteger arrayManipulation(int n, int[][] queries)
    {
        // Brute Force O(n * m). Muito lento para passar dentro do tempo.
        BigInteger[] array = new BigInteger[n]; // Array of 'n' zeroes

        // Lembrando que a variável aqui são as linhas. São sempre 3 colunas!
        for (int queryRow = 0; queryRow < queries.Length; queryRow++)
        {
            int firstElement = queries[queryRow][0] - 1;
            int lastElement = queries[queryRow][1] - 1;
            for (int arrayColumn = firstElement; arrayColumn <= lastElement; arrayColumn++)
            {
                array[arrayColumn] += queries[queryRow][2];
            }
        }

        

        return array.Max();
    }

    static void Main(string[] args)
    {
        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]); // Array Size

        int m = Convert.ToInt32(nm[1]); // Number Of operations

        int[][] queries = new int[m][];

        for (int i = 0; i < m; i++)
        {
            queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
        }

        BigInteger result = arrayManipulation(n, queries);

        Console.WriteLine(result);
    }
}
