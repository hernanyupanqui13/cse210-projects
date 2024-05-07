using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Reference reference1 = new Reference("Genesis", 1, 1);
        Console.WriteLine($"Reference 1: {reference1.GetDisplayText()}");

        Scripture scripture1 = new Scripture(reference1, "Y puso Adán nombre a toda bestia y ave de los cielos y a todo animal del campo; mas para Adán no se halló ayuda que fuese idónea para él. Y Jehová Dios hizo caer un sueño profundo sobre Adán, y este se quedó dormido. Entonces tomó una de sus costillas y cerró la carne en su lugar;");
        Console.WriteLine(scripture1.GetDisplayText());

        Console.WriteLine();

        bool wantToContinue = false;
        do
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            string userResponse = Console.ReadLine();
            if (userResponse == "quit")
            {
                wantToContinue = false;
            } else if (userResponse == "")
            {
                scripture1.HideRandomWords();
                Console.Clear();
                Console.WriteLine(scripture1.GetDisplayText());
                Console.WriteLine();
                wantToContinue = true;
            } else 
            {
                Console.Clear();
                Console.WriteLine(scripture1.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("You didn't select a valid option. Try again");
                wantToContinue = true;
            }
        } while (wantToContinue);




    }
}