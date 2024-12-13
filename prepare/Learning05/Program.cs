using System;
using assignments_demo;

class Program
{
    static void Main(string[] args)
    {
        // Create a base "Assignment" object
        Assignment assignment1 = new Assignment("Demetrious Shoniwa", "Inheritance");
        Console.WriteLine(assignment1.GetSummary());

         // Now create the derived class assignments
        MathAssignment mathAssignment1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());

         // Now create the derived class assignments
        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}