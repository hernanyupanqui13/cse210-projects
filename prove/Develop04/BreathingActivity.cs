public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        this._name = "Breathing Activity";
        this._description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        this.DisplayStartingMessage();
    }

    public void Run()
    {
        Console.WriteLine("Get Ready...");
        base.ShowSpinner(4);
        Console.WriteLine();
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(this.GetDuration());

        while (DateTime.Now < endTime) {
            this.ShowOneBreatheCicleInstructions(4, 6);
            Console.WriteLine();
        }


    }

    public void ShowOneBreatheCicleInstructions(int breathInDuration, int breathOutDuration) {
        Console.Write("Breathe in...");
        this.ShowCountDown(breathInDuration);
        Console.WriteLine();
        Console.Write("Now breathe out...");
        this.ShowCountDown(breathOutDuration);
        Console.WriteLine();
    }
}