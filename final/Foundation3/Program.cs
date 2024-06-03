using System;

class Program
{
    static void Main(string[] args)
    {
        // Create events
        Address address1 = new Address("123 Main St", "Cityville", "State", "Country");
        Lecture lecture = new Lecture("Introduction to Programming", "Learn the basics of programming", new DateTime(2023, 6, 1), "19:00 MST", address1, "John Doe", 50);

        Address address2 = new Address("456 Oak Rd", "Townsville", "Province", "Country");
        Reception reception = new Reception("Company Anniversary", "Celebrate our company's 10th anniversary", new DateTime(2023, 7, 15), "19:30 MST", address2, "rsvp@company.com");

        Address address3 = new Address("789 Park Ave", "Villagetown", "State", "Country");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Festival", "Enjoy live music, food, and activities", new DateTime(2023, 8, 20), "12:00 MST", address3, "Sunny with a high of 25°C");

        // Output event details
        Console.WriteLine("--------------");
        Console.WriteLine("Lecture:");
        Console.WriteLine("--------------");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine();
        Console.WriteLine("--------------");
        Console.WriteLine("Reception:");
        Console.WriteLine("--------------");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine();
        Console.WriteLine("--------------");
        Console.WriteLine("Outdoor Gathering:");
        Console.WriteLine("--------------");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}