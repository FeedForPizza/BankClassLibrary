using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClassLibrary
{
    public class Customer
    {
         string _CustomerName;
        DateTime _DateOfBirth;
         string _PhoneNumber;
         string _Address;

        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
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

        public Customer(string aCustomerName, DateTime aDateOfBirth, string aPhone = null, string aAddress = null)
        {
            _CustomerName = aCustomerName;
            _DateOfBirth = aDateOfBirth;
            _PhoneNumber = aPhone;
            _Address = aAddress;
        }
        // Copy Constructor
        public Customer(Customer accountCustomer)
        {
            _CustomerName = accountCustomer._CustomerName;
            _DateOfBirth = accountCustomer._DateOfBirth;
            _PhoneNumber = accountCustomer._PhoneNumber;
            _Address = accountCustomer._Address;
        }
    }
}
