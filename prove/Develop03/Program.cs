using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Helaman", 5, 12);
        Scripture scripture1 = new Scripture(reference1, "Y ahora bien, recordad, hijos míos, recordad que es sobre la aroca de nuestro Redentor, el cual es Cristo, el Hijo de Dios, donde debéis establecer vuestro bfundamento, para que cuando el diablo lance sus impetuosos vientos, sí, sus dardos en el torbellino, sí, cuando todo su granizo y furiosa ctormenta os azoten, esto no tenga poder para arrastraros al abismo de miseria y angustia sin fin, a causa de la roca sobre la cual estáis edificados, que es un fundamento seguro, un fundamento sobre el cual, si los hombres edifican, no caerán");
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