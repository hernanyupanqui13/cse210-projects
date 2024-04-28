using System;

class Program
{
    static void Main(string[] args)
    {   
        Random random = new Random();

        //Console.Write("What is the magic number? ");
        int magicNumber = random.Next(1,100);
        int guessNumber = 0; 
        
        while (magicNumber != guessNumber) {
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());
            if (magicNumber > guessNumber) {
                Console.WriteLine("Higuer");
            } else {
                Console.WriteLine("Lower"); 
            }
        }

        Console.WriteLine("You did it!");
    }
}