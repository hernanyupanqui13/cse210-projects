using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Genesis", 1, 1);
        Scripture scripture1 = new Scripture(reference1, "Y puso Adán nombre a toda bestia y ave de los cielos y a todo animal del campo; mas para Adán no se halló ayuda que fuese idónea para él. Y Jehová Dios hizo caer un sueño profundo sobre Adán, y este se quedó dormido. Entonces tomó una de sus costillas y cerró la carne en su lugar;");
        Console.Clear();
        Console.WriteLine(scripture1.GetDisplayText());
        Console.WriteLine();

        bool wantToContinue = false;
        do
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string userResponse = Console.ReadLine();
            if (userResponse == "quit")
            {
                wantToContinue = false;
            } else if (userResponse == "")
            {
                int numberOfWordsToHide = GetNumberOfWordsToHidde(); 

                scripture1.HideRandomWords(numberOfWordsToHide);
                Console.Clear();
                Console.WriteLine(scripture1.GetDisplayText());
                Console.WriteLine();
                
                // Checking if we hide all the words to finish the program
                if (scripture1.IsCompleteHidden())
                {
                    Console.WriteLine("You have hidden all the words!");
                    wantToContinue = false;
                } else 
                {
                    wantToContinue = true;
                }
                
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

    private static int GetNumberOfWordsToHidde()
    {
        Console.WriteLine("How many words would you like to hide?");
        string numberToHideAsString = Console.ReadLine(); 
        numberToHideAsString = numberToHideAsString.Trim();
        int numberOfWordsToHide = 0;
        try
        {
            numberOfWordsToHide = Convert.ToInt32(numberToHideAsString);
            return numberOfWordsToHide;
        }
        catch (System.Exception)
        {
            Console.WriteLine("There was an error. Try again writing only the positive number without any other character. And try another number different than 0"); 
            return 0; 
        }

    }
}