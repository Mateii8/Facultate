using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica
{
    internal class Agenda
    {
        List<Contact> contacts;
        public Agenda()
        {
            contacts = new List<Contact>();
        }
        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }
        public void RemoveContact(string name)
        {
            List<Contact> foundContacts = contacts.Where(c => c.Name == name).ToList();

            foreach (Contact contact in foundContacts)
            {
                contacts.Remove(contact);
            }
        }
        public void FindContact(string name)
        {
            List<Contact> foundContacts = contacts.Where(c => c.Name == name).ToList();

            if (foundContacts.Count == 0)
            {
                Console.WriteLine(" No contacts found with the given name.");
                return;
            }
            else
            {
                Console.WriteLine(" Contacts found : ");
                foreach (Contact contact in foundContacts)
                {
                    Console.WriteLine($" Contact : {contact.Name} - {contact.PhoneNumber}");
                }

            }
        }

        public void DisplayAllContacts()
        {
            Console.WriteLine("All contacts is in the agenda : ");

            contacts=contacts.OrderBy(contact => contact.Name).ToList();

            foreach(Contact contact in contacts)
            {
                Console.WriteLine($" Contact : {contact.Name} - {contact.PhoneNumber}");
            }
        }

    }    
}
