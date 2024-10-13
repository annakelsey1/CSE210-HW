// “Address” Class:
//  A string for Street, City, State and Country  |  Sets up variables for the address
// Address(Street, City, State, Country)  |  Method that stores the addresses together
// US or not  |  Method that returns if they’re in the usa, will be called in order class

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;


    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool InUS()
    {
        return _country == "USA";
    }

    public string GetAddress()
    {
        return _street + " " + _city + ", " + _state + " " + _country;
    }
}