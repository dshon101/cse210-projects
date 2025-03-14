using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userInputName = PromptUserInputName();
        int userNumber = PromptUserInputNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userInputName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Hello and Welcome to the program! Let's do some maths.");
    }

    static string PromptUserInputName()
    {
        Console.Write($"Hello, Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserInputNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int squre = number * number;

        return squre;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {square}");
    }
}