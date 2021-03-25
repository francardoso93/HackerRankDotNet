using System.Linq;
using System;

class Solution
{
    // De qualquer forma, para cada elemento preciso validar com os outros todos do outro array, independente de qual deles eu tome como "base"
    // Complete the matchingStrings function below.
    static int[] matchingStrings(string[] strings, string[] queries)
    {
        int[] queryCounter = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            queryCounter[i] = strings.Count(a => a == queries[i]);
        }   
        return queryCounter;
    }

    static void Main(string[] args)
    {
        int stringsCount = Convert.ToInt32(Console.ReadLine());

        string[] strings = new string[stringsCount];

        for (int i = 0; i < stringsCount; i++)
        {
            string stringsItem = Console.ReadLine();
            strings[i] = stringsItem;
        }

        int queriesCount = Convert.ToInt32(Console.ReadLine());

        string[] queries = new string[queriesCount];

        for (int i = 0; i < queriesCount; i++)
        {
            string queriesItem = Console.ReadLine();
            queries[i] = queriesItem;
        }

        int[] res = matchingStrings(strings, queries);

        Console.WriteLine(string.Join("\n", res));

    }
}
