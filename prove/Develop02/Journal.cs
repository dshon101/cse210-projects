using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        PromptMessage newPrompt = new PromptMessage();
        Entry newEntry = new Entry();

        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        newEntry._date = $"{today}";

        newEntry._promptText = newPrompt.GetRandomPrompt();

        Console.Write(newEntry._promptText);
        string post = Console.ReadLine();
        newEntry._entryText = post;

        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter journalFile = new StreamWriter(file))
        foreach (Entry entry in _entries)
        {
            journalFile.WriteLine ($"{entry._date}--{entry._promptText}--{entry._entryText}");
        }
    }
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        _entries = [];

        foreach (string line in lines)
        {
            Entry fileEntry = new Entry();
            string[] journalParts = line.Split("--");

            fileEntry._date = journalParts[0];
            fileEntry._promptText = journalParts[1];
            fileEntry._entryText = journalParts[2];

            _entries.Add(fileEntry); // Add it to the entries list
        }
    }
}