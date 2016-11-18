using System.Collection.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _name;
    private string _phone;
    private string _address;
    private int _id;

    Private static List<Contact> _allContacts = new List<Contact> {};

    public Contact(string contactName, string contactPhone, strin contactAddress)
    {
      _name = contactName;
      _phone = contactPhone;
      _address = contactAddress;
      _allContacts.Add(this);
      _id = _allContacts.Count;
    }
  }
}
