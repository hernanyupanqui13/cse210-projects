/*
- I am using JSON to save and load the file in the computer
- I am using constructors to create a new entry created by the user
- I added more prompts
- I added a try/catch statement to avoid breaking the app if the filename doesn't exist

*/


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal program!");

        PromptGenerator promptGenerator = new PromptGenerator(); 
        Journal journal = new Journal();
        string optionChosen = "";

        do
        {
            optionChosen = ShowMenu(); 
            if (optionChosen == "1")  // WRITE
            {
                string randomPrompt = promptGenerator.GetRandomPrompt(); 
                Console.WriteLine(randomPrompt); 
                string newEntryText = Console.ReadLine();
                Entry newEntry = new Entry(randomPrompt, newEntryText); 
                journal.AddEntry(newEntry);
                
            } else if (optionChosen == "2") // DISPLAY
            {
                journal.DisplayAll(); 
            } else if (optionChosen == "3")  // LOAD
            {
                Console.Write("What is the filename? "); 
                string fileName = Console.ReadLine(); 
                // Giving the extension to the filename
                fileName += ".json";
                journal.LoadFromFile(fileName);

            } else if (optionChosen == "4")  // SAVE
            {
                Console.Write("What is the filename? "); 
                string fileName = Console.ReadLine(); 
                journal.SaveToFile(fileName); 
            } else if (optionChosen == "5") // QUIT
            { 
                Console.WriteLine("Thanks for using the app! Have a nice day"); 
            } else 
            {
                Console.WriteLine("You didn't select the right option, please try again"); 
            }
        } while (optionChosen != "5"); 
        

        
    }

    // Shows the menu each time we need it and returns the option the user entered
    public static string ShowMenu()
    {
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.Write("What would you like to do? ");

        string response = Console.ReadLine(); 

        return response; 
    }
}