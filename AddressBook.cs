using System.Collections.Generic;

namespace AddressBook
{

    public class AddressBook
    {
        Dictionary<string, Contact> addressBook = new Dictionary<string, Contact>() { };
        public void AddContact(Contact person)
        {
            addressBook.Add(person.Email, person);
        }

        public Contact GetByEmail(string email)
        {
            Contact person;
            addressBook.TryGetValue(email, out person);
            return person;
        }

    }
}