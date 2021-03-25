using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s) {
        DateTime dt = DateTime.Parse(s); 
        return dt.ToString("HH:mm:ss");
    }

    static void Main(string[] args) {

        string s = Console.ReadLine();

        string result = timeConversion(s);

        Console.WriteLine(result);
    }
}
