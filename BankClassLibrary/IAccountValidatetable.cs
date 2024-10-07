using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClassLibrary
{
    internal interface IAccountValidatetable
    {
        //Methods for validating a created account 
        bool isCustomerNameValid(string aCustomerName);

        bool isBirthDateValid(DateTime aBirthDate);

        bool isDepositedMoneyRequestValid(double aMoney);
        bool isWithdrawMoneyRequestValid(double aMoney);
    }
}
