/*
- I checked if there was a empty list in the listing activity before saving it and counting as completed
- I saved the finished activities in a external JSON file. This was hard to do because only public fields were allowed to be saved.
To solve that I had to add the JsonInclude attribute to the fields I wanted to save. That took some research, but I learned more
about private fields. 
- I created a new class ActivityLog, and it shows, save, and loads the activity log
*/

using System;

class Program
{
    private static ActivityLog activityLog;
    static void Main(string[] args)
    { 
        LoadActivityLog();
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
                activityLog.IncrementBreathingActivitiesFinished();
                RunApp();
                break;
            case "2":
                Console.Clear();
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
                reflectingActivity.DisplayEndingMessage();
                activityLog.IncrementReflectingActivitiesFinished();
                RunApp();
                break;
            case "3":
                Console.Clear();
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                listingActivity.DisplayEndingMessage();
                activityLog.IncrementListingActivitiesFinished();
                RunApp();
                break;
            case "4":
                Console.Clear();
                activityLog.DisplayLog();
                Console.WriteLine("Press Enter to return to the main menu");
                Console.ReadLine();
                RunApp();
                break;
            case "5":
                Console.WriteLine("Saving your progress...");
                activityLog.SaveToFile();
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
        Console.WriteLine("  4. Show Activity Log");
        Console.WriteLine("  5. Quit");


        Console.Write("Select a choice from the menu: ");
        return Console.ReadLine();
    }

    // Loads the activity log from a file if it exists, otherwise creates a new one
    private static void LoadActivityLog() {
        activityLog = ActivityLog.GetActivityLogFromFileOrNull();
        if (activityLog == null) {
            Console.WriteLine("Sorry. We couldn't load the previous data. Please Enter con continue");
            Console.ReadLine();
            activityLog = new ActivityLog();
        }
    }
}