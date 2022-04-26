using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Address Book System");

            AddressModelClass addressbook = new AddressModelClass();
            AddressBook Details = new AddressBook();

            Console.WriteLine("Enter the First Name :");
            addressbook.FirstName = Console.ReadLine();

            Console.WriteLine("Enter the Last Name :");
            addressbook.LastName = Console.ReadLine();

            Console.WriteLine("Enter the Address :");
            addressbook.Address = Console.ReadLine();

            Console.WriteLine("Enter the City :");
            addressbook.City = Console.ReadLine();



            Console.WriteLine("Enter the State :");
            addressbook.State = Console.ReadLine();

            Console.WriteLine("Enter the ZipCode :");
            addressbook.ZipCode = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the PhoneNumber :");
            addressbook.PhoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter the EmailId :");
            addressbook.EmailId = Console.ReadLine();




            Details.AddDetails(addressbook);

            addressbook.EditDetails();
        }

    }
}

