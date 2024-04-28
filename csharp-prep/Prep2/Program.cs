using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your percentage grade?");
        int percentageGrade = int.Parse(Console.ReadLine());

        // Determining thr grade
        if (percentageGrade >= 90) {
            Console.WriteLine($"Your grade is A");
        } else if (percentageGrade >= 80) {
            Console.WriteLine($"Your grade is B");
        } else if (percentageGrade >= 70) {
            Console.WriteLine($"Your grade is C");
        } else if (percentageGrade >= 60) {
            Console.WriteLine($"Your grade is D");
        } else {
            Console.WriteLine($"Your grade is F");
        }

        // Determining if passed or failed
        if (percentageGrade >= 70) {
            Console.WriteLine("You passed the course. Congratulations!");
        } else {
            Console.WriteLine("You did't pass the course. You have to study more! You can do it if you try harder");
        }
    }
}