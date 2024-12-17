using System;  
using System.Collections.Generic;  

namespace FitnessTracker  
{  
    public class Running : Activity  
    {  
        private double _distance; // in miles  

        public Running(DateTime date, int minutes, double distance)   
            : base(date, minutes)  
        {  
            _distance = distance;  
        }  

        public override double GetDistance() => _distance;  

        public override double GetSpeed()   
            => (GetDistance() / _minutes) * 60; // Speed in mph  

        public override double GetPace()   
            => (double)_minutes / GetDistance(); // Pace in min per mile  

        // private int Minutes => (int)(60.0 * (base.GetType() == typeof(Running) ? ((Running)this)._minutes : 0));  
    }  
}