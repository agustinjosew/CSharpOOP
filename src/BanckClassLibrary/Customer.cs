using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanckClassLibrary
{
    public class Customer
    {
        public string        CustomerName;
               DateTime      DateOfBirth;
        public string        PhoneNumber;
        public string        Address;

        private Customer accountCustomer;

        public Customer(string aCustomerName, DateTime aDateOfBirth,string aPhone=null,string aAddress = null)
        {
            CustomerName = aCustomerName;
            DateOfBirth  = aDateOfBirth;
            PhoneNumber  = aPhone;
            Address      = aAddress;

        }

        //Copy Constructor
        public Customer(Customer accountCustomer)
        {
            CustomerName = accountCustomer.CustomerName;
            DateOfBirth  = accountCustomer.DateOfBirth;
            PhoneNumber  = accountCustomer.PhoneNumber;
            Address      = accountCustomer.Address;
        }

       
    }
}
