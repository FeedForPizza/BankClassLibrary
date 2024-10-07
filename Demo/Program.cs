using BankClassLibrary;
using System;


namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopCondition = true;

            Account myAccount = CreateAccount();
            while (loopCondition)
            {
                //DepositMoney
                DepositMoney(myAccount,1000);
                //Display Transaction 
                myAccount.ListOfTransaction.DisplayTransactionInformation();
                //Widthdraw Money 
                WithdrawMoney(myAccount,500);
                //Display Transaction 
                myAccount.ListOfTransaction.DisplayTransactionInformation();
                //Balance   
                DisplayBalance(myAccount);

                UtilityClass.PressAnyKeyToContinue();
            }
 
        }
        private static void DepositMoney(Account aAccount,double aAmount)
        {
            aAccount.DepositMoney(aAmount);
        }
        private static void WithdrawMoney(Account aAccount, double aAmount)
        {
            aAccount.WithdrawMoney(aAmount);
        }
        private static void DisplayBalance(Account aAccount)
        {
            aAccount.DisplayBalance();
        }
        private static Account CreateAccount()
        {
            string customerName = UtilityClass.ReadTextInput("Please enter your name: ");


            int day = UtilityClass.ReadNumberInput("Please enter your day of birth:");
            int month = UtilityClass.ReadNumberInput("Please enter your month of birth:");
            int year = UtilityClass.ReadNumberInput("Please enter your year of birth:");


            string phone = UtilityClass.ReadTextInput("Please enter your Phone Number");
            string address = "";
            UtilityClass.ReadTextInput("Please enter your address", ref address);

            Account newAccount = new Account(customerName, new DateTime(year, month, day), phone, address);

            return newAccount;

        }
    }
}
