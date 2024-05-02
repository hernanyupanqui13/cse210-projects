using System;
using System.Text.Json;
class Journal
{
    public List<Entry> _entries { get; set; } = new List<Entry>(); 

    // Adds a new entry to the journal 
    public void AddEntry (Entry newEntry)
    {
        this._entries.Add(newEntry);
    }

    // Displays all the entries inside the journal
    public void DisplayAll()
    {
        Console.WriteLine(); 
        foreach (Entry entry in this._entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }


    // Saving the journals and entries in a JSON file
    public void SaveToFile(string file)
    {
        string jsonString = JsonSerializer.Serialize<Journal>(this); 
        using (StreamWriter outputFile = new StreamWriter(file + ".json"))
        {
            outputFile.WriteLine(jsonString); 
            Console.WriteLine("Saved successfully!"); 
        }
    }


    // Loading the file with the data in JSON format
    public void LoadFromFile(string file)
    {
        try
        {
            // Obtaining the JSON string
            string[] lines = System.IO.File.ReadAllLines(file);
            string jsonAsString = "";
            
            foreach (string item in lines)
            {
                jsonAsString += item;
            }

            Journal journal = JsonSerializer.Deserialize<Journal>(jsonAsString); 
            
            // Trying to make a deep copy
            this._entries = null; // Cleaning the entries to have the ones of the JSON file
            
            this._entries = journal._entries.ConvertAll( entry => new Entry(){
                _date = entry._date,
                _entryText = entry._date,
                _promptText = entry._promptText
            });
        }
        catch (System.Exception)
        {
            Console.WriteLine();
            Console.WriteLine("Sorry, that filename doesn't exist"); 
            Console.WriteLine();
        }
        

    }

}