using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        DisplayResult(userName, SquareNumber(userNumber));

        static void DisplayWelcomeMessage() {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName() {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber() {
            Console.Write("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

        static int SquareNumber(int number) {
            int result = number * number;
            return result;
        }

        static void DisplayResult(string name, int numberSquared){
            string display = $"{name}, the square of your number is {numberSquared}";
            Console.WriteLine(display);
        }
    }
}