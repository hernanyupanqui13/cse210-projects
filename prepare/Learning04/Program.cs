using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        Console.WriteLine();
        MathAssignment mathAssignment1 = new MathAssignment("Samuel Bennett", "Multiplication", "1", "1.5");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());
        
        Console.WriteLine();
        WritingAssignment writingAssignment1 = new WritingAssignment("Jhon Smith", "History", "World War II");
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}