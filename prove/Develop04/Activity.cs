using System.Diagnostics.CodeAnalysis;

public class Activity
{
    protected string _name;
    protected string _description;
    private int _duration;

    public Activity()
    {
    }

    public void DisplayStartingMessage() 
    {
        Console.WriteLine($"Welcome to the {this._name}");
        Console.WriteLine();
        Console.WriteLine(this._description);
        Console.WriteLine();
        this.SetDuration();
    }

    public void SetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        string durationAsString = Console.ReadLine();
        int durationAsInt;
        bool success = int.TryParse(durationAsString, out durationAsInt);
        if (success) {
            _duration = durationAsInt;
        } else {
            Console.WriteLine("You didn't select a valid number. Please try again");
            Console.WriteLine();
            this.SetDuration();
        }
        
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        this.ShowSpinner(2);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {this._duration} seconds of the {this._name}");
        this.ShowSpinner(5);

    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>() { "|", "/", "-", "\\" };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int index = 0;
        int milisecondsToSleep = 200;

        while (DateTime.Now < endTime) 
        {
            Console.Write(spinner[index]);
            Thread.Sleep(milisecondsToSleep);
            Console.Write("\b \b");
            index++;

            if (index == spinner.Count) index = 0;
        }

        
    }

    public void ShowCountDown(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int secondsCounter = seconds;
        int countDownStep = 1000; // in miliseconds

        while (DateTime.Now < endTime) 
        {
            Console.Write(secondsCounter);
            Thread.Sleep(countDownStep);
            Console.Write("\b \b");
            secondsCounter--;
        }
        
        Console.Write("\b \b");
    }

    public int GetDuration() {
        return this._duration;
    }

    public void GetReadyMessage() {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        this.ShowSpinner(4);
        Console.WriteLine();
        Console.WriteLine();
    }
}