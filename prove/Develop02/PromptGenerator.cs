using System;

class PromptGenerator
{
    private Random _randomGen = new Random();
    public List<string> _prompts = new List<string>() {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "Who did you meet today?",
        "How did I see the hand of the Lord in my life today?",
        "What was the funniest part of the day?",
        "What was the strongest emotion I felt today?",
        "What was the biggest challenge you faced today?",
        "If I had one thing I could do over today, what would it be?"
    }; 

    
    public string GetRandomPrompt() {
        Console.WriteLine($"the size of list is: {this._prompts.Count}");
        int randomIndex = _randomGen.Next(0, this._prompts.Count);
        return this._prompts[randomIndex];
    }
}