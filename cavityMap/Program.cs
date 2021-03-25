using System;

class Solution
{

    //https://www.hackerrank.com/challenges/cavity-map/problem
    // TODO: Otimização. Já iniciar tudo como número pra não precisar ficar convertendo.
    // Complete the cavityMap function below.
    static void cavityMap(string[] grid)
    {
        for (int row = 0; row < grid.Length; row++)
        {
            for (int column = 0; column < grid.Length; column++)
            {
                if ((row >= 1 && row < grid.Length - 1) && (column >= 1 && column < grid.Length - 1))
                {
                    int number = int.Parse(grid[row][column].ToString());
                    int upperNumber = int.Parse(grid[row - 1][column].ToString());
                    int leftNumber = int.Parse(grid[row][column - 1].ToString());
                    int rightNumber = int.Parse(grid[row][column + 1].ToString());
                    int bottomNumber = int.Parse(grid[row + 1][column].ToString());
                    PrintCurrentValueOrX(row, column, number, upperNumber, leftNumber, rightNumber, bottomNumber);
                } else {
                    Console.Write(grid[row][column]);
                }
            }
            Console.WriteLine(); // Pula linha
        }
    }

    private static void PrintCurrentValueOrX(int row, int column, int number, int upperNumber, int leftNumber, int rightNumber, int bottomNumber)
    {
        if (number > leftNumber && number > rightNumber && number > upperNumber && number > bottomNumber)
        {
            Console.Write("X");
        }
        else
        {
            Console.Write(number);
        }
    }

    static void Main(string[] args)
    {
        // int n = Convert.ToInt32(Console.ReadLine());

        // string[] grid = new string[n];

        // for (int i = 0; i < n; i++)
        // {
        //     string gridItem = Console.ReadLine();
        //     grid[i] = gridItem;
        // }

        // string[] result = cavityMap(grid);
        // cavityMap(new string[] { "989", "191", "111" });
        cavityMap(new string[] { "1112", "1912", "1892", "1234" });
    }
}
