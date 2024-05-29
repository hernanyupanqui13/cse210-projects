public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        this._street = street;
        this._city = city;
        this._stateOrProvince = stateOrProvince;
        this._country = country;
    }

    public string GetAsString()
    {
        return $"{_street}, {_city}, {_stateOrProvince}, {_country}";
    }
}