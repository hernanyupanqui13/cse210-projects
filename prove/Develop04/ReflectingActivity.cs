public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>() {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfles."
    };
    private List<string> _questions = new List<string>() {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private Random _randomGen = new Random();


    public ReflectingActivity()
    {
        this._name = "Reflecting Activity";
        this._description = "his activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        this.DisplayStartingMessage();
    }

    public void Run()
    {
        this.GetReadyMessage();
        this.DisplayPrompt();
        Console.Clear();
        this.DisplayQuestion();

    }

    public string GetRandomPrompt()
    {
        int randomIndex = _randomGen.Next(0, this._prompts.Count);
        return this._prompts[randomIndex];
    }

    public string GetRandomQuestion()
    {
        int randomIndex = _randomGen.Next(0, this._questions.Count);
        return this._questions[randomIndex];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider this following prompt: ");
        Console.WriteLine();
        Console.WriteLine($"--- {this.GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue: ");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        this.ShowCountDown(5);
    }

    public void DisplayQuestion()
    {
        DateTime endTime = DateTime.Now.AddSeconds(this.GetDuration());

        while (DateTime.Now < endTime) {
            Console.Write($"> {this.GetRandomQuestion()}");
            this.ShowSpinner(5);
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}