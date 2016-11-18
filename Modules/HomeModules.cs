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

      Post["/contact/new"] = _ =>
      {
        if (Request.Form["name"] == ""){
          string noName = "No Name";
          Contact newContact = new Contact (noName, Request.Form["phone"], Request.Form["address"]);
          return View["new_contact.cshtml", newContact];
        }else{
          Contact newContact = new Contact (Request.Form["name"], Request.Form["phone"], Request.Form["address"]);
          return View["new_contact.cshtml", newContact];
        }
      };

      Get["/contact/{id}"] = parameters =>{
        var currentContact = Contact.FindId(parameters.id);
        return View["contact.cshtml", currentContact];
      };

      Post["/{action}"]= parameters =>{
        if (parameters.action == "clear"){
        Contact.ClearAll();
        }
        return View["clear.cshtml"];
      };

      Get["/contact/search"] = _ =>{
        return View["search.cshtml"];
      };
      Post["/contact/search_result"] = _ =>{
        string searchName = Request.Form["search"];
        var searchResults = Contact.SearchContact(searchName);
        return View["results.cshtml", searchResults];
      };
    }
  }
}
