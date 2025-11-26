public class Address
{
    private string _StreetAddress;
    public bool InUSA()
    {
        string[] unit = _StreetAddress.Split(" ");
        foreach (string word in unit)
        {
            if (word == "USA")
            {
                return true;
            }
        }

        return false;
    }

    public string FullStreetAddress()
    {
        return _StreetAddress;
    }
    
    public void SetAddress(string address)
    {
        _StreetAddress = address;
    }
}