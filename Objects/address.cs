using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Address
  {
    private string _street;
    private string _city;
    private string _state;
    private int _zipcode;
    private int _id;

    private static List<Address> _allAddress = new List<Address> {};

    public Address(string streetAddress, string cityAddress, string stateAddress, int zipAddress)
    {
      _street = streetAddress;
      _city = cityAddress;
      _state = stateAddress;
      _zipcode = zipAddress;
      _allAddress.Add(this);
      _id = _allAddress.Count;
    }
    public string GetStreet()
    {
      return _street;
    }
    public void SetStreet(string newStreet)
    {
      _street = newStreet;
    }

    public string GetCity()
    {
      return _city;
    }
    public void SetCity(string newCity)
    {
      _city = newCity;
    }

    public string GetState()
    {
      return _state;
    }
    public void SetState(string newState)
    {
      _state = newState;
    }

    public int GetZip()
    {
      return _zipcode;
    }
    public void SetZip(int newZip)
    {
      _zipcode = newZip;
    }


  }
}
