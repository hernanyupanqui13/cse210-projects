/*
I checked if there was a empty list in the listing activity before saving it and counting as completed

*/

using System;

class Program
{
    static void Main(string[] args)
    {
        RunApp();
    }

    private static void RunApp()
    {
        Console.Clear();
        string choice = DisplayMenuAndGetChoice();

        switch (choice)
        {
            case "1":
                Console.Clear();
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();
                RunApp();
                break;
            case "2":
                Console.Clear();
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
                reflectingActivity.DisplayEndingMessage();
                RunApp();
                break;
            case "3":
                Console.Clear();
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                listingActivity.DisplayEndingMessage();
                RunApp();
                break;
            case "4":
                Console.WriteLine("Goodbye!");
                break;
            default:
                Console.WriteLine("You didn't select a valid option. Try again");
                RunApp();
                break;
        }
    }

    private static string DisplayMenuAndGetChoice()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");

        Console.Write("Select a choice from the menu: ");
        return Console.ReadLine();
    }
}