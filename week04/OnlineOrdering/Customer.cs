public class Customer
{
    private string _name;
    private Address _address;
    public Customer()
    {
        _name = "Jane Doe";
        _address = new Address();
    }
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    //Getters and setters
    public void SetCustomerName(string name)
    {
        _name = name;
    }
    public string GetCustomerName()
    {
        return _name;
    }
    public void SetCustomerAddress(Address address)
    {
        _address = address;
    }
    public Address GetCustomerAddress()
    {
        return _address;
    }
    public bool LiveInUsa()
    {
        return _address.IsInUsa();
    }
}