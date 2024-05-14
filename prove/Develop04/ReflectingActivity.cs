public class ReflectingActivity : Activity
{
    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>();
    public ReflectingActivity()
    {
        this._name = "Reflecting Activity";
        this._description = "This activity will help you reflect on your day by asking yourself questions about what you did today.";
    }

    public void Run()
    {

    }

    public string GetRandomPrompt()
    {
        return "";
    }

    public string GetRandomQuestion()
    {
        return "";
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestion()
    {

    }
}