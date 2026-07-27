using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvidence;
    private string _country;

    public Address(string street, string city, string stateProvidence, string country)
    {

    }

    public bool IsInUSA()
    {
        if(_country.ToUpper() == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public string GetDisplayAddress()
    {
        return $"{_street}\n{_city}, {_stateProvidence}\n{_country}";
    }
}