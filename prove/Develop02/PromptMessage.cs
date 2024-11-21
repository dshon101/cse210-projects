using System;


public class PromptMessage 
{  
    private List<string> _prompts = new List<string>  
    {  
        "Who was the most interesting person I interacted with today?\n",
        "What was the best part of my day?\n",
        "How did I see the hand of the Lord in my life today?\n",
        "What was the strongest emotion I felt today?\n",
        "If I had one thing I could do over today, what would it be?\n",
        "What made you smile today?\n",  
        "What are you grateful for today?\n",  
        "What is a challenge you've overcome today?\n",  
        "Describe a favorite memory that you had today.\n"
    };  

    public string GetRandomPrompt()  
    {  
        Random random = new Random();  
        int index = random.Next(_prompts.Count);  
        return _prompts[index];  
    }  
} 