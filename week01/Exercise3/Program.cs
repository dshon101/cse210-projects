using System;

class Program
{
    static void Main(string[] args)
    {
        string keepPlaying = "yes";

        while (keepPlaying == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int guessCount = 0;

            int guessedNumber = -1;

            while (!(guessedNumber == magicNumber))
            {
                Console.Write("What is your guess? ");
                string userInput = Console.ReadLine();
                guessedNumber = int.Parse(userInput);

                guessCount = guessCount++;
                string higherOrLower = " ";

                if (guessedNumber < magicNumber)
                {
                    higherOrLower = "Higher";
                }
                else if (guessedNumber > magicNumber)
                {
                    higherOrLower = "Lower";
                }
                else
                {
                    higherOrLower = "You guessed it! ";
                }

                Console.WriteLine(higherOrLower);
            }

            Console.WriteLine($"It took you {guessCount} guesses");

            Console.Write("Would you like to play again (yes/no)? ");
            keepPlaying = Console.ReadLine();
        }

        Console.WriteLine("Thank you for playing. Goodbye.");
    }
}