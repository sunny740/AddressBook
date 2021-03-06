using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using CsvHelper;
using System.Globalization;
using System.Text.Json;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace AddressBooks
{
    public class AddressBookss
    {
        List<Contact> addressBook = new List<Contact>();
        Dictionary<string, List<Contact>> DictName = new Dictionary<string, List<Contact>>();
        Contact contact = new Contact();
        const string filePath = @"H:\Assignments\AddressBook\AddressBookProgram\ContactBook.txt";
        const string IMPORT_CSV = @"E:\BridgeLabzProject\AddressBook\AddressBooks\AdressBook.CSV";
        const string EXPORT_CSV = @"E:\BridgeLabzProject\AddressBook\AddressBooks\AdressBook.CSV";
        const string EXPORT_JSON = @"E:\BridgeLabzProject\AddressBook\AddressBooks\EXPORT_JSON.json";
        public AddressBookss()
        {
            Contact contact1 = new Contact()
            {
                FirstName = "Sun",
                LastName = "Ehan",
                Address = "BP Nagar",
                Email = "sun000@gmail.com",
                MobileNumber = 7772345678,
                City = "jayawada",
                State = "MP",
                ZipCode = 470324
            };
            Contact contact2 = new Contact()
            {
                FirstName = "Jeck",
                LastName = "Ajjan",
                Address = "Moti Place",
                Email = "Jack99@gmail.com",
                MobileNumber = 8881234567,
                City = "Noroli",
                State = "Mp",
                ZipCode = 473432
            };
            addressBook.Add(contact1);
            addressBook.Add(contact2);
        }
        public void CreateContacts()
        {

            Console.WriteLine("Enter Your First: ");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name: ");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Your Address: ");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter Your Email Id: ");
            contact.Email = Console.ReadLine();
            Console.WriteLine("Enter Your MobileNumber: ");
            contact.MobileNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Your City: ");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter Your State: ");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter Your Zip Code: ");
            contact.ZipCode = Convert.ToInt32(Console.ReadLine());
            addressBook.Add(contact);
        }
        public void CheckDuplicateContact(string firstName)
        {
            foreach (Contact contact in addressBook)
            {
                if (contact.FirstName == firstName)
                {
                    Console.WriteLine("Name is Already Present, Please Enter Different Name.\n");
                    Console.WriteLine("Enter New Contact Details.");
                    CreateContacts();
                }
                else
                {
                    DisplayCon();
                }
            }
        }
        public void AddCon(Contact contact)
        {
            addressBook.Add(contact);
        }
        public void DisplayCon()
        {
            Console.WriteLine("<<<  AddressBook List  >>>");
            foreach (Contact contact in addressBook)
            {
                Console.WriteLine("\nFirstName : " + contact.FirstName + "\nLasrName : " + contact.LastName +
                    "\nAddress : " + contact.Address + "\nEmail : " + contact.Email + "\nPhone : " + contact.MobileNumber +
                    "\nCity :" + contact.City + "\nState : " + contact.State + "\nZipCode : " + contact.ZipCode);
                Console.WriteLine("\n");
            }
        }
        public void EditCon(string name)
        {
            foreach (var contact in addressBook)
            {
                if (contact.FirstName.Equals(name))
                {
                    Console.WriteLine("Edit a Contact Of \n1. LastName\n2. Address\n3. Email\n4. PhoneNumber\n5. City\n6. State\n7. ZipCode\n");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter Your Last Name You Want To Edit : ");
                            contact.LastName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter Your Address You want to edit : ");
                            contact.Address = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter The City: ");
                            contact.City = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter The State You Want to Edit : ");
                            contact.State = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter Your Email You Want To Edit : ");
                            contact.Email = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter The Zip You Want To Edit : ");
                            contact.ZipCode = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 7:
                            Console.WriteLine("enter the phone you want To edit : ");
                            contact.MobileNumber = Convert.ToInt64(Console.ReadLine());
                            break;
                        default:
                            Console.WriteLine("Choose the right option : ");
                            break;
                    }
                }
            }
            DisplayCon();
        }
        public void DelCon()
        {
            Contact delete = new Contact();
            Console.WriteLine("To Delete Contact List Enter Contact FirstName here : ");
            string name = Console.ReadLine();
            foreach (Contact contact in addressBook)
            {
                if (contact.FirstName.Equals(name))
                {
                    delete = contact;
                }
            }
            addressBook.Remove(delete);
            DisplayCon();
        }
        public void AddMultipleContacts()
        {
            Console.WriteLine("Enter The Number Of Contacts To Be Added: ");
            int numCon = Convert.ToInt32(Console.ReadLine());

            while (numCon > 0)
            {
                CreateContacts();
                numCon--;
            }
            DisplayCon();
        }
        public void AddDictData(string name)
        {
            foreach (var data in DictName)
            {
                if (DictName.Keys.Equals(name))
                {
                    addressBook = data.Value;
                }
                Console.WriteLine(DictName);
            }
        }
        public void displayDictionaryData(string name)
        {
            foreach (var data in DictName)
            {
                if (data.Key.Equals(name))
                {
                    addressBook = data.Value;
                }
                Console.WriteLine(DictName);
            }
        }
        public void EditDict(string name, string contactName)
        {
            foreach (var data in DictName)
            {
                if (data.Key.Equals(name))
                {
                    addressBook = data.Value;
                }
            }
            EditCon(contactName);
            DisplayCon();
        }
        public bool NameExists(string name)
        {
            foreach (var data in addressBook)
            {
                if (data.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
        public void SearchPersonCity(string cityName)
        {
            Console.Write("Contact Details Search by City '{0}' : ", cityName);
            foreach (var data in addressBook)
            {
                if (data.City.Equals(cityName))
                {
                    Console.WriteLine(data.FirstName + ", " + data.LastName + ", " + data.Email + ", " + data.MobileNumber +
                        ", " + data.City + ", " + data.State + ", " + data.ZipCode);
                }
            }
        }
        public void ViewPersonByCity()
        {
            Console.Write("View By City/State : ");
            string cityNames = Console.ReadLine();
            var obj = addressBook.FindAll(x => x.City == cityNames || x.State == cityNames);
            if (obj.Count > 0)
            {
                foreach (var data in obj)
                {
                    Console.WriteLine(data.FirstName + ", " + data.City + ", " + data.State);
                }
            }
            else
            {
                Console.WriteLine("Enter City/State Name That Present in List.");
            }
        }
        public void CountByCity()
        {
            int count = 0;
            Console.Write("Count By City/State : ");
            string cityNames = Console.ReadLine();
            var obj = addressBook.FindAll(x => x.City == cityNames || x.State == cityNames);
            if (obj.Count > 0)
            {
                foreach (var data in obj)
                {
                    count++;
                }
                Console.Write("Total Person are :", +obj.Count);
                Console.Write(count);
            }
            else
            {
                Console.WriteLine("Enter City/State Name That Present in List.;");
            }
        }
        public void SortNameByAlphabeticalOrder()
        {
            List<string> SortedByAlphabet = new List<string>();
            foreach (Contact contact in addressBook)
            {
                string name = contact.FirstName.ToString();
                SortedByAlphabet.Add(name);
            }
            SortedByAlphabet.Sort();
            foreach (string name in SortedByAlphabet)
            {
                Console.WriteLine(name);
            }
        }
        public void SortNameByCityStateZip()
        {
            List<string> SortedByZip = new List<string>();
            foreach (Contact contact in addressBook)
            {
                string data1 = null;
                if (data1 == contact.City.ToString() || data1 == contact.City || data1 == contact.State)
                    SortedByZip.Add(data1);
            }
            SortedByZip.Sort();
            foreach (var data in addressBook)
            {
                Console.WriteLine(data.FirstName + ", " + data.LastName + ", " + data.City + ", " + data.State + ", " + data.ZipCode);
            }
        }
        public void ReadingFileIO()
        {
            if (File.Exists(filePath))
            {
                StreamReader read = new StreamReader(filePath);
                try
                {
                    string s = "";
                    while ((s = read.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void ReadAndWriteDataFromCSV()
        {
            using (var reader = new StreamReader(IMPORT_CSV))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<Contact>().ToList();
                    Console.WriteLine("After Reading CSV File");
                    foreach (var data in records)
                    {
                        Console.WriteLine(data.FirstName + ", " + data.LastName + ", " + data.Email + ", " + data.MobileNumber +
                        ", " + data.City + ", " + data.State + ", " + data.ZipCode);
                    }
                    using (var writer = new StreamWriter(EXPORT_CSV))
                    {
                        using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                        {
                            csvExport.WriteRecords(records);
                        }
                    }
                }
            }
        }
        public void ReadAndWriteDataFromCSVJson()
        {
            using (var reader = new StreamReader(IMPORT_CSV))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<Contact>().ToList();
                    Console.WriteLine("After Reading CSV File");
                    foreach (var data in records)
                    {
                        Console.WriteLine(data.FirstName + ", " + data.LastName + ", " + data.Email + ", " + data.MobileNumber +
                       ", " + data.City + ", " + data.State + ", " + data.ZipCode);
                    }
                    JsonSerializer serializer = new JsonSerializer();
                    using (var writter = new StreamWriter(EXPORT_JSON))
                    {
                        using (var writer = new JsonTextWriter(writter))
                        {
                            serializer.Serialize(writer, records);
                        }
                    }
                }
            }
        }
    }
}
