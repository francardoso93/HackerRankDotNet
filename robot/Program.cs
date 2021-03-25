using System;
using System.Collections.Generic;

namespace robot
{

    class Robot
    {
        public bool walk(string commands)
        {
            // Plano carteseano. Para ser circular, o robô precisa necessariamente voltar para esse ponto.
            int x = 0;
            int y = 0;
            for (int i = 0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case 'G': // y = 1
                        y++;
                        break;
                    case 'D':
                        y--;
                        break;
                    case 'R': // x = 2
                        x++;
                        break;
                    case 'L':
                        x--;
                        break;
                    default:
                        throw new ArgumentException("Invalid argument " + commands[i]);
                }

            }
            Console.WriteLine(x);
            Console.WriteLine(y);
            return x == 0 && y == 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var robot = new Robot();
            Console.WriteLine(robot.walk("GRRDDLLG")); // True
            Console.WriteLine(robot.walk("GDDRLLLLLLGDDDD")); // False
        }
    }
}
