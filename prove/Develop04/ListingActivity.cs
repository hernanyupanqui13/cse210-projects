public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        this._name = "Listing Activity";
        this._description = "This activity will help you reflect on your day by listing the things you did today.";
    }

    public void Run()
    {

    }

    public void GetRandomPrompts()
    {

    }

    public List<string> GetListFromUser()
    {
        return new List<string>();
    }
}