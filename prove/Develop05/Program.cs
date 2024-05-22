/*
-Added a way to avoid recwiving porint for the same goal twice.
- Added a customized emssage when there are no goals saved or created
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