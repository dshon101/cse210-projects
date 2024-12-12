using System;
using System.Collections.Generic;  

namespace ScriptureMemoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a sample scripture reference and text  
            Reference reference = new Reference("Proverbs", 3, 5, 6);  
            Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart, and lean not on your own understanding.");  

            Console.Clear();  
            Console.WriteLine(scripture.GetDisplayText());  

            while (true)  
                {  
                Console.WriteLine("Press Enter to hide words or type 'quit' to exit:");  
                string input = Console.ReadLine();  

                if (input.ToLower() == "quit")  
                {  
                    break;  
                }  

                if (!scripture.IsCompletelyHidden())  
                {  
                    scripture.HideRandomWords(1); // Hide 1 random word  
                    Console.Clear();  
                    Console.WriteLine(scripture.GetDisplayText());  
                }  
            }  

            Console.WriteLine("Final scripture view:");  
            Console.WriteLine(scripture.GetDisplayText());  
        }  
    }
}