using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace AddressBooks
{
    public class AddressBook
    {
        List<Contact> addContact = new List<Contact>();
        Contact contact = new Contact();
        public void AddContact()
        {

            Console.WriteLine("Enter the Address Details");

            Contact contact1 = new Contact()
            {
                FirstName = Convert.ToString(Console.ReadLine()),

                LastName = Convert.ToString(Console.ReadLine()),

                Address = Convert.ToString(Console.ReadLine()),

                City = Convert.ToString(Console.ReadLine()),

                State = Convert.ToString(Console.ReadLine()),

                ZipCode = Convert.ToInt32(Console.ReadLine()),

                MobileNumber = Convert.ToInt64(Console.ReadLine()),

                Email = Convert.ToString(Console.ReadLine()),

            };
            Contact contact2 = new Contact()
            {
                FirstName = "Sunny",

                LastName = "Sejwar",

                Address = "Gwalior",

                City = "Gwalior",

                State = "MP",

                ZipCode = 490021,

                MobileNumber = 78828883835,

                Email = "Sunnysejwar@com",

            };

            Contact contact3 = new Contact()
            {
                FirstName = "Vansh",

                LastName = "Sharma",

                Address = "Bhopal",

                City = "BHopal",

                State = "MP",

                ZipCode = 490055,

                MobileNumber = 99828883835,

                Email = "Vansh@gmail.com",

            };
            addContact.Add(contact1);
            addContact.Add(contact2);
            addContact.Add(contact3);
        }
        public void Display()
        {
            foreach (var contact in addContact)
            {
                Console.WriteLine(contact.FirstName + " " + contact.LastName + " " + contact.Address + " " + contact.City + " " + contact.State + " " + contact.ZipCode + " " + contact.MobileNumber + " " + contact.Email);
            }
        }

    }
}