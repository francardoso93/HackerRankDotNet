using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace deleteChars
{
    class Program
    {
        static int countPossibilities(string currentName, string newName)
        {
            int count = 0;
            for (int i = 0; i <= currentName.Length - newName.Length; i++)
            {
                string tempSubstring = currentName.Substring(i, newName.Length);
                Console.WriteLine(tempSubstring);
                if (tempSubstring == newName)
                {
                    count++;
                }
            }

            //Removendo 1 caracter
            string splitedPart = newName.Substring(newName.Length - 1, 1);
            newName = newName.Remove(newName.Length - 1);
            Console.WriteLine(splitedPart);
            for (int i = 0; i < currentName.Length - newName.Length; i++)
            {
                string tempSubstring = currentName.Substring(i, newName.Length); //Corta o prefixo
                Console.WriteLine(tempSubstring);
                if (tempSubstring == newName)
                {                    
                    string removedFirstPart = currentName.Substring(i + newName.Length, currentName.Length - i - newName.Length);
                    count += Regex.Matches(removedFirstPart, splitedPart).Count; //Quantas vezes encontro a parte removida na frente da parte que estou contando
                    break; // aqui cheguei em 5!
                }
            }

            //Removendo 2 caracter
            splitedPart = newName.Substring(newName.Length - 2, 2);
            newName = newName.Remove(newName.Length - 2);
            Console.WriteLine(splitedPart);
            for (int i = 0; i < currentName.Length - newName.Length; i++)
            {
                string tempSubstring = currentName.Substring(i, newName.Length); //Corta o prefixo
                Console.WriteLine(tempSubstring);
                if (tempSubstring == newName)
                {                    
                    string removedFirstPart = currentName.Substring(i + newName.Length, currentName.Length - i - newName.Length);
                    count += Regex.Matches(removedFirstPart, splitedPart).Count; //Quantas vezes encontro a parte removida na frente da parte que estou contando
                    break; // aqui cheguei em 5!
                }
            }
            
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(countPossibilities("ababattba", "aba")); // 5 (eu acho kkkk)
        }
    }
}
