using System;
using System.Collections.Generic;  
using System.Threading; 

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 4)
        {
            Console.WriteLine("Select an activity:");  
            Console.WriteLine("1. Breathing Activity");  
            Console.WriteLine("2. Listing Activity");  
            Console.WriteLine("3. Reflecting Activity");  
            Console.WriteLine("4. Quit"); 
            Console.Write("Choose an option (1-4): ");  

            choice = int.Parse(Console.ReadLine());  
            // Console.Write("Enter duration (in seconds): ");  
            // int duration = int.Parse(Console.ReadLine());  
        
            // BreathingActivity b = new BreathingActivity(duration);
            // ListingActivity l = new ListingActivity(duration);
            // ReflectingActivity r = new ReflectingActivity(duration);


            if (choice == 1)
            {
                Console.Write("Enter duration (in seconds): ");  
                int duration = int.Parse(Console.ReadLine());
                BreathingActivity b = new BreathingActivity(duration);
                b.Run();
            } 

            else if (choice == 2)
            {
                Console.Write("Enter duration (in seconds): ");  
                int duration = int.Parse(Console.ReadLine());
                ListingActivity l = new ListingActivity(duration);
                l.Run();
            }
            else if (choice == 3)
            {
                Console.Write("Enter duration (in seconds): ");  
                int duration = int.Parse(Console.ReadLine());
                ReflectingActivity r = new ReflectingActivity(duration);
                r.Run();
            }
            else
            {
                break;
            }
        }
         
    }  
}
