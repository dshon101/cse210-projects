using System;  
using System.Collections.Generic;  

public class ListingActivity : Activity  
{  
    private List<string> _prompts;  

    public ListingActivity(int duration)   
        : base("Listing Activity", "This activity encourages you to reflect by listing things.", duration)  
    {  
        _prompts = new List<string>  
        {  
            "What are you grateful for?",  
            "What accomplishments are you proud of?",  
            "What brings you joy?",  
            "What challenges have you overcome?"  
        };  
    }  

    public void Run()  
    {  
        DisplayStartingMessage();  
        ShowCountDown(3); // Show a 3-second countdown before starting  
        
        Console.WriteLine("Think about the following prompts:");  
        foreach (var prompt in _prompts)  
        {  
            Console.WriteLine($"- {prompt}");
            Thread.Sleep(10000); 
        }  

        DisplayEndingMessage();  
    }  

    public string GetRandomPrompt()  
    {  
        Random rand = new Random();  
        return _prompts[rand.Next(_prompts.Count)];  
    }  
  
    public List<string> GetListFromUser()  
    {  
        return new List<string>();  
    }  
}  