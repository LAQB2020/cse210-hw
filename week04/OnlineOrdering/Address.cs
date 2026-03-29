public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
//Constructors
    public Address()
    {
        _street = "This is";
        _city = "not a ";
        _state = "valid";
        _country = "address";
    }
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
//Getters and Setters
    public string GetStreet()
    {
        return _street;
    }
    public void SetStreet(string street)
    {
        _street = street;
    }
    public string GetCity()
    {
        return _city;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public string GetState()
    {
        return _state;
    }
    public void SetState(string state)
    {
        _state = state;
    }
    public string GetCountry()
    {
        return _country;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }
//Methods
    public bool IsInUsa()
    {
        if (_country == "USA")
        {
            return true;
        }
        return false;
    }
    public string FullAdress()
    {
        return GetStreet()+", "+GetCity()+"\n"+GetState()+", "+GetCountry();
    }
}