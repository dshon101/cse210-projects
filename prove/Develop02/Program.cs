using System;

class Program
{
    static void Main(string[] args)
    {
        Entry userEntry = new Entry();
        Journal theJournal = new Journal();

        string input = "0";
        while (input != "5")
        {
            Console.WriteLine(
                $"{"\nPlease enter a number from the menu.\n"}{"\nMenu"}{"\n1 - Journal Entry"}{"\n2 - Display Journal"}{"\n3 - Save to a File"}{"\n4 - Retrieve from a File"}{"\n5 - Quit"}"
                );
            input = Console.ReadLine();
            if (input == "1")
            {
                theJournal.AddEntry();
            }
            else if (input == "2")
            {
                theJournal.DisplayAll();
            }
            else if (input == "3")
            {
                Console.Write("File to save: ");
                string fileName = Console.ReadLine();
                theJournal.SaveToFile(fileName);
            }
            else if (input == "4")
            {
                Console.Write("File to open: ");
                string fileName = Console.ReadLine();
                theJournal.LoadFromFile(fileName);
            }
        }
    }
}