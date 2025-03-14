using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> userNumbers = new List<int>();

        // creating variable to use for sum and largest number

        int userList = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        // using a while loop to keep on looping through the code 
        // if the user doesn't enter zero
        while (userList != 0)
        {
            Console.Write("Enter number: ");
            string userResponse = Console.ReadLine();
            userList = int.Parse(userResponse);

            // removing 0 from the list or 
            // not adding a zero to the list
            if (userList != 0)
            {
                userNumbers.Add(userList);
            }
        }

        // calculatinf the sum and looking for the largest number
        int sum = 0;

        foreach (int getNumber in userNumbers)
        {
            sum += getNumber;
        }
        Console.WriteLine($"The sum is: {sum}");

        // calculating the avarage.
        float average = ((float)sum) / userNumbers.Count;
        Console.WriteLine($"The Avarege is: {average}");

        // finding the maximum number.
        int largestNumber = 0;

        foreach (int getNumber in userNumbers)
        {
            if (getNumber > largestNumber)
            {
                largestNumber = getNumber;
            }
        }

        Console.WriteLine($"The largest number is: {largestNumber}");

        // finding the minmum
        int smallestNumber = 999999999;

        foreach (int getNumber in userNumbers)
        {
            if (getNumber < smallestNumber && getNumber > 0)
            {
                smallestNumber = getNumber;
            }
        }

        Console.WriteLine($"The smallest positive number is: {smallestNumber}");
    }
}