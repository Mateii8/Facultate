using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();

            do
            {
                Console.WriteLine("Alegeti comanda dorita : ");
                Console.WriteLine("1. Adaugare contact");
                Console.WriteLine("2. Stergere contact");
                Console.WriteLine("3. Cautare contact");
                Console.WriteLine("4. Afisare toate contactele");
                Console.WriteLine("Optiunea dumneavoastra : ");
                int numContacts = int.Parse(Console.ReadLine());
                switch (numContacts)
                {
                    case 1:
                        Console.Write($"Introduceti numele contactului : ");
                        string name = Console.ReadLine();
                        Console.Write($"Introduceti numarul de telefon al contactului  : ");
                        string phoneNumber = Console.ReadLine();
                        Contact contact = new Contact(name, phoneNumber);
                        agenda.AddContact(contact);
                        break;

                    case 2:
                        agenda.DisplayAllContacts();
                        Console.WriteLine("Introduceti numele contactului pe care doriti sa il stergeti: ");
                        agenda.RemoveContact(Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine("Introduceti numele contactului pe care doriti sa il cautati: ");
                        agenda.FindContact(Console.ReadLine());
                        break;

                    case 4:
                        agenda.DisplayAllContacts();
                        break;
                }
                Console.WriteLine("Doriti sa continuati? (da/nu)");
            } while (Console.ReadLine().ToLower() == "da");
        }
    }
}
