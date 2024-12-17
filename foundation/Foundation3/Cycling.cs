using System;  
using System.Collections.Generic;  

namespace FitnessTracker  
{
    public class Cycling : Activity  
    {  
        private double _speed; // in mph  

        public Cycling(DateTime date, int minutes, double speed)   
            : base(date, minutes)  
        {  
            _speed = speed;  
        }  

        public override double GetDistance()  
            => _speed * _minutes / 60; // Distance in miles  

        public override double GetSpeed() => _speed;  

        public override double GetPace()   
            => 60 / GetSpeed(); // Pace in min per mile  

        // private int Minutes => (int)(60.0 * (base.GetType() == typeof(Cycling) ? ((Cycling)this)._minutes : 0));  
    }  
}