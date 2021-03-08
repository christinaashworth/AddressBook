using System;
using System.Collections.Generic; 

namespace AddressBook
{
  public class AddressBook
  {
    private Dictionary<string, Contact> ContactList = new Dictionary<string, Contact>();
      public void AddContact(Contact person)
        {
        try
          {
          ContactList.Add(person.Email, person);
          }
        catch (ArgumentException)
          {
          Console.WriteLine("Uh oh! You've already added this person.");
          }
        }
    public Contact GetByEmail(string email)
    { try 
      {
      return ContactList[email];
      }
      catch (KeyNotFoundException)
      {
      Console.WriteLine($"Sorry, {email} doesn't match any existing contact.");
      return null;
      }
    }
  }
}
