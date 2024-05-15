using System;

using System.Text.Json;
using System.Text.Json.Serialization;

[Serializable()]
public class ActivityLog
{
    [JsonInclude]
    private int _breathingActivitiesFinished {get; set;} = 0;
    [JsonInclude]
    private int _reflectingActivitiesFinished {get; set;} = 0;
    [JsonInclude]
    private int _listingActivitiesFinished {get; set;} = 0;

    public int GetBreathingActivitiesFinished() {
        return this._breathingActivitiesFinished;
    }

    public void IncrementBreathingActivitiesFinished() {
        this._breathingActivitiesFinished += 1;
    }
    public int GetReflectingActivitiesFinished() {
        return this._reflectingActivitiesFinished;
    }
    public void IncrementReflectingActivitiesFinished() {
        this._reflectingActivitiesFinished += 1;
    }
    public int GetListingActivitiesFinished() {
        return this._listingActivitiesFinished;
    }
    public void IncrementListingActivitiesFinished() {
        this._listingActivitiesFinished += 1;
    }   
    public static ActivityLog GetActivityLogFromFileOrNull() {
        const string FilePath = "data.json";
        
        try
        {
            // Obtaining the JSON string
            string[] lines = System.IO.File.ReadAllLines(FilePath);
            string jsonAsString = "";
            
            foreach (string item in lines)
            {
                jsonAsString += item;
            }

            ActivityLog activityLog = JsonSerializer.Deserialize<ActivityLog>(jsonAsString); 
            
            return activityLog;
        } catch (System.Exception)
        {
            return null;
        }
    }


    public void SaveToFile() {
        const string FilePath = "data.json";
        string jsonString = JsonSerializer.Serialize<ActivityLog>(this); 
        using (StreamWriter outputFile = new StreamWriter(FilePath))
        {
            outputFile.WriteLine(jsonString); 
            Console.WriteLine("All your progress was saved successfully!"); 
        }

    }

    public void DisplayLog() {
        Console.WriteLine();
        Console.WriteLine("Your progress:");
        Console.WriteLine();
        Console.WriteLine($"Breathing activities finished: {_breathingActivitiesFinished}");
        Console.WriteLine($"Reflecting activities finished: {_reflectingActivitiesFinished}");
        Console.WriteLine($"Listing activities finished: {_listingActivitiesFinished}");
        Console.WriteLine();
    }
}