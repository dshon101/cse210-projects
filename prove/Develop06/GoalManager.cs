[Serializable]  
public class GoalManager  
{  
    private List<Goal> _goals = new List<Goal>();  
    private int _score;  

    public void DisplayMenu()  
    {  
        Console.WriteLine("\nWelcome to the Eternal Quest!");  
        Console.WriteLine("1. Create a new goal");  
        Console.WriteLine("2. Record an event for a goal");  
        Console.WriteLine("3. View all goals");  
        Console.WriteLine("4. Save goals");  
        Console.WriteLine("5. Load goals");  
        Console.WriteLine("6. Exit");  
        Console.Write("Please select an option: ");  
    }  

    public int GetValidInteger(string prompt)  
    {  
        int result;  
        Console.Write(prompt);  
        while (!int.TryParse(Console.ReadLine(), out result) || result < 0)  
        {  
            Console.Write("Invalid input. " + prompt);  
        }  
        return result;  
    }  

    public void DisplayPlayerInfo()  
    {  
        Console.WriteLine($"\nCurrent Score: {_score}");  
        foreach (var goal in _goals)  
        {  
            Console.WriteLine(goal.GetStringRepresentation());  
        }  
    }  

    public void CreateGoal(string type)  
    {  
        Console.Write("Enter the goal name: ");  
        string name = Console.ReadLine();  
        Console.Write("Enter the goal description: ");  
        string description = Console.ReadLine();  
        int points = GetValidInteger("Enter points for this goal: ");  

        Goal newGoal = null; // Initialize newGoal as null  

        if (type == "simple")  
        {  
            newGoal = new SimpleGoal(name, description, points);  
        }  
        else if (type == "eternal")  
        {  
            newGoal = new EternalGoal(name, description, points);  
        }  
        else if (type == "checklist")  
        {  
            int target = GetValidInteger("Enter the target completions: ");  
            int bonus = GetValidInteger("Enter bonus points for completion: ");  
            newGoal = new ChecklistGoal(name, description, points, target, bonus);  
        }  

        if (newGoal != null)  
        {  
            _goals.Add(newGoal);  
            Console.WriteLine($"Goal '{name}' created successfully!");  
        }  
        else  
        {  
            Console.WriteLine("Error creating goal.");  
        }  
    }  

    public void RecordEvent(string name)  
    {  
        var goal = _goals.Find(g => g.GetStringRepresentation().Contains(name));  
        if (goal != null)  
        {  
            goal.RecordEvent();  
            _score += goal.IsComplete() ? goal.Points : 0; // Add points if goal is completed  
        }  
        else  
        {  
            Console.WriteLine("Goal not found.");  
        }  
    }  

    public void SaveGoals(string fileName)  
    {  
        using (StreamWriter writer = new StreamWriter(fileName))  
        {  
            writer.WriteLine(_goals.Count); // Write the number of goals  
            foreach (var goal in _goals)  
            {  
                writer.WriteLine(goal.GetDetailsString()); // Save the details of each goal  
            }  
        }  
        Console.WriteLine("Goals saved successfully.");  
    }  

    public void LoadGoals(string fileName)  
    {  
        if (File.Exists(fileName))  
        {  
            using (StreamReader reader = new StreamReader(fileName))  
            {  
                int goalCount = int.Parse(reader.ReadLine()); // Read the number of goals  
                // _goals.Clear(); // Clear existing goals
                
                for (int i = 0; i < goalCount; i++)  
                {  
                    string line = reader.ReadLine();  
                    string[] parts = line.Split(" - "); // Split by the delimiter to reconstruct each goal  
                    if (parts.Length >= 3)  
                    {  
                        string name = parts[0];   
                        string description = parts[1];   
                        int points = int.Parse(parts[2].Split(' ')[0]); // Get the points  
                        Goal loadedGoal = null;  

                        // Determine the goal type based on the details  
                        if (line.Contains("(Simple Goal)"))  
                            loadedGoal = new SimpleGoal(name, description, points);  
                        else if (line.Contains("(Eternal Goal)"))  
                            loadedGoal = new EternalGoal(name, description, points);  
                        else if (line.Contains("(Checklist Goal)"))  
                        {  
                            // Extract checklist-specific data. This assumes a specific structure.  
                            int completed = int.Parse(parts[2].Split('/')[0]);  
                            int target = int.Parse(parts[2].Split('/')[1]);  
                            int bonus = int.Parse(parts[2].Split(':')[1].Trim());  
                            loadedGoal = new ChecklistGoal(name, description, points, target, bonus);  
                        }  
                        
                        if (loadedGoal != null)  
                        {  
                            _goals.Add(loadedGoal);  
                            Console.WriteLine($"Goal '{name}' loaded successfully!");
                        }  
                    }  
                }  
            }  
            Console.WriteLine("Goals loaded successfully.");  
        }  
        else  
        {  
            Console.WriteLine("File not found.");  
        }  
    }  
} 