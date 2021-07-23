using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanckClassLibrary
{
    public class Customer
    {
        string        _CustomerName;
        DateTime      _DateOfBirth;
        string        _PhoneNumber;
        string        _Address;

        public string CustomerName
        {
            get
            {
                return _CustomerName;
            }
        }
        public DateTime DateOfBirth
        {
            get
            {
                return _DateOfBirth;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return _PhoneNumber;
            }
        }
        public string Address
        {
            get
            {
                return _Address;
            }
        }

        //private Customer accountCustomer;

        public Customer(string aCustomerName, DateTime aDateOfBirth,string aPhoneNumber,string aAddress)
        {
            _CustomerName = aCustomerName;
            _DateOfBirth  = aDateOfBirth;
            _PhoneNumber  = aPhoneNumber;
            _Address      = aAddress;

        }

        //Copy Constructor
        public Customer(Customer accountCustomer)
        {
            _CustomerName = accountCustomer._CustomerName;
            _DateOfBirth  = accountCustomer._DateOfBirth;
            _PhoneNumber  = accountCustomer._PhoneNumber;
            _Address      = accountCustomer._Address;
        }

       
    }
}
