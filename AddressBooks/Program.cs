using System;
using AddressBooks;
class program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("***** WelCome To Address-Book ******");
        bool end = true;
        Console.WriteLine("\nSelectNumber\n1. Create Contact\n2. Display Contact\n3. Edit Contact\n4. Delete Contact\n5. Add Multiple Contacts\n" +
                "6. Add Data in Dictionary\n7. Edit data in Dictionary\n8. Display Dictionary info\n9. Duplicate Contact Check\n10. Search Through City\n" +
                "11. View By City/State\n12. Count By City\n13. Sort Name By Alphabet.");
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
                    cont.AddMultipleContacts();
                    break;
                case 6:
                    Console.Write("Enter the Name for Adding data in Dictionary : ");
                    string dictionaryName = Console.ReadLine();
                    cont.AddDictData(dictionaryName);
                    break;
                case 7:
                    Console.Write("Enter the Name for Editing data in Dictionary : ");
                    string dictName = Console.ReadLine();
                    string contactName = Console.ReadLine();
                    cont.EditDict(dictName, contactName);
                    break;
                case 8:
                    Console.Write("Enter the Name for Display data in Dictionary : ");
                    string dictionary = Console.ReadLine();
                    cont.displayDictionaryData(dictionary);
                    break;
                case 9:
                    Console.Write("Enter the FirstName for Check Duplicate Contact in Dictionary : ");
                    string firstName = Console.ReadLine();
                    cont.CheckDuplicateContact(firstName);
                    break;
                case 10:
                    Console.Write("Search Contact through City: ");
                    string cityName = Console.ReadLine();
                    cont.SearchPersonCity(cityName);
                    break;
                case 11:
                    cont.ViewPersonByCity();
                    break;
                case 12:
                    cont.CountByCity();
                    break;
                case 13:
                    cont.SortNameByAlphabeticalOrder();
                    break;
                default:
                    end = false;
                    Console.WriteLine("Program Is Ended");
                    break;
            }
        }
    }
}