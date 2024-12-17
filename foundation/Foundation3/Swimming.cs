using System;  
using System.Collections.Generic;  

namespace FitnessTracker  
{
    public class Swimming : Activity  
    {  
        private int _laps; // Number of laps  

        public Swimming(DateTime date, int minutes, int laps)   
            : base(date, minutes)  
        {  
            _laps = laps;  
        }  

        public override double GetDistance()   
            => (_laps * (50 / 1000.0) * 0.62); // Distance in miles   

        public override double GetSpeed()   
            => (GetDistance() / _minutes) * 60; // Speed in mph  

        public override double GetPace()   
            => _minutes / GetDistance(); // Pace in min per mile   

        // private int Minutes => (int)(60.0 * (base.GetType() == typeof(Swimming) ? ((Swimming)this)._minutes : 0));  
    }
}