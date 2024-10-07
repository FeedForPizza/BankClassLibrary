using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClassLibrary
{
    public sealed class SavingsAccount : Account
    {
        const double MAX_WITHDRAW = 500;
        public SavingsAccount() : base()
        {
            Commision = 0.005f;  
        }

        public SavingsAccount(int aAccountId, string aCustomerName, DateTime aDateOfBirth,
                               string aPhone = null, string aAddress = null) : base(aAccountId, aCustomerName, aDateOfBirth, aPhone, aAddress)
        {
            Commision = 0.005f;
        }

        public override bool DepositMoney(double aAmount)
        {
            if (!isDepositedMoneyRequestValid(aAmount))
            {
                return false;
            }
            return base.DepositMoney(aAmount);
        }

        public override bool WithdrawMoney(double aAmount)
        {
            if (!isWithdrawMoneyRequestValid(aAmount))
            {
                return false;
            }

            return base.WithdrawMoney(aAmount);
        }
        public override bool isWithdrawMoneyRequestValid(double aMoney)
        {
            if (aMoney > MAX_WITHDRAW)
            {
                return false;
            }
            return true;
        }
    }
}
