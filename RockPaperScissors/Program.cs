namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerScore = 0, enemyScore = 0;
            char enemyChoise;

            while (playerScore != 3 && enemyScore != 3)
            {
                Console.WriteLine("Welcome to rock paper scissors!");
                Console.WriteLine();
                Console.WriteLine($"Player score: {playerScore}. Enemy score: {enemyScore}");
                Console.WriteLine("Please enter 'r' for rock, 'p' for paper or 's' for scissors.");
                char escolha = char.Parse(Console.ReadLine());
                if (escolha == 'r')
                {
                    enemyChoise = RandomString();
                    if (enemyChoise == 'r')
                    {
                        Console.WriteLine("Enemey choose rock");
                        Console.WriteLine("Tie!");
                    }
                    else if (enemyChoise == 'p')
                    {
                        Console.WriteLine("Enemy choose paper");
                        enemyScore++;
                        Console.WriteLine("Enemy win this round!");
                    }
                    else
                    {
                        Console.WriteLine("Enemey choose scissors!");
                        Console.WriteLine("Player win this round");
                        playerScore++;
                    }
                }
                else if (escolha == 'p')
                {
                    enemyChoise = RandomString();
                    if (enemyChoise == 'r')
                    {
                        Console.WriteLine("Enemey choose rock");
                        Console.WriteLine("player win this round!");
                        playerScore++;
                    }
                    else if (enemyChoise == 'p')
                    {
                        Console.WriteLine("Enemy choose paper");
                        Console.WriteLine("Tie!!");
                    }
                    else
                    {
                        Console.WriteLine("Enemey choose scissors!");
                        Console.WriteLine("Enemy win this round");
                        enemyScore++;
                    }
                }
                else
                {
                    enemyChoise = RandomString();
                    if (enemyChoise == 'r')
                    {
                        Console.WriteLine("Enemey choose rock");
                        Console.WriteLine("Enemy win this round!");
                        enemyScore++;
                    }
                    else if (enemyChoise == 'p')
                    {
                        Console.WriteLine("Enemy choose paper");
                        playerScore++;
                        Console.WriteLine("Player win this round!");
                    }
                    else
                    {
                        Console.WriteLine("Enemey choose scissors!");
                        Console.WriteLine("Tie!");
                    }
                }

            }
            if (playerScore == 3)
            {
                Console.WriteLine("GG you win!");
            }
            else if (enemyScore == 3)
            {
                Console.WriteLine("WP you lose!");
            }

        }

        public static char RandomString()
        {
            string chars = "rps";
            Random random = new Random();
            int num = random.Next(0, chars.Length);
            return chars[num];
        }
    }
}