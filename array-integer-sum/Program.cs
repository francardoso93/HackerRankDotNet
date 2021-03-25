using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace array_integer_sum
{
    class Program
    {
        /*
     * Complete the simpleArraySum function below.
     */
        static long aVeryBigSum(long[] ar)
        {
            long sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp))
            ;
            long result = aVeryBigSum(ar);
            Console.WriteLine(result);

            // textWriter.WriteLine(result);

            // textWriter.Flush();
            // textWriter.Close();
        }
    }
}
