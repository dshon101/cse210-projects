using System;  
using System.Collections.Generic;  

namespace FitnessTracker  
{   
    class Program  
    {  
        static void Main()  
        {  
            // Create a list of activities  
            List<Activity> activities = new List<Activity>  
            {  
                new Running(new DateTime(2022, 11, 3), 30, 3.0),   // Running for 30 min, 3.0 miles  
                new Cycling(new DateTime(2022, 11, 4), 45, 15.0),  // Cycling for 45 min at 15 mph  
                new Swimming(new DateTime(2022, 11, 5), 30, 20)     // Swimming for 30 min, 20 laps  
            };  

            // Displaying summary for each activity  
            foreach (var activity in activities)  
            {  
                Console.WriteLine(activity.GetSummary());  
            }  
        }  
    }  
}  
