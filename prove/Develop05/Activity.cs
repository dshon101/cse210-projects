using System.Collections.Generic;  
using System.Threading; 

public class Activity  
{  
    private string _name;  
    private string _description;  
    private int _duration;  

    public Activity(string name, string description, int duration)  
    { 
        _name = name;  
        _description = description;  
        _duration = duration; 
    }  

    public void DisplayStartingMessage()  
    {  
        Console.WriteLine($"Welcome to the {_name} activity!");  
        Console.WriteLine(_description);  
        Console.WriteLine($"This activity will last for {_duration} seconds."); 
    }  

    public void DisplayEndingMessage()  
    {  
        Console.WriteLine("Good job! You have completed this activity.");
    }  

    public void ShowSpinner(int seconds)  
    {  
        Console.Write("Processing "); 
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");

        foreach (string s in spinner)  
        {
            Console.Write(s);
            Thread.Sleep(1000);  
            Console.Write("\b \b");  
        }  
        Console.WriteLine(); 
    }  

    public void ShowCountDown(int seconds)  
    {  
        for (int i = seconds; i > 0; i--)  
        {  
            Console.Write(i);  
            Thread.Sleep(1000);  
            Console.Write("\b\b \b");
        }  
        Console.WriteLine("Let's begin!");
    }  
}  