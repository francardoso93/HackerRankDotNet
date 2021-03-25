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


class Result
{

    /*
     * Complete the 'decryptPassword' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string decryptPassword(string s)
    {
        int i = 0;
        char temp;
        int lastZeroFound;
        List<char> passwordCharList = new List<char>(s);
        while (i < passwordCharList.Count)
        {
            if (Char.IsNumber(passwordCharList[i]))
            {
                // FIND THE LATEST ZERO POSSIBLE AND PLACE THIS AT ITS PLACE
                lastZeroFound = passwordCharList.LastIndexOf('0');
                if (lastZeroFound != -1)
                {
                    passwordCharList[lastZeroFound] = passwordCharList[i];
                    passwordCharList.RemoveAt(i);
                } else {
                    i++;
                }
            }
            else if (Char.IsUpper(passwordCharList[i]) && Char.IsLower(passwordCharList[i + 1]))
            {
                // SWAP THEM
                // REMOVE * at s[i + 2]
                temp = passwordCharList[i];
                passwordCharList[i] = passwordCharList[i + 1];
                passwordCharList[i + 1] = temp;
                passwordCharList.RemoveAt(i + 2);
                i += 2;
            }
            else
            {
                i++;
            }
        }

        return new string(passwordCharList.ToArray());
    }

}
class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        string result = Result.decryptPassword(s);

        
    }
}
