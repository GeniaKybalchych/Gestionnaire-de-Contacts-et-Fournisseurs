using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace ProjetFinal
{

public class RegistreContacts
    {
        private List<Contact> Contacts { get; set; }

        public RegistreContacts()
        {
            Contacts = new List<Contact>();
        }

        public List<Contact> GetContacts()
        {
            return Contacts;
        }

        public void AjouterContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        public Contact RechercherContact(string nom)
        {
            return Contacts.Find(contact => contact.Nom.Equals(nom, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
