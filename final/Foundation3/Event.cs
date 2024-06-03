// Base Event class
public abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, DateTime date, string time, Address address)
    {
        this._title = title;
        this._description = description;
        this._date = date;
        this._time = time;
        this._address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_address.GetAsString()}";
    }

    public abstract string GetFullDetails();

    public string GetShortDescription()
    {
        return $"{GetType().Name}: {_title} on {_date.ToShortDateString()}";
    }
}
