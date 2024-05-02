using System;

class Entry
{
    public string _date { get; set; }
    public string _promptText { get; set; }
    public string _entryText { get; set; }

    // Constructor when the user is creating a new entry
    public Entry(string promptText, string entryText)
    {
        this._date = DateTime.Now.ToShortDateString(); 
        this._promptText = promptText;
        this._entryText = entryText;
    }

    // Basic constructor in case we want to pass the object with all the data. We use this for the deep clone
    public Entry()
    {
        
    }

    // Display each entry in the console log
    public void Display()
    {
        Console.WriteLine($"Date: {this._date} - Prompt: {this._promptText}");
        Console.WriteLine(this._entryText);

    }
}