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
            Console.WriteLine("Enter The Address Details");

            Contact contact1 = new Contact()
            {
                FirstName = Console.ReadLine(),

                LastName = Console.ReadLine(),

                Address = Console.ReadLine(),

                City = Console.ReadLine(),

                State = Console.ReadLine(),

                ZipCode = Convert.ToInt32(Console.ReadLine()),

                MobileNumber = Convert.ToInt64(Console.ReadLine()),

                Email = Console.ReadLine(),

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
        public void Update()
        {
            foreach (var contact in addContact)
            {
                Console.WriteLine("Enter The Number First Name");
                string name = Console.ReadLine();

                if (contact.FirstName.Equals(name))
                {
                    Console.WriteLine("1.LastName\n2.Address\n3.City\n4.State\n5.Pin\n6.PhoneNumber\n7.Email ");
                    int optionn = Convert.ToInt32(Console.ReadLine());
                    switch (optionn)
                    {
                        case 1:
                            Console.WriteLine("Enter The Last Name You Want To Edit : ");
                            contact.LastName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter The Address You Want To Edit :");
                            contact.Address = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter The City: ");
                            contact.City = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter The State You Want To Edit :");
                            contact.State = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter The Email You Want To Edit :");
                            contact.Email = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter The Zip You Want To Edit :");
                            contact.ZipCode = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 7:
                            Console.WriteLine("Enter The Mobile You Want To Edit :");
                            contact.MobileNumber = Convert.ToInt64(Console.ReadLine());
                            break;
                        default:
                            Console.WriteLine("Choose The Right Option : ");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Name Not Exist");
                }
                Display();
            }
        }
        public void Delete()
        {
            Contact d = new Contact();
            Console.WriteLine("Enter First Name");
            string name = Convert.ToString(Console.ReadLine());
            foreach (var contact in addContact)
            {
                if (contact.FirstName.Equals(name))
                {
                    d = contact;
                }
            }
            addContact.Remove(d);
            Display();
        }

        public void AddMultipleContacts()
        {
            Console.WriteLine("Enter The Number Of Contacts To Be Added: ");
            int numberOfContacts = Convert.ToInt32(Console.ReadLine());
            while (numberOfContacts > 0)
            {
                AddContact();
                numberOfContacts--;
            }
        }
    }
}