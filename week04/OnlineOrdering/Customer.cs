public class Customer
{
    private string _name;
    private Address _address = new Address();

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.FullStreetAddress();
    }
    public bool LivesInUSA()
    {
        return _address.InUSA();
    }

    public void SetCustomer(string name, string address)
    {
        _name = name;
        _address.SetAddress(address);
    }
    
    // public void SetAddress(string address)
    // {
    //     _address.SetAddress(address);
    // }

}