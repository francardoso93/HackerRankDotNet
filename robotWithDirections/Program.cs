using System;

namespace robotWithDirections
{
    class Robot
    {
        public bool walk(string commands)
        {
            int direction = 0; // 0 = Norte. 1 = Leste. 2 = Sul. 3 = Oeste

            // Plano carteseano. Para ser circular, o robô precisa necessariamente voltar para esse ponto.
            int x = 0;
            int y = 0;
            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == 'R')
                {
                    direction = (direction + 1) % 4; // 0%4=0; 1%4=1; 2%4=2; 3%4=3;  //// 4%4=0; 5%4=1 ...; // Não adianta só somar ou subtrair 4 por causa dos números grandes. Com o módulo, sempre o resultado vai ser entre 1 e 3, independente do tamanho do número.
                }
                else if (commands[i] == 'L')
                {
                    direction = (4 + direction - 1) % 4; // Já começo do 4 que significa um volta completa // 4 + 3 = 7 // 7%4=3 (7/4=1)
                }
                else if (commands[i] == 'G')
                {
                    switch (direction)
                    {
                        case 0:
                            y++;
                            break;
                        case 1:
                            x++;
                            break;

                        case 2:
                            y--;
                            break;

                        case 3:
                            x--;
                            break;
                    }
                }
                else
                {
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
            Console.WriteLine(robot.walk("GLGLGLG"));
        }
    }
}
