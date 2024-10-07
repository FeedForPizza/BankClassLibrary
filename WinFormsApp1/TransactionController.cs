using BankClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForm
{
    public class TransactionController
    {
        private Transaction model;

        public TransactionController(Transaction aTransaction)
        {
            model = aTransaction;
        }

        public void DisplayTransactionInformation()
        {
            Console.WriteLine((model._TypeOfTransaction == TransactionType.DEPOSIT ? "Deposit" : "Withdraw") + " is done.");
            Console.WriteLine($"Amount of transaction is {model.MoneyAmount}, date of the transaction is {model.TransactionDate.ToString("yyyy-mm-dd")}" +
                $", location of transaction is {model.LocationString}");
        }
    }
}
