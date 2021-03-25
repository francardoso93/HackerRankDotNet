// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace exercise1
// {

//     static class Program
//     {
//         // Kadane's Algorithm
//         // https://stackoverflow.com/questions/9890227/kadanes-algorithm-to-find-subarray-with-the-maximum-sum
//         // https://stackoverflow.com/questions/54526700/is-there-enough-information-retained-in-kadanes-algorithm-to-return-the-actual?rq=1
//         // https://www.youtube.com/watch?v=86CQq3pKSUw&ab_channel=CSDojo
//         // Olhar para cada item e pergunta: Qual o subarray máximo possível nesse índice? ==> Olhando para trás
//         // Depois, no final, comparar os maiores subarrays encontrados e ver qual é o maior (é a final do campeonato).
//         // Nisso ainda tá O(n quadrado), 
//         // mas o interessante para torar isso O(n) é que o elemento que estou olhando, ou ele sozinho é o max subarray ou o elemento atual combinado com o subarray máximo anterior.
        
//         public static decimal FindBestSubsequence(this IEnumerable<decimal> source, out int startIndex, out int endIndex)
//         {
//             decimal result = decimal.MinValue;
//             decimal evenSum = 0;
//             decimal oddSum = 0;
//             int tempStart = 0;

//             List<decimal> tempList = new List<decimal>(source);

//             startIndex = 0;
//             endIndex = 0;

//             for (int index = 0; index < tempList.Count; index++)
//             {
//                 if (tempList[index] % 2 == 0)
//                 { // Se for par
//                     evenSum += tempList[index];
//                 }
//                 else
//                 { // se for impar subtraio!
//                   // Numeros impares negativos é bom e positivo é ruim!
//                     oddSum += tempList[index];
//                 }

//                 if (sum > result)
//                 {
//                     result = sum;
//                     startIndex = tempStart;
//                     endIndex = index;
//                 }
//                 if (sum < 0) // Deu ruim, start começa de outro ponto, assim como a soma
//                 {
//                     sum = 0;
//                     tempStart = index + 1;
//                 }
//             }

//             return result;
//         }
//         static void Main(string[] args)
//         {
//             int startIndex;
//             int endIndex;
//             var arr = new decimal[] { 1, -1, 1, -1, 1 }; // Expected output 25
//             // var arr = new decimal[] { -1, -4, 2 }; // Expected output 36
//             // var arr = new decimal[] { -1, 2, 3, 4, -5 }; // Expected output 81
//             decimal evenSum = FindBestSubsequence(arr, out startIndex, out endIndex);
//             decimal oddSum = 0;
//             for (int i = startIndex; i <= endIndex; i++)
//             {
//                 oddSum += arr[i] % 2 == 0 ? 0 : arr[i];
//             }

//             decimal subtract = evenSum - oddSum;
//             Console.WriteLine(subtract * subtract);


//             Console.WriteLine(startIndex);
//             Console.WriteLine(endIndex);
//         }
//     }
// }
