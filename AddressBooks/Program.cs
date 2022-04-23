using System;
using AddressBooks;
class program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("***** WelCome To Address-Book ******");
        bool end = true;
        Console.WriteLine("\nSelect The Number\n1. Add Contact\n2. Display\n3. EditContact\n4. DeleteContact\n5. " +
            "Add Data in Dictionary\n6. Edit data in Dictionary\n7. Display Dictionary info\n8. End Of Program");
        Contact contact = new Contact();
        AddressBookss cont = new AddressBookss();
        while (end)
        {
            Console.WriteLine("\nChoose Option to Execute Program : ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    cont.CreateContacts();
                    break;
                case 2:
                    cont.DisplayCon();
                    break;
                case 3:
                    string name = Console.ReadLine();
                    cont.EditCon(name);
                    break;
                case 4:
                    cont.DelCon();
                    break;
                case 5:
                    Console.Write("Enter the Name for Adding data in Dictionary : ");
                    string dictionaryName = Console.ReadLine();
                    cont.AddDictData(dictionaryName);
                    break;
                case 6:
                    Console.Write("Enter the Name for Editing data in Dictionary : ");
                    string dictName = Console.ReadLine();
                    string contactName = Console.ReadLine();
                    cont.EditDict(dictName, contactName);
                    break;
                case 7:
                    Console.Write("Enter the Name for Display data in Dictionary : ");
                    string dictionary = Console.ReadLine();
                    cont.NameExists(dictionary);
                    break;
                case 8:
                    end = false;
                    Console.WriteLine("Program Is Ended");
                    break;
                default:
                    Console.WriteLine("Execution Ends.");
                    break;
            }
        }
    }
}
