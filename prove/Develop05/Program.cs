using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager gManager = new GoalManager(0, new List<Goal>(){new SimpleGoal("First goal", "First goal description", 10)
        , new SimpleGoal("Second goal", "Second goal description", 20)
        , new SimpleGoal("Third goal", "Third goal description", 30)});
        gManager.Start();
    }
}