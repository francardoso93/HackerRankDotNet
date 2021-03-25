using System.Collections.Generic;
using System;

class Solution
{

    // Complete the checkMagazine function below.
    // O dicionário aqui tem ser a chave da palavra e o valor quantas vezes ela existe!
    static void checkMagazine(string[] magazine, string[] note)
    {
        bool hasWord = true;
        Dictionary<string, int> magazineDictionary = InicializeMagazineDictionary(magazine);
        hasWord = CutWordFromMagazine(note, hasWord, magazineDictionary);

        if (hasWord)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }

    private static bool CutWordFromMagazine(string[] note, bool hasWord, Dictionary<string, int> magazineDictionary)
    {
        for (int i = 0; i < note.Length; i++)
        {
            if (magazineDictionary.ContainsKey(note[i]) && magazineDictionary[note[i]] > 0)
            {
                magazineDictionary[note[i]]--;
            }
            else
            {
                hasWord = false;
                break;
            }
        }

        return hasWord;
    }

    private static Dictionary<string, int> InicializeMagazineDictionary(string[] magazine)
    {
        var magazineDictionary = new Dictionary<string, int>();
        for (int i = 0; i < magazine.Length; i++)
        {
            if (magazineDictionary.ContainsKey(magazine[i]))
            {
                magazineDictionary[magazine[i]]++;
            }
            else
            {
                magazineDictionary.Add(magazine[i], 1);
            }
        }

        return magazineDictionary;
    }

    static void Main(string[] args)
    {
        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        string[] magazine = Console.ReadLine().Split(' ');

        string[] note = Console.ReadLine().Split(' ');

        checkMagazine(magazine, note);
    }
}
