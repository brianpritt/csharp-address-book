using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _name;
    private string _phone;
    private Address _address;
    private int _id;

    private static List<Contact> _allContacts = new List<Contact> {};

    public Contact(string contactName, string contactPhone, Address contactAddress)
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

    public Address GetAddress()
    {
      return _address;
    }
    public void SetAddress(Address newAddress)
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
    public static void RemoveContact(int contactId)
    {
      _allContacts.RemoveAt(contactId -1);
      int newId = 1;
      foreach (Contact thisContact in _allContacts)
      {
        thisContact._id = newId;
        newId ++;
      }
    }

    public static List<Contact> SearchContact(string searchInput)
    {
      List<Contact> searchList = new List<Contact> {};
      string searchInputLower = searchInput.ToLower();
      foreach (Contact thisContact in _allContacts)
      {
        string contactName = thisContact.GetName().ToLower();
        if (contactName.Contains(searchInputLower))
        {
          searchList.Add(thisContact);
        }
      }
      return searchList;
    }
  }
}
