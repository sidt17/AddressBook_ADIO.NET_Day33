using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressModelClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public long PhoneNumber { get; set; }
        public string EmailId { get; set; }

        public void EnterNewDetails(AddressModelClass Add)
        {
            Console.WriteLine("Enter the First Name :");
            Add.FirstName = Console.ReadLine();

            Console.WriteLine("Enter the Last Name :");
            Add.LastName = Console.ReadLine();

            Console.WriteLine("Enter the Address :");
            Add.Address = Console.ReadLine();

            Console.WriteLine("Enter the City :");
            Add.City = Console.ReadLine();



            Console.WriteLine("Enter the State :");
            Add.State = Console.ReadLine();

            Console.WriteLine("Enter the ZipCode :");
            Add.ZipCode = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the PhoneNumber :");
            Add.PhoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter the EmailId :");
            Add.EmailId = Console.ReadLine();


        }




    }

}

