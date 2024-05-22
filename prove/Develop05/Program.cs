/*
- Added a customized message when there are no goals saved or created
- I added the feature to edit all the types of goals.
- I created a new class called userInputHandler to reduce the redundancy when requesting user input
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager gManager = new GoalManager(0, new List<Goal>());
        gManager.Start();
    }
}