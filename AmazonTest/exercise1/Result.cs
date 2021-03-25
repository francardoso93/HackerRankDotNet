using System.Collections.Generic;
using System.Linq;

namespace Exercise1
{
    public class Result
    {

        static int count = 0;
        /*
         * Complete the 'getNumberOfOptions' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY priceOfJeans
         *  2. INTEGER_ARRAY priceOfShoes
         *  3. INTEGER_ARRAY priceOfSkirts
         *  4. INTEGER_ARRAY priceOfTops
         *  5. INTEGER dollars
         */

        public static long GetNumberOfOptions(List<int> priceOfJeans, List<int> priceOfShoes, List<int> priceOfSkirts, List<int> priceOfTops, int dollars)
        {
            var allCombinationsWithinBudget = priceOfJeans.Where(jeans => jeans < dollars).SelectMany(
                jeans => priceOfShoes.Where(shoe => jeans + shoe < dollars).SelectMany(
                    shoe => priceOfSkirts.Where(skirt => jeans + shoe + skirt < dollars).SelectMany(
                            skirt => priceOfTops.Where(top => jeans + shoe + skirt + top <= dollars).Select(top => new { jeans, shoe, skirt, top })
                        )
                    )
                );
            return allCombinationsWithinBudget.Count();
        }
    }
}