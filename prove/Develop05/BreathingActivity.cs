public class BreathingActivity : Activity  
{  
    public BreathingActivity(int duration) : base("Breathing Activity", "This activity helps you relax by focusing on your breathing.", duration)  
    {  
    }  

    public void Run()  
    {  
        DisplayStartingMessage();  
        ShowCountDown(3); // Show a 3-second countdown before starting  
        
        Console.WriteLine("Breathe in... ");  
        ShowSpinner(5); // 5 seconds of breathing in  
        Console.WriteLine("Breathe out... ");  
        ShowSpinner(5); // 5 seconds of breathing out  
        Console.WriteLine();
        
        DisplayEndingMessage();  
    }  
}   
