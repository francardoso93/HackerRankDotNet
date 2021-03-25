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

class Solution
{
    // currentHourglassSum = arr[0][0] + arr[0][1] + arr[0][2]; // first row
    // currentHourglassSum += arr[1][1]; // second row
    // currentHourglassSum += arr[2][0] + arr[2][1] + arr[2][2]; // third row

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr) // O(n quadrado)
    { // X e Y like a normal person! 
        int biggestSum = Int32.MinValue; // Em uma matriz só com números negativos a inicialização com 0 seria um enorme problema!
        int currentHourglassSum = 0;
        for (int x = 0; x < 4; x++)
        {
            for (int y = 0; y < 4; y++)
            {
                //Printing HourGlass
                // Console.WriteLine(arr[x][x] + " " + arr[x][x + 1] + " " + arr[x][x + 2]);
                // Console.WriteLine("  "+ arr[x + 1][x + 1]);
                // Console.WriteLine(arr[x + 2][x] + " " + arr[x + 2][x + 1] + " " + arr[x + 2][x + 2]);
                //

                currentHourglassSum = arr[x][y] + arr[x][y + 1] + arr[x][y + 2]; // first row
                currentHourglassSum += arr[x + 1][y + 1]; // second row
                currentHourglassSum += arr[x + 2][y] + arr[x + 2][y + 1] + arr[x + 2][y + 2]; // third row
                biggestSum = currentHourglassSum > biggestSum ? currentHourglassSum : biggestSum;
                currentHourglassSum = 0;
            }
        }
        return biggestSum;
    }

    static void Main(string[] args)
    {

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        Console.WriteLine(result);
    }
}
