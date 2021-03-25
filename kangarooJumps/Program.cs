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

class Solution {

    // Complete the kangaroo function below.
    // 0 3 4 2
    static string kangaroo(int x1, int v1, int x2, int v2) {
        // Quando eles nunca vão se encontrar (primeira condição)
        // - Se um começou na frente do outro e o que está atrás é mais lento 
        // - Se começaram do mesmo lugar, mas velocidades diferentes

        return (x2 - x1) * (v2 - v1) < 0 && Math.Abs(x1 - x2) % Math.Abs(v2 - v1) == 0 ? "YES" : "NO";     

    }

    static void Main(string[] args) {

        string[] x1V1X2V2 = Console.ReadLine().Split(' ');

        int x1 = Convert.ToInt32(x1V1X2V2[0]);

        int v1 = Convert.ToInt32(x1V1X2V2[1]);

        int x2 = Convert.ToInt32(x1V1X2V2[2]);

        int v2 = Convert.ToInt32(x1V1X2V2[3]);

        string result = kangaroo(x1, v1, x2, v2);
        Console.WriteLine(result);       
    }
}
