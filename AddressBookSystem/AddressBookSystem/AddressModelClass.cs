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



        public void EditDetails()
        {
            Console.WriteLine("Enter the name you want to edit :");

            if (FirstName == null)
            {
                Console.WriteLine("This name does not exist" + FirstName);
            }
            else
            {
                Console.WriteLine("First name changed successfully" + FirstName);
            }



           

    
        }

    }
}
