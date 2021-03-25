using System.Collections.Generic;
using System;

namespace Exercise1
{

    class Solution
    {
        public static void Main(string[] args)
        {
            int priceOfJeansCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> priceOfJeans = new List<int>();

            for (int i = 0; i < priceOfJeansCount; i++)
            {
                int priceOfJeansItem = Convert.ToInt32(Console.ReadLine().Trim());
                priceOfJeans.Add(priceOfJeansItem);
            }

            int priceOfShoesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> priceOfShoes = new List<int>();

            for (int i = 0; i < priceOfShoesCount; i++)
            {
                int priceOfShoesItem = Convert.ToInt32(Console.ReadLine().Trim());
                priceOfShoes.Add(priceOfShoesItem);
            }

            int priceOfSkirtsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> priceOfSkirts = new List<int>();

            for (int i = 0; i < priceOfSkirtsCount; i++)
            {
                int priceOfSkirtsItem = Convert.ToInt32(Console.ReadLine().Trim());
                priceOfSkirts.Add(priceOfSkirtsItem);
            }

            int priceOfTopsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> priceOfTops = new List<int>();

            for (int i = 0; i < priceOfTopsCount; i++)
            {
                int priceOfTopsItem = Convert.ToInt32(Console.ReadLine().Trim());
                priceOfTops.Add(priceOfTopsItem);
            }

            int dollars = Convert.ToInt32(Console.ReadLine().Trim());

            long result = Result.GetNumberOfOptions(priceOfJeans, priceOfShoes, priceOfSkirts, priceOfTops, dollars);

            Console.WriteLine(result);
        }
    }
}