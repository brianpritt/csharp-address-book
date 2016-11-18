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
      Get["/contact/new"] =_=>{
        return View["contact_form.cshtml"];
      };
      Post["/"] = _ =>
      {
        if (Request.Form["name"] == ""){
          string noName = "No Name";
          Contact newContact = new Contact (noName, Request.Form["phone"], Request.Form["address"]);
          List<Contact> allContacts = Contact.GetAll();
          return View["index.cshtml", allContacts];
        }else{
          Console.WriteLine("Name");
          Contact newContact = new Contact (Request.Form["name"], Request.Form["phone"], Request.Form["address"]);
          List<Contact> allContacts = Contact.GetAll();
          return View["index.cshtml", allContacts];
        }
      };
      Get["/contact/{id}"] = parameters =>{
        var currentContact = Contact.FindId(parameters.id);
        return View["contact.cshtml", currentContact];
      };
      Post["/clear"]= _ =>{
        Contact.ClearAll();
        return View["clear.cshtml"];
      };
    }
  }
}
