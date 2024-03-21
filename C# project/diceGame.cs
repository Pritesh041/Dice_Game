using System;

class diceGame
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int playerScore = 0;
        int playerBalance = 200;

        Console.WriteLine("Welcome to the Dice Game!");

        while (true)
        {
            Console.WriteLine("\nPress any key to roll the dice or 'Esc' to exit...");
            ConsoleKeyInfo key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.Escape)
            {
                Console.WriteLine($"Game over. Your final score is: {playerScore}");
                break;
            }

            if (playerBalance == 0)
            {
                Console.WriteLine($"Your Balance is: {playerBalance} so, you can't play the game :(");
            }
            else
            {
                int userNumber;
                while (true)
                {
                    playerBalance -= 20;
                    Console.Write("Enter your number (1 to 6): ");
                    if (int.TryParse(Console.ReadLine(), out userNumber) && userNumber >= 1 && userNumber <= 6)
                        break;
                    else
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
                }

                int computerNumber = random.Next(1, 7);

                Console.WriteLine($"Computer number is: {computerNumber}");

                if (userNumber == computerNumber)
                {
                    playerScore += 5;
                    Console.WriteLine($"Congratulations! You won the game. Your score is: {playerScore}");
                    playerBalance += 50;
                    Console.WriteLine($"Your updated balance is: {playerBalance}");
                }
                else
                {
                    Console.WriteLine($"Ohh!, you loose the game. Your score is: {playerScore}");
                    Console.WriteLine($"Your updated balance is: {playerBalance}");
                }

                if (playerScore >= 1000)
                {
                    Console.WriteLine("Congratulations! You won 100$");
                    playerBalance += 100;
                }
            }
        }
    }
}
