public class ListingActivity : Activity
{
    private Random _randomGen = new Random();
    private int _count;
    private List<string> _prompts = new List<string>() {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        this._name = "Listing Activity";
        this._description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        this.DisplayStartingMessage();

    }

    public void Run()
    {
        this.GetReadyMessage();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"--- {this.GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        this.ShowCountDown(5);
        DateTime endTime = DateTime.Now.AddSeconds(this.GetDuration());
        Console.WriteLine();
        
        while (DateTime.Now < endTime) {
            Console.Write("> ");
            Console.ReadLine(); 
            this._count++;
        }
        
        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items!");


    }

    public string GetRandomPrompt()
    {
        int randomIndex = _randomGen.Next(0, this._prompts.Count);
        return this._prompts[randomIndex];
    }

    public List<string> GetListFromUser()
    {
        return new List<string>();
    }
}