using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica
{
    internal class Contact
    {
        private string name;
        private string phoneNumber;
        public Contact(string name, string phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
        }

        public string Name
        {
           get { return name; }
           set { name = value; }
        }
        public string PhoneNumber
        {
           get { return phoneNumber; }
           set { phoneNumber = value; }
        }


    }
}
