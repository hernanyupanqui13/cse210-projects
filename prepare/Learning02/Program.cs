using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Resume resume = new Resume(); 
        resume._name = "Erick Gomez";

        Job job1 = new Job(); 
        job1._company = "Microsoft"; 
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2023; 
        resume._jobs.Add(job1);

        Job job2 = new Job(); 
        job2._company = "Google"; 
        job2._jobTitle = "Data Scientist";
        job2._startYear = 2019;
        job2._endYear = 2024; 
        resume._jobs.Add(job2);

        resume.Display(); 

    }
}