using System;  
using System.Collections.Generic;  

namespace FitnessTracker  
{
    public abstract class Activity  
        {  
            // Private member variables  
            private DateTime _date;  
            protected int _minutes;  

            // Constructor  
            protected Activity(DateTime date, int minutes)  
            {  
                _date = date;  
                _minutes = minutes;  
            }  

            // Public methods to get distance, speed, and pace  
            public abstract double GetDistance();  
            public abstract double GetSpeed();  
            public abstract double GetPace();  

            // Method to get summary  
            public virtual string GetSummary()  
            {  
                return $"{_date:dd MMM yyyy} {GetType().Name} ({_minutes} min) - " +  
                       $"Distance: {GetDistance():F1} miles, " +  
                       $"Speed: {GetSpeed():F1} mph, " +  
                       $"Pace: {GetPace():F1} min per mile";  
            }  
        } 
} 