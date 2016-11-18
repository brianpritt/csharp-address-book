using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _name;
    private string _phone;
    private string _address;
    private int _id;

    private static List<Contact> _allContacts = new List<Contact> {};

    public Contact(string contactName, string contactPhone, string contactAddress)
    {
      _name = contactName;
      _phone = contactPhone;
      _address = contactAddress;
      _allContacts.Add(this);
      _id = _allContacts.Count;
    }
    public static List<Contact> GetAll()
    {
      return _allContacts;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }

    public string GetPhone()
    {
      return _phone;
    }
    public void SetPhone(string newPhone)
    {
      _phone = newPhone;
    }
    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }
    public int GetId()
    {
      return _id;
    }
    public static Contact FindId(int idNumber)
    {
      return _allContacts[idNumber -1];
    }
    public static void ClearAll()
    {
        _allContacts.Clear();
    }
  }
}
