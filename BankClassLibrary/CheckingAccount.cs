using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClassLibrary
{
    public sealed class CheckingAccount : Account 
    {
        const double MIN_DEPOSIT = 250;
        const double MAX_WITHDRAW = 1000;
        public CheckingAccount() : base()
        {
            Commision = 0.01f;
        }
        
        public CheckingAccount (int aAccountId, string aCustomerName, DateTime aDateOfBirth,
                               string aPhone = null, string aAddress = null) : base(aAccountId,aCustomerName,aDateOfBirth,aPhone,aAddress)
        {
            Commision = 0.01f;
        }

        public override bool DepositMoney(double aAmount)
        {
            double newAmountAfterCommision = aAmount - aAmount * Commision; 
            return base.DepositMoney(newAmountAfterCommision);
        }

        public override bool WithdrawMoney(double aAmount)
        {
            double newAmountAfterCommision = aAmount + aAmount * Commision;
            return base.WithdrawMoney(newAmountAfterCommision);
        }

        public override void DisplayInfoAccount()
        {
            Console.WriteLine("Checking Account Balance: {0}, Commision: {1}",CurrentBalance,Commision);
        }

        public override bool isDepositedMoneyRequestValid(double aMoney)
        {
            if(aMoney < MIN_DEPOSIT)
            {
                return false;
            }
            return true;
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
