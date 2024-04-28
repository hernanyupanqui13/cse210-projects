using System;

class Program
{
    static void Main(string[] args)
    {
        //Getting data
        Console.WriteLine("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.WriteLine("What is your last name? ");
        string lastName = Console.ReadLine();
        string response = $"Your name is {lastName}, {firstName} {lastName}."; 

        //Showing the result
        Console.WriteLine();
        Console.WriteLine(response);
    }
}