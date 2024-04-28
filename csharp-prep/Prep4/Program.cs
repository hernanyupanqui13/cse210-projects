using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> listOfNumbers = new List<int>();
        int numberToBeAdded = -1;

        while (numberToBeAdded != 0) {
            Console.Write("Enter number: ");
            numberToBeAdded = int.Parse(Console.ReadLine());

            if (numberToBeAdded != 0 ) {
                listOfNumbers.Add(numberToBeAdded); 
            }
        }  

        int sum = 0;
        int largestNumber = 0; 
        foreach (int number in listOfNumbers) {
            sum += number;
            if (number > largestNumber) {
                largestNumber = number; 
            }
        }
        float average = ((float) sum) / listOfNumbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");

    }
}