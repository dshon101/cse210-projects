using System;  
using System.Collections.Generic;  

public class ReflectingActivity : Activity  
{  
    private List<string> _questions;  

    public ReflectingActivity(int duration)   
        : base("Reflecting Activity", "This activity allows you to reflect on deeper questions.", duration)  
    {  
        _questions = new List<string>  
        {  
            "What did you learn from your experience?",  
            "How did you grow from it?",  
            "What would you do differently?",  
            "How can you apply this in the future?"  
        };  
    }  

    public void Run()  
    {  
        DisplayStartingMessage();  
        ShowCountDown(3); // Show a 3-second countdown before starting  
        
        foreach (var question in _questions)  
        {  
            Console.WriteLine($"Question: {question}"); 
            Console.WriteLine("Take a moment to reflect...");  
            ShowSpinner(15); // 5 seconds for reflection  
            Console.WriteLine();
        }  

        DisplayEndingMessage();  
    }  

    public string GetRandomQuestion()  
    {  
        Random rand = new Random();  
        return _questions[rand.Next(_questions.Count)];  
    } 

    // public void DisplayQuestions()  
    // {  
    // }  
}  