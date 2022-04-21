using System;
using AddressBooks;
using AdressBooks;

class program
{
    public static void Main(String[] args)
    {
        AddressBook AB = new AddressBook();
        AB.Book();
        Console.WriteLine("Enter the Address Details");
        AdressBooks.Contact contact = new Contact();
        Console.WriteLine("Enter FirstName");
        contact.FirstName = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Enter LastName");
        contact.LastName = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Enter Address");
        contact.Address = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Enter City");
        contact.City = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Enter State");
        contact.State = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter Email");

        contact.Email = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Enter Zip");
        contact.ZipCode = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Phone Number");
        contact.MobileNumber = Convert.ToInt64(Console.ReadLine());
    }
}