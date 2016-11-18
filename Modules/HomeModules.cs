using Nancy;
using System;
using System.Collections.Generic;
using AddressBook.Objects;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>{
        return View["index.cshtml", Contact.GetAll()];
      };
      Get["/contacts/add"] =_=>{
        return View["contact_form.cshtml"];
      };
      Post["/"] = _ =>
      {
        Contact newContact = new Contact (Request.Form["name"], Request.Form["phone"], Request.Form["address"]);
        List<Contact> allContacts = Contact.GetAll();
        return View["index.cshtml", allContacts];
      };
      Get["/contacts/{id}"] = parameters =>{
        var currentContact = Contact.FindId(parameters.id);
        return View["contact.cshtml", currentContact];
      };
    }
  }
}
